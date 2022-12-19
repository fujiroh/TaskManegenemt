using System.ComponentModel;

namespace MainApp.Evm
{
    partial class OrthogonalGraphControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._lineChartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._contextMenu = new System.Windows.Forms.ContextMenu();
            ((System.ComponentModel.ISupportInitialize) (this._lineChartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // _lineChartControl
            // 
            chartArea1.Name = "ChartArea1";
            this._lineChartControl.ChartAreas.Add(chartArea1);
            this._lineChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this._lineChartControl.Legends.Add(legend1);
            this._lineChartControl.Location = new System.Drawing.Point(0, 0);
            this._lineChartControl.Name = "_lineChartControl";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this._lineChartControl.Series.Add(series1);
            this._lineChartControl.Size = new System.Drawing.Size(974, 552);
            this._lineChartControl.TabIndex = 0;
            this._lineChartControl.Text = "chart1";
            // 
            // OrthogonalGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lineChartControl);
            this.Name = "OrthogonalGraphControl";
            this.Size = new System.Drawing.Size(974, 552);
            ((System.ComponentModel.ISupportInitialize) (this._lineChartControl)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContextMenu _contextMenu;

        private System.Windows.Forms.DataVisualization.Charting.Chart _chartTest;

        private System.Windows.Forms.DataVisualization.Charting.Chart _lineChartControl;

        #endregion
    }
}