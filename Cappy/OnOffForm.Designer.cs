﻿namespace Cappy
{
    partial class OnOffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCaps = new System.Windows.Forms.Label();
            this.timerShowAlpha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCaps
            // 
            this.labelCaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCaps.AutoSize = true;
            this.labelCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCaps.Location = new System.Drawing.Point(26, 9);
            this.labelCaps.Name = "labelCaps";
            this.labelCaps.Size = new System.Drawing.Size(138, 135);
            this.labelCaps.TabIndex = 0;
            this.labelCaps.Text = "A";
            // 
            // timerShowAlpha
            // 
            this.timerShowAlpha.Interval = 1000;
            this.timerShowAlpha.Tick += new System.EventHandler(this.TimerShowAlpha_Tick);
            // 
            // OnOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 156);
            this.Controls.Add(this.labelCaps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnOffForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VisibleChanged += new System.EventHandler(this.OnOffForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerShowAlpha;
        public System.Windows.Forms.Label labelCaps;
    }
}