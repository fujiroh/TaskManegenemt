using System.ComponentModel;

namespace MainApp
{
    partial class DateAndNumericControl
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
            this._dateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._pvNumeric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._pvNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // _dateLabel
            // 
            this._dateLabel.AutoEllipsis = true;
            this._dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dateLabel.Location = new System.Drawing.Point(3, 0);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(79, 32);
            this._dateLabel.TabIndex = 1;
            this._dateLabel.Text = "label1";
            this._dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._dateLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._pvNumeric, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 32);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _pvNumeric
            // 
            this._pvNumeric.DecimalPlaces = 2;
            this._pvNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvNumeric.Increment = new decimal(new int[] {25, 0, 0, 131072});
            this._pvNumeric.Location = new System.Drawing.Point(88, 3);
            this._pvNumeric.Name = "_pvNumeric";
            this._pvNumeric.Size = new System.Drawing.Size(162, 19);
            this._pvNumeric.TabIndex = 2;
            this._pvNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._pvNumeric.ValueChanged += new System.EventHandler(this._pvNumeric_ValueChanged);
            // 
            // DateAndNumericControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DateAndNumericControl";
            this.Size = new System.Drawing.Size(253, 32);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this._pvNumeric)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown _pvNumeric;

        #endregion

        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}