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
        private bool capsLockOn = Control.IsKeyLocked(Keys.CapsLock);
        private OnOffForm onOffForm = new OnOffForm();

        public MainForm()
        {
            InitializeComponent();

            this.CheckCapsLock();

            var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).ProductVersion;            
            this.Text = "Cappy v" + version;
        }

        private void CheckCapsLock()
        {
            this.cappyTimer.Enabled = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (!capsLockOn)
                {
                    this.onOffForm.labelCaps.Text = "A";
                    this.notifyCappy.Icon = Cappy.Properties.Resources.capson;
                    this.notifyCappy.Text = "Caps Lock ON";
                    this.label1.Text = "Caps Lock is currently ON";
                    this.capsLockToolStripMenuItem.Checked = true;
                    this.pictureBox1.Image = Bitmap.FromHicon(Cappy.Properties.Resources.capson.Handle);
                    this.onOffForm.Left = Cursor.Position.X;
                    this.onOffForm.Top = Cursor.Position.Y;                                        
                    this.onOffForm.labelCaps.Visible = true;
                    this.onOffForm.Visible = true;
                    this.capsLockOn = true;
                }
            }
            else
            {
                if (capsLockOn)
                {                    
                    this.onOffForm.labelCaps.Text = "a";
                    this.notifyCappy.Icon = Cappy.Properties.Resources.capsoff;
                    this.notifyCappy.Text = "Caps Lock OFF";
                    this.label1.Text = "Caps Lock is currently OFF";
                    this.capsLockToolStripMenuItem.Checked = false;
                    this.pictureBox1.Image = Bitmap.FromHicon(Cappy.Properties.Resources.capsoff.Handle);
                    this.onOffForm.Left = Cursor.Position.X;
                    this.onOffForm.Top = Cursor.Position.Y;
                    this.onOffForm.labelCaps.Visible = true;
                    this.onOffForm.Visible = true;                    
                    this.capsLockOn = false;
                }
            }
            this.cappyTimer.Enabled = true;
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
        }

        private void NotifyCappy_DoubleClick(object sender, EventArgs e)
        {
            this.ToggleShow();
        }

        private void ToggleShow()
        {
            this.allowshowdisplay = true;
            this.Visible = !this.Visible;
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Normal;
                this.showToolStripMenuItem.Text = "Hide";
            }
            else
            {
                this.showToolStripMenuItem.Text = "Show";
            }
        }

        private void CappyTimer_Tick(object sender, EventArgs e)
        {
            this.CheckCapsLock();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ToggleShow();              
            }
        }

        private void CappyMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ToggleShow();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.ToggleShow();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
