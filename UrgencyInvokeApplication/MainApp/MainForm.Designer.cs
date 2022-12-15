namespace Main
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.remainingTimerChartControl1 = new Main.RemainTimer.RemainingTimerChartControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // remainingTimerChartControl1
            // 
            this.remainingTimerChartControl1.BackColor = System.Drawing.Color.White;
            this.remainingTimerChartControl1.Location = new System.Drawing.Point(49, 77);
            this.remainingTimerChartControl1.Name = "remainingTimerChartControl1";
            this.remainingTimerChartControl1.Size = new System.Drawing.Size(203, 216);
            this.remainingTimerChartControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 305);
            this.Controls.Add(this.remainingTimerChartControl1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private Main.RemainTimer.RemainingTimerChartControl remainingTimerChartControl1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}