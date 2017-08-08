using System;
using System.Windows.Forms;

namespace Yopon
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            YoponSetting.Load();

            var options = YoponSetting.I;

            checkBox1.Checked = options.HasBlockIllegalAction;
            checkBox2.Checked = options.HasSaveChatLog;
            checkBox3.Checked = options.HasSaveSlashMessage;
            checkBox4.Checked = options.HasProcessFormat;
            checkBox5.Checked = options.HideSandboxError;
            textBox1.Text = options.LogFormat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = YoponSetting.I;

            options.HasBlockIllegalAction = checkBox1.Checked;
            options.HasSaveChatLog = checkBox2.Checked;
            options.HasSaveSlashMessage = checkBox3.Checked;
            options.HasProcessFormat = checkBox4.Checked;
            options.HideSandboxError = checkBox5.Checked;
            options.LogFormat = textBox1.Text;

            YoponSetting.Save();

            if (sender != null)
                Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox4.Checked;
        }

        private void FormSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            var options = YoponSetting.I;

            var isUpdate =
                options.HasBlockIllegalAction != checkBox1.Checked |
                options.HasSaveChatLog != checkBox2.Checked |
                options.HasSaveSlashMessage != checkBox3.Checked |
                options.HasProcessFormat != checkBox4.Checked |
                options.LogFormat != textBox1.Text |
                options.HideSandboxError != checkBox5.Checked;

            if (isUpdate)
            {
                var result = MessageBox.Show("設定が変更されています。\r\n保存しますか？",
                    "Yopon 66!d", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    button1_Click(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}