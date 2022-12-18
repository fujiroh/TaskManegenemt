using System.ComponentModel;

namespace MainApp.PieChart
{
    partial class PieChartControl
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
            this.SuspendLayout();
            // 
            // PieChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "PieChartControl";
            this.Size = new System.Drawing.Size(222, 239);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PieChartControl_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PieChartControl_MouseMove);
            this.Resize += new System.EventHandler(this.PieChartControl_Resize);
            this.ResumeLayout(false);
        }

        #endregion
    }
}