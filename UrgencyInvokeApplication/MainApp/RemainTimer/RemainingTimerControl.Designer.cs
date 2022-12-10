using System.ComponentModel;

namespace MainApp.RemainTimer
{
    partial class RemainingTimerControl
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
            if (disposing)
            {
                DisposeInternal();
            }
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
            this._timer = new System.Timers.Timer();
            this._countDownTimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._timer)).BeginInit();
            this.SuspendLayout();
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.SynchronizingObject = this;
            this._timer.Elapsed += new System.Timers.ElapsedEventHandler((sender, e) => this.OnTimerElapsed());
            // 
            // _countDownTimerLabel
            // 
            this._countDownTimerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this._countDownTimerLabel.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._countDownTimerLabel.Location = new System.Drawing.Point(0, 20);
            this._countDownTimerLabel.Name = "_countDownTimerLabel";
            this._countDownTimerLabel.Size = new System.Drawing.Size(221, 34);
            this._countDownTimerLabel.TabIndex = 0;
            this._countDownTimerLabel.Text = "00日00時間00分00秒";
            // 
            // RemainingTimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._countDownTimerLabel);
            this.DoubleBuffered = true;
            this.Name = "RemainingTimerControl";
            this.Size = new System.Drawing.Size(225, 74);
            ((System.ComponentModel.ISupportInitialize) (this._timer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _countDownTimerLabel;

        private System.Timers.Timer _timer;

        #endregion
    }
}