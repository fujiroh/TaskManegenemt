using System.ComponentModel;
using PieChartControl = Main.PieChart.PieChartControl;
using PieChartList = Main.PieChart.PieChartList;

namespace Main.RemainTimer
{
    partial class RemainingTimerChartControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PieChartList pieChartList1 = new PieChartList();
            this._pieChartControl = new PieChartControl();
            this._timer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this._timer)).BeginInit();
            this.SuspendLayout();
            // 
            // _pieChartControl
            // 
            this._pieChartControl.Contents = pieChartList1;
            this._pieChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pieChartControl.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._pieChartControl.Location = new System.Drawing.Point(0, 0);
            this._pieChartControl.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this._pieChartControl.Name = "_pieChartControl";
            this._pieChartControl.Size = new System.Drawing.Size(275, 267);
            this._pieChartControl.TabIndex = 0;
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.SynchronizingObject = this;
            this._timer.Elapsed += new System.Timers.ElapsedEventHandler(this._timer_Elapsed);
            // 
            // RemainingTimerChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._pieChartControl);
            this.Name = "RemainingTimerChartControl";
            this.Size = new System.Drawing.Size(275, 267);
            ((System.ComponentModel.ISupportInitialize) (this._timer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer _timer;

        private PieChartControl _pieChartControl;

        #endregion
    }
}