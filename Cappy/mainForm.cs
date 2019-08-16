using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cappy
{
    public partial class MainForm : Form
    {
        private bool allowshowdisplay = false;

        public MainForm()
        {
            InitializeComponent();

            this.CheckCapsLock();
        }

        private void CheckCapsLock()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.notifyCappy.Icon = Cappy.Properties.Resources.insert_text;
                this.label1.Text = "Caps Lock is currently ON";
            }
            else
            {
                this.notifyCappy.Icon = Cappy.Properties.Resources.stop;
                this.label1.Text = "Caps Lock is currently OFF";
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
        }

        private void NotifyCappy_DoubleClick(object sender, EventArgs e)
        {         
            this.allowshowdisplay = true;
            this.Visible = !this.Visible;         
        }

        private void CappyTimer_Tick(object sender, EventArgs e)
        {
            this.CheckCapsLock();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
