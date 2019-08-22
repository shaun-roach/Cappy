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
    }
}
