using Yopon.Common;
using Yopon.Flash;
using Yopon.Pigg.Command;
using Yopon.WebSocket;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Yopon.Pigg
{
    internal class PiggChatProxy : IPiggProxy
    {
        public MethodLookup Methods { get; set; }

        public byte[] Key { get; set; }

        public TransparentProxy WebSocketProxy { get; set; }

        public static void Start(string server, int port = 443)
        {
            var proxyType = typeof(ChatMethod);
            var methods = new MethodLookup(proxyType);
            var piggProxy = new PiggChatProxy();
            piggProxy.Methods = methods;
            piggProxy.WebSocketProxy = new TransparentProxy(
                piggProxy.SendHandle, piggProxy.RecvHandle);
            piggProxy.WebSocketProxy.Start(port, server);
        }

        public void SendHandle(ByteArray data)
        {
            try
            {
                var header = new Header(data);
                var input = new ByteArray(header.Body);

                if (YoponSetting.I.IsDebugMode &&
                    header.Type == Header.TYPE_COMMAND)
                {
                    var commandId = header.CommandId;
                    var fieldName = Methods.GetFieldName(commandId);
                    var logPath = YoponSetting.DebugLogFile;
                    var message = $"[CHAT METHOD] {fieldName}";
                    if (DESCipher.IsEncryptData(header.Body, Key))
                        message += " (ENCRYPTED)";
                    Logger.OutputAtBackground(logPath, message);
                }

                if (header.CommandId == ChatMethod.TALK)
                {
                    input.Decrypt(Key);

                    var message = input.ReadUTF().ToLower();
                    
                    var color = ActiveUser.TalkBGColor;

                    if (ActiveUser.TalkBGColor !=
                        System.Drawing.Color.White)
                    {
                        var colorToUint = (uint)(color.R << 16 | color.G << 8 | color.B);
                        var talk = new ByteArray();

                        talk.WriteUTF(message);
                        talk.WriteUnsignedInt(colorToUint);
                        talk.WriteUnsignedInt(colorToUint);
                        talk.Encrypt(Key);

                        header.Body = talk.Bytes;
                        header.Write(data);
                    }

                    if (message == "/log")
                    {
                        var log = ActiveUser.ChatLogFileDir;
                        Directory.CreateDirectory(log);
                        Process.Start("explorer.exe", log);
                        var head = new Header();
                        head.CommandId = ChatMethod.CANCEL_TYPING;
                        head.Write(data);
                    }
                    else if (message == "/debug")
                    {
                        var packet = new Header();
                        var bytes = new ByteArray();

                        if (YoponSetting.I.IsDebugMode)
                        {
                            YoponSetting.I.HasDownloadModule = false;
                            YoponSetting.I.IsDebugMode = false;
                            bytes.WriteUTF("デバッグモードが無効になりました");
                        }
                        else
                        {
                            YoponSetting.I.HasDownloadModule = true;
                            YoponSetting.I.IsDebugMode = true;
                            bytes.WriteUTF("デバッグモードが有効になりました");
                        }

                        packet.CommandId = ChatMethod.ALERT_RESULT;
                        packet.Body = bytes.Bytes;
                        WebSocketProxy.Recv(packet.ToArray());

                        var head = new Header();
                        head.CommandId = ChatMethod.CANCEL_TYPING;
                        head.Write(data);
                    }
                }
                else if (header.CommandId == ChatMethod.MOVE)
                {
                    if (ActiveUser.IsOneClickTeleport)
                    {
                        var head = new Header()
                        {
                            CommandId = ChatMethod.MOVE_END
                        };

                        input.Decrypt(Key);
                        input.Position = input.Length;
                        input.WriteShort(0); // dir
                        input.Encrypt(Key);
                        head.Body = input.Bytes;
                        head.Write(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.OutputAtBackground(
                    YoponSetting.DebugLogFile,
                    $"[ERROR] {ex.ToString()}");
            }

            WebSocketProxy.Send(data);
        }

        public void RecvHandle(ByteArray data)
        {
            try
            {
                var header = new Header(data);
                var input = new ByteArray(header.Body);

                if (YoponSetting.I.IsDebugMode &&
                    header.Type == Header.TYPE_COMMAND)
                {
                    var commandId = header.CommandId;
                    var fieldName = Methods.GetFieldName(commandId);
                    var logPath = YoponSetting.DebugLogFile;
                    var message = $"[CHAT METHOD] {fieldName}";
                    Logger.OutputAtBackground(logPath, message);
                }

                if (header.Type == Header.TYPE_ID)
                {
                    Key = header.CallId.Keys();
                }
                else if (header.CommandId == ChatMethod.ACTION_RESULT)
                {
                    if (YoponSetting.I.HasBlockIllegalAction)
                    {
                        var userCode = input.ReadUTF();
                        var code = input.ReadUTF().ToLower();

                        if (AllowActionList.IsFraud(code))
                            return;
                    }
                }
                else if (header.CommandId == ChatMethod.TALK_RESULT)
                {
                    var hexCode = input.ReadUTFBytes(16);
                    var message = input.ReadUTF();
                    var color = input.ReadUnsignedInt();
                    var amebaId = input.ReadUTF();
                    var nickname = input.ReadUTF();
                    var balloonColor = input.ReadUnsignedInt();
                    var roomIndex = input.ReadInt();
                    var time = DateTime.Now.ToString("hh:mm");

                    if (YoponSetting.I.HasSaveChatLog && (
                        message.StartsWith("/") == false ||
                        YoponSetting.I.HasSaveSlashMessage))
                    {
                        if (string.IsNullOrEmpty(amebaId))
                            amebaId = "null";

                        Task.Run(() =>
                        {
                            // $time=時間, $name=名前 $amebaId=ID, $message=メッセージ

                            var log = string.Empty;

                            if (YoponSetting.I.HasProcessFormat)
                            {
                                log = YoponSetting.I.LogFormat
                                .Replace("$time", time)
                                .Replace("$name", nickname)
                                .Replace("$amebaId", amebaId)
                                .Replace("$message", message);
                            }
                            else
                            {
                                var stringBuilder = new StringBuilder();

                                stringBuilder.Append($"[{time}] ");
                                stringBuilder.Append(nickname);
                                if (!string.IsNullOrEmpty(amebaId))
                                    stringBuilder.Append($" ({amebaId})");
                                stringBuilder.Append(": ");
                                stringBuilder.Append(message);
                                log = stringBuilder.ToString();
                            }

                            lock (this)
                            {
                                Directory.CreateDirectory(ActiveUser.ChatLogFileDir);
                                File.AppendAllText(ActiveUser.ChatLogFilePath, $"{log}\r\n");
                            }
                        });
                    }
                }
                else if (header.CommandId == ChatMethod.ENTER_AREA_RESULT ||
                    header.CommandId == ChatMethod.ENTER_USER_GARDEN_RESULT ||
                    header.CommandId == ChatMethod.ENTER_USER_ROOM_RESULT)
                {
                    ActiveUser.ChatProxy = this;

                    var categoryCode = input.ReadUTF();
                    var categoryName = input.ReadUTF();
                    var areaCode = input.ReadUTF();
                    var areaName = input.ReadUTF();

                    if (YoponSetting.I.HasSaveChatLog)
                    {
                        var log = $"-- {areaName} ({categoryCode}.{areaCode}) へ移動しました";
                        Directory.CreateDirectory(ActiveUser.ChatLogFileDir);
                        File.AppendAllText(ActiveUser.ChatLogFilePath, $"{log}\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.OutputAtBackground(
                    YoponSetting.DebugLogFile,
                    $"[ERROR] {ex.ToString()}");
            }

            WebSocketProxy.Recv(data);
        }
    }
}