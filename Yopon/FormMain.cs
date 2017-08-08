using Yopon.CEFHandler;
using Yopon.Flash;
using Yopon.Pigg;
using Yopon.Pigg.Command;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Yopon
{
    public partial class FormMain : Form
    {
        private ChromiumWebBrowser CEFEngine;

        private BrowserSettings BrowserSettings => new BrowserSettings
        {
            DefaultEncoding = "UTF-8",
            JavascriptAccessClipboard = CefState.Enabled,
            JavascriptOpenWindows = CefState.Disabled,
            JavascriptCloseWindows = CefState.Disabled,
            JavascriptDomPaste = CefState.Disabled,
            OffScreenTransparentBackground = true,
            SansSerifFontFamily = "Meiryo"
        };

        public FormMain()
        {
            if (!IsAgreed())
                Environment.Exit(0);

            InitializeComponent();

            var settings = new CefSettings();
            var current = AppDomain.CurrentDomain.BaseDirectory;
            var flash = $@"{current}plugins\pepper flash\23.0.0.207\pepflashplayer.dll";

            if (File.Exists(flash))
                settings.CefCommandLineArgs.Add("ppapi-flash-path", flash);

            if (YoponSetting.I.HideSandboxError)
            {
                settings.BrowserSubprocessPath =
                    typeof(Sandbox.HideAlert.Program).Assembly.Location;
            }

            settings.CachePath = $@"{current}data";

            Cef.Initialize(settings);

            CEFEngine = new ChromiumWebBrowser("http://pigg.ameba.jp/");

            var lifeSpanHandler = new LifeSpanHandler();

            lifeSpanHandler.PopupRequest +=
                x => Process.Start(x);

            CEFEngine.LifeSpanHandler = lifeSpanHandler;
            CEFEngine.ResourceHandlerFactory = new PiggResourceHandlerFactory();
            CEFEngine.BrowserSettings = BrowserSettings;
            CEFEngine.Dock = DockStyle.Fill;
            panel1.Controls.Add(CEFEngine);

            if (YoponSetting.I.IsDebugMode)
                DisplayMenuDebug();
        }

        private bool IsAgreed()
        {
            if (YoponSetting.I.IsAgreed == false)
            {
                using (var form = new FormContract())
                {
                    form.ShowDialog();
                    YoponSetting.I.IsAgreed = form.IsAgreed;
                }
            }

            return YoponSetting.I.IsAgreed;
        }

        private void DisplayMenuDebug()
        {
            void Activation(ToolStripItem item)
            {
                if (item is ToolStripMenuItem menuItem)
                    foreach (ToolStripItem dropDownItem in menuItem.DropDownItems)
                        if (dropDownItem is ToolStripMenuItem)
                            Activation((ToolStripMenuItem)dropDownItem);

                if (item.Tag is string tag &&
                    tag.Equals("debug"))
                    item.Visible = true;
            }

            var items = menuStrip1.Items;

            foreach (ToolStripItem item in items)
            {
                Activation(item);
            }
        }
        
        private void kousinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEFEngine.Reload();
        }

        private void gOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEFEngine.Load(toolStripTextBox1.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            YoponSetting.Save();
        }

        private void オプションOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormSetting())
            {
                form.ShowDialog();
            }
        }

        private void アラート表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proxy = ActiveUser.ChatProxy?.WebSocketProxy;

            if (proxy?.IsActive == true)
            {
                var header = new Header();
                var data = new ByteArray();
                data.WriteUTF("てすと");
                header.CommandId = ChatMethod.ALERT_RESULT;
                header.Body = data.Bytes;
                proxy.Recv(header.ToArray());
            }
        }

        private void チャット送信ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chat = ActiveUser.ChatProxy;
            var proxy = chat?.WebSocketProxy;

            if (proxy?.IsActive == true)
            {
                var header = new Header();
                var data = new ByteArray();
                data.WriteUTF("てすと");
                data.WriteUnsignedInt(0x00FFFFFF);
                data.WriteUnsignedInt(0x00FFFFFF);
                data.Encrypt(chat.Key);
                header.CommandId = ChatMethod.TALK;
                header.Body = data.Bytes;
                proxy.Send(header.ToArray());
            }
        }

        private void toolStripMenuItem2_CheckedChanged(object sender, EventArgs e)
        {
            ActiveUser.IsOneClickTeleport = toolStripMenuItem2.Checked;
        }

        private void カラーチャットToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (カラーチャットToolStripMenuItem.Checked)
            {
                using (var dialog = new ColorDialog())
                {
                    dialog.ShowDialog();
                    ActiveUser.TalkBGColor = dialog.Color;
                }
            }
            else ActiveUser.TalkBGColor = Color.White;
        }

        private void testActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                var actionCode = AllowActionList.
                    GetYoponAction($"template{item.Text}");
                var chat = ActiveUser.ChatProxy;
                var proxy = chat?.WebSocketProxy;

                if (proxy?.IsActive == true)
                {
                    var header = new Header();
                    var data = new ByteArray();
                    data.WriteUTF(actionCode);
                    data.Encrypt(chat.Key);
                    header.CommandId = 
                        ChatMethod.ACTION;
                    header.Body = data.Bytes;
                    proxy.Send(header.ToArray());
                }
            }
        }
    }
}