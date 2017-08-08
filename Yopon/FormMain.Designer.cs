namespace Yopon
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kousinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.機能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テストアクションToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.カラーチャットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アラート表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.チャット送信ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.gOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 847);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.機能ToolStripMenuItem,
            this.ツールToolStripMenuItem,
            this.テストToolStripMenuItem,
            this.toolStripTextBox1,
            this.gOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kousinToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル (&F)";
            // 
            // kousinToolStripMenuItem
            // 
            this.kousinToolStripMenuItem.Name = "kousinToolStripMenuItem";
            this.kousinToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kousinToolStripMenuItem.Text = "更新 (&R)";
            this.kousinToolStripMenuItem.Click += new System.EventHandler(this.kousinToolStripMenuItem_Click);
            // 
            // 機能ToolStripMenuItem
            // 
            this.機能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テストアクションToolStripMenuItem,
            this.toolStripMenuItem2,
            this.カラーチャットToolStripMenuItem});
            this.機能ToolStripMenuItem.Name = "機能ToolStripMenuItem";
            this.機能ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.機能ToolStripMenuItem.Text = "効果 (&E)";
            // 
            // テストアクションToolStripMenuItem
            // 
            this.テストアクションToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.テストアクションToolStripMenuItem.Name = "テストアクションToolStripMenuItem";
            this.テストアクションToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.テストアクションToolStripMenuItem.Text = "テストアクション";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Tag = "limit";
            this.toolStripMenuItem3.Text = "1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.testActionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Tag = "limit";
            this.toolStripMenuItem4.Text = "2";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.testActionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Tag = "limit";
            this.toolStripMenuItem5.Text = "3";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.testActionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Tag = "limit";
            this.toolStripMenuItem6.Text = "4";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.testActionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Tag = "limit";
            this.toolStripMenuItem7.Text = "5";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.testActionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Tag = "limit";
            this.toolStripMenuItem2.Text = "クリック式瞬間移動";
            this.toolStripMenuItem2.CheckedChanged += new System.EventHandler(this.toolStripMenuItem2_CheckedChanged);
            // 
            // カラーチャットToolStripMenuItem
            // 
            this.カラーチャットToolStripMenuItem.CheckOnClick = true;
            this.カラーチャットToolStripMenuItem.Name = "カラーチャットToolStripMenuItem";
            this.カラーチャットToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.カラーチャットToolStripMenuItem.Tag = "limit";
            this.カラーチャットToolStripMenuItem.Text = "カラーチャット";
            this.カラーチャットToolStripMenuItem.CheckedChanged += new System.EventHandler(this.カラーチャットToolStripMenuItem_CheckedChanged);
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オプションOToolStripMenuItem});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ツールToolStripMenuItem.Text = "ツール (&T)";
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.オプションOToolStripMenuItem.Text = "オプション (&O)";
            this.オプションOToolStripMenuItem.Click += new System.EventHandler(this.オプションOToolStripMenuItem_Click);
            // 
            // テストToolStripMenuItem
            // 
            this.テストToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.アラート表示ToolStripMenuItem,
            this.チャット送信ToolStripMenuItem});
            this.テストToolStripMenuItem.Name = "テストToolStripMenuItem";
            this.テストToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.テストToolStripMenuItem.Tag = "debug";
            this.テストToolStripMenuItem.Text = "テスト (&T)";
            this.テストToolStripMenuItem.Visible = false;
            // 
            // アラート表示ToolStripMenuItem
            // 
            this.アラート表示ToolStripMenuItem.Name = "アラート表示ToolStripMenuItem";
            this.アラート表示ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.アラート表示ToolStripMenuItem.Text = "アラート表示";
            this.アラート表示ToolStripMenuItem.Click += new System.EventHandler(this.アラート表示ToolStripMenuItem_Click);
            // 
            // チャット送信ToolStripMenuItem
            // 
            this.チャット送信ToolStripMenuItem.Name = "チャット送信ToolStripMenuItem";
            this.チャット送信ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.チャット送信ToolStripMenuItem.Text = "チャット送信";
            this.チャット送信ToolStripMenuItem.Click += new System.EventHandler(this.チャット送信ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(116, 23);
            this.toolStripTextBox1.Tag = "debug";
            this.toolStripTextBox1.Visible = false;
            // 
            // gOToolStripMenuItem
            // 
            this.gOToolStripMenuItem.Name = "gOToolStripMenuItem";
            this.gOToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.gOToolStripMenuItem.Tag = "debug";
            this.gOToolStripMenuItem.Text = "GO";
            this.gOToolStripMenuItem.Visible = false;
            this.gOToolStripMenuItem.Click += new System.EventHandler(this.gOToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yopon 66!d";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kousinToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem gOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テストToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アラート表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem チャット送信ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 機能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem カラーチャットToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テストアクションToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}

