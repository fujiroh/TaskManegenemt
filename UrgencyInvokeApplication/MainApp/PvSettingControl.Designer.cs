using System.ComponentModel;

namespace MainApp
{
    partial class PvSettingControl
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
            this._pvAllSetAtOnceCheckBox = new System.Windows.Forms.CheckBox();
            this._pvSetEachDayCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this._eachDatePvSetControl = new MainApp.EachDatePvSetControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pvAllSetAtOnceCheckBox
            // 
            this._pvAllSetAtOnceCheckBox.Checked = true;
            this._pvAllSetAtOnceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._pvAllSetAtOnceCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvAllSetAtOnceCheckBox.Location = new System.Drawing.Point(3, 3);
            this._pvAllSetAtOnceCheckBox.Name = "_pvAllSetAtOnceCheckBox";
            this._pvAllSetAtOnceCheckBox.Size = new System.Drawing.Size(124, 29);
            this._pvAllSetAtOnceCheckBox.TabIndex = 1;
            this._pvAllSetAtOnceCheckBox.Text = "一括設定";
            this._pvAllSetAtOnceCheckBox.UseVisualStyleBackColor = true;
            // 
            // _pvSetEachDayCheckBox
            // 
            this._pvSetEachDayCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvSetEachDayCheckBox.Location = new System.Drawing.Point(133, 3);
            this._pvSetEachDayCheckBox.Name = "_pvSetEachDayCheckBox";
            this._pvSetEachDayCheckBox.Size = new System.Drawing.Size(132, 29);
            this._pvSetEachDayCheckBox.TabIndex = 2;
            this._pvSetEachDayCheckBox.Text = "曜日別に設定";
            this._pvSetEachDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.59813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.40187F));
            this.tableLayoutPanel1.Controls.Add(this._pvSetEachDayCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._pvAllSetAtOnceCheckBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // _eachDatePvSetControl
            // 
            this._eachDatePvSetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._eachDatePvSetControl.Location = new System.Drawing.Point(3, 3);
            this._eachDatePvSetControl.Name = "_eachDatePvSetControl";
            this._eachDatePvSetControl.Size = new System.Drawing.Size(262, 284);
            this._eachDatePvSetControl.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._eachDatePvSetControl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 290);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // PvSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PvSettingControl";
            this.Size = new System.Drawing.Size(268, 325);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MainApp.EachDatePvSetControl _eachDatePvSetControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.CheckBox _pvAllSetAtOnceCheckBox;

        private System.Windows.Forms.CheckBox _pvSetEachDayCheckBox;

        #endregion
    }
}