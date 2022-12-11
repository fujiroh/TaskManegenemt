using System.ComponentModel;
using Main.RemainTimer;

namespace Main
{
    partial class RemainingPieChartDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this._remainingTimerChartControl = new RemainingTimerChartControl();
            this.SuspendLayout();
            // 
            // _remainingTimerChartControl
            // 
            this._remainingTimerChartControl.BackColor = System.Drawing.Color.White;
            this._remainingTimerChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._remainingTimerChartControl.Location = new System.Drawing.Point(0, 0);
            this._remainingTimerChartControl.Name = "_remainingTimerChartControl";
            this._remainingTimerChartControl.Size = new System.Drawing.Size(334, 327);
            this._remainingTimerChartControl.TabIndex = 0;
            // 
            // RemainingPieChartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 327);
            this.Controls.Add(this._remainingTimerChartControl);
            this.Name = "RemainingPieChartDialog";
            this.Text = "RemainingPieChartDialog";
            this.ResumeLayout(false);
        }

        private RemainingTimerChartControl _remainingTimerChartControl;

        #endregion
    }
}