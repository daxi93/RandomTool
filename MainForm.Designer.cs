namespace RandomTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_nb = new System.Windows.Forms.TextBox();
            this.btn_crt = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "随机字符串工具";
            this.myNotifyIcon.Visible = true;
            this.myNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmt1,
            this.cmt2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 64);
            // 
            // cmt1
            // 
            this.cmt1.Name = "cmt1";
            this.cmt1.Size = new System.Drawing.Size(170, 30);
            this.cmt1.Text = "生成随机数";
            this.cmt1.Click += new System.EventHandler(this.btn_crt_Click);
            // 
            // cmt2
            // 
            this.cmt2.Name = "cmt2";
            this.cmt2.Size = new System.Drawing.Size(170, 30);
            this.cmt2.Text = "退出";
            this.cmt2.Click += new System.EventHandler(this.cmt2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_nb);
            this.splitContainer1.Panel1MinSize = 42;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_crt);
            this.splitContainer1.Panel2MinSize = 33;
            this.splitContainer1.Size = new System.Drawing.Size(512, 94);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_nb
            // 
            this.txt_nb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nb.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_nb.Location = new System.Drawing.Point(0, 0);
            this.txt_nb.Margin = new System.Windows.Forms.Padding(10);
            this.txt_nb.Name = "txt_nb";
            this.txt_nb.ReadOnly = true;
            this.txt_nb.Size = new System.Drawing.Size(512, 39);
            this.txt_nb.TabIndex = 0;
            this.txt_nb.Text = "请点击按钮生成随机数";
            this.txt_nb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_crt
            // 
            this.btn_crt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_crt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_crt.Location = new System.Drawing.Point(0, 0);
            this.btn_crt.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.btn_crt.Name = "btn_crt";
            this.btn_crt.Size = new System.Drawing.Size(512, 45);
            this.btn_crt.TabIndex = 0;
            this.btn_crt.Text = "生成随机数";
            this.btn_crt.UseVisualStyleBackColor = true;
            this.btn_crt.Click += new System.EventHandler(this.btn_crt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 94);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 150);
            this.MinimumSize = new System.Drawing.Size(534, 150);
            this.Name = "MainForm";
            this.Text = "随机字符串工具";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_nb;
        private System.Windows.Forms.Button btn_crt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmt1;
        private System.Windows.Forms.ToolStripMenuItem cmt2;
    }
}

