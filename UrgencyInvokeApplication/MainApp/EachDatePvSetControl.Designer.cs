using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MainApp
{
    public partial class EachDatePvSetControl
    {
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this._saturdayControl = new DateAndNumericControl();
            this._fridayControl = new DateAndNumericControl();
            this._thursdayControl = new DateAndNumericControl();
            this._wednesdayControl = new DateAndNumericControl();
            this._tuesdayControl = new DateAndNumericControl();
            this._sunDayControl = new DateAndNumericControl();
            this._mondayControl = new DateAndNumericControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._saturdayControl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this._fridayControl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._thursdayControl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._wednesdayControl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._tuesdayControl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._sunDayControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._mondayControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new Size(271, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _saturdayControl
            // 
            this._saturdayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saturdayControl.Location = new System.Drawing.Point(3, 171);
            this._saturdayControl.Name = "_saturdayControl";
            this._saturdayControl.Size = new System.Drawing.Size(265, 28);
            this._saturdayControl.TabIndex = 6;
            this._saturdayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // _fridayControl
            // 
            this._fridayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fridayControl.Location = new System.Drawing.Point(3, 143);
            this._fridayControl.Name = "_fridayControl";
            this._fridayControl.Size = new System.Drawing.Size(265, 22);
            this._fridayControl.TabIndex = 5;
            this._fridayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // _thursdayControl
            // 
            this._thursdayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thursdayControl.Location = new System.Drawing.Point(3, 115);
            this._thursdayControl.Name = "_thursdayControl";
            this._thursdayControl.Size = new System.Drawing.Size(265, 22);
            this._thursdayControl.TabIndex = 4;
            this._thursdayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // _wednesdayControl
            // 
            this._wednesdayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._wednesdayControl.Location = new System.Drawing.Point(3, 87);
            this._wednesdayControl.Name = "_wednesdayControl";
            this._wednesdayControl.Size = new System.Drawing.Size(265, 22);
            this._wednesdayControl.TabIndex = 3;
            this._wednesdayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // _tuesdayControl
            // 
            this._tuesdayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tuesdayControl.Location = new System.Drawing.Point(3, 59);
            this._tuesdayControl.Name = "_tuesdayControl";
            this._tuesdayControl.Size = new System.Drawing.Size(265, 22);
            this._tuesdayControl.TabIndex = 2;
            this._tuesdayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // _sunDayControl
            // 
            this._sunDayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sunDayControl.Location = new System.Drawing.Point(3, 3);
            this._sunDayControl.Name = "_sunDayControl";
            this._sunDayControl.Size = new System.Drawing.Size(265, 22);
            this._sunDayControl.TabIndex = 0;
            this._sunDayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // _mondayControl
            // 
            this._mondayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mondayControl.Location = new System.Drawing.Point(3, 31);
            this._mondayControl.Name = "_mondayControl";
            this._mondayControl.Size = new System.Drawing.Size(265, 22);
            this._mondayControl.TabIndex = 1;
            this._mondayControl.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // EachDatePvSetControl
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EachDatePvSetControl";
            this.Size = new System.Drawing.Size(271, 202);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }

    partial class EachDatePvSetControl
    {
        #region Component Designer generated code

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DateAndNumericControl _sunDayControl;
        private DateAndNumericControl _saturdayControl;
        private DateAndNumericControl _fridayControl;
        private DateAndNumericControl _thursdayControl;
        private DateAndNumericControl _wednesdayControl;
        private DateAndNumericControl _tuesdayControl;
        private DateAndNumericControl _mondayControl;
    }
}