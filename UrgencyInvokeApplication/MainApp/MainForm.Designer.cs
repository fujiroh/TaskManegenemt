using RemainingTimerChartControl = MainApp.RemainTimer.RemainingTimerChartControl;

namespace MainApp
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
            this._addButton = new System.Windows.Forms.Button();
            this._remainingPieChart = new MainApp.RemainTimer.RemainingTimerChartControl();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(14, 16);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(91, 20);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "追加";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // _remainingPieChart
            // 
            this._remainingPieChart.BackColor = System.Drawing.Color.White;
            this._remainingPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._remainingPieChart.Location = new System.Drawing.Point(0, 0);
            this._remainingPieChart.Name = "_remainingPieChart";
            this._remainingPieChart.Size = new System.Drawing.Size(297, 305);
            this._remainingPieChart.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 305);
            this.Controls.Add(this._remainingPieChart);
            this.Controls.Add(this._addButton);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private MainApp.RemainTimer.RemainingTimerChartControl _remainingPieChart;

        private System.Windows.Forms.Button _addButton;

        #endregion
    }
}