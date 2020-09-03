using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_crt_Click(object sender, EventArgs e)
        {
            rd();
        }

        private void rd()
        {
            string nb = RandomStringUtil.next();
            txt_nb.Text = nb;
            Clipboard.SetText(nb);
        }

        private void myNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void cmt2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Alt, Keys.Q);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    
                            rd();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);
        }
    }
}
