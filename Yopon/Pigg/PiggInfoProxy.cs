using Yopon.Common;
using Yopon.Flash;
using Yopon.Pigg.Command;
using Yopon.WebSocket;
using System;

namespace Yopon.Pigg
{
    internal class PiggInfoProxy : IPiggProxy
    {
        public MethodLookup Methods { get; private set; }

        public byte[] Key { get; set; }

        public TransparentProxy WebSocketProxy { get; set; }

        public static void Start(string server, int port = 443)
        {
            var proxyType = typeof(InfoMethod);
            var methods = new MethodLookup(proxyType);
            var piggProxy = new PiggInfoProxy();
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

                if (YoponSetting.I.IsDebugMode &&
                    header.Type == Header.TYPE_COMMAND)
                {
                    var commandId = header.CommandId;
                    var fieldName = Methods.GetFieldName(commandId);
                    var logPath = YoponSetting.DebugLogFile;
                    var message = $"[INFO METHOD] {fieldName}";
                    if (DESCipher.IsEncryptData(header.Body, Key))
                        message += " (ENCRYPTED)";
                    Logger.OutputAtBackground(logPath, message);
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
                    var message = $"[INFO METHOD] {fieldName}";
                    Logger.OutputAtBackground(logPath, message);
                }

                if (header.Type == Header.TYPE_ID)
                {
                    Key = header.CallId.Keys();
                }
                else if (header.CommandId == InfoMethod.LOGIN_RESULT)
                {
                    ActiveUser.InfoProxy = this;

                    var isSuccess = input.ReadBoolean();
                    var ticket = input.ReadUTF();
                    var amebaId = input.ReadUTF();
                    var asUserId = input.ReadUTF();
                    var nickname = input.ReadUTF();
                    var code = input.ReadUTF();

                    ActiveUser.AmebaId = amebaId;
                    ActiveUser.Nickname = nickname;
                    ActiveUser.AsUserId = asUserId;
                    ActiveUser.HexCode = code;
                }
                else if (header.CommandId == InfoMethod.GET_AREA_RESULT)
                {
                    var category = input.ReadUTF();
                    var code = input.ReadUTF();
                    var server = input.ReadUTF();
                    var protocol = input.ReadUTF();
                    var localIP = ProductConfiguration.LocalIP;
                    var port = Rand.om(49152, 65535);
                    var url = $"wss://chat@{localIP}:{port}/command";
                    var output = new ByteArray();

                    output.WriteUTF(category);
                    output.WriteUTF(code);
                    output.WriteUTF(url);
                    output.WriteUTF(protocol);
                    output.WriteTime(DateTime.Now);
                    header.Body = output.Bytes;
                    header.Write(data);

                    PiggChatProxy.Start(server, port);
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