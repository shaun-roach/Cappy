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
    public partial class OnOffForm : Form
    {
        public OnOffForm()
        {
            InitializeComponent();           
        }

        private void TimerShowAlpha_Tick(object sender, EventArgs e)
        {            
            this.timerShowAlpha.Enabled = false;
            this.labelCaps.Visible = false;
            this.Hide();            
        }

        private void OnOffForm_Shown(object sender, EventArgs e)
        {
            this.timerShowAlpha.Stop();
            this.timerShowAlpha.Start();
            this.timerShowAlpha.Enabled = true;            
        }


        // Stop stealing focus, answer found here thanks:
        // https://stackoverflow.com/questions/156046/show-a-form-without-stealing-focus/156159#156159

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        private const int WS_EX_TOPMOST = 0x00000008;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST;
                return createParams;
            }
        }

        private void OnOffForm_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(SystemColors.AppWorkspace);
            e.Graphics.FillEllipse(myBrush, new Rectangle(0, 0, 215, 215));
            myBrush.Dispose();            
        }
    }
}
