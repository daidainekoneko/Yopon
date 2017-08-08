using System;
using System.Windows.Forms;

namespace Yopon
{
    public partial class FormContract : Form
    {
        public bool IsAgreed { get; set; }

        public FormContract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsAgreed = true;
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }
    }
}
