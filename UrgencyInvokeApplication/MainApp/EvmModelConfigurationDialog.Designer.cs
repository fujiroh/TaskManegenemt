using System.ComponentModel;

namespace MainApp
{
    partial class EvmModelConfigurationDialog
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
            this._btnCreate = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._monthCalendar = new System.Windows.Forms.MonthCalendar();
            this._startDayGroupBox = new System.Windows.Forms.GroupBox();
            this._startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._limitDateGroupBox = new System.Windows.Forms.GroupBox();
            this._limitDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._titleText = new System.Windows.Forms.RichTextBox();
            this._pvSettingGroupBox = new System.Windows.Forms.GroupBox();
            this._pvSettingControl = new MainApp.PvSettingControl();
            this._startDayGroupBox.SuspendLayout();
            this._limitDateGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._pvSettingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnCreate
            // 
            this._btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCreate.Location = new System.Drawing.Point(262, 383);
            this._btnCreate.Name = "_btnCreate";
            this._btnCreate.Size = new System.Drawing.Size(96, 28);
            this._btnCreate.TabIndex = 0;
            this._btnCreate.Text = "作成";
            this._btnCreate.UseVisualStyleBackColor = true;
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelBtn.Location = new System.Drawing.Point(364, 383);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(96, 28);
            this._cancelBtn.TabIndex = 1;
            this._cancelBtn.Text = "キャンセル";
            this._cancelBtn.UseVisualStyleBackColor = true;
            // 
            // _monthCalendar
            // 
            this._monthCalendar.Location = new System.Drawing.Point(250, 91);
            this._monthCalendar.Name = "_monthCalendar";
            this._monthCalendar.TabIndex = 3;
            // 
            // _startDayGroupBox
            // 
            this._startDayGroupBox.Controls.Add(this._startDateTimePicker);
            this._startDayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startDayGroupBox.Location = new System.Drawing.Point(3, 3);
            this._startDayGroupBox.Name = "_startDayGroupBox";
            this._startDayGroupBox.Size = new System.Drawing.Size(204, 39);
            this._startDayGroupBox.TabIndex = 4;
            this._startDayGroupBox.TabStop = false;
            this._startDayGroupBox.Text = "開始日";
            // 
            // _startDateTimePicker
            // 
            this._startDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startDateTimePicker.Location = new System.Drawing.Point(3, 15);
            this._startDateTimePicker.Name = "_startDateTimePicker";
            this._startDateTimePicker.Size = new System.Drawing.Size(198, 19);
            this._startDateTimePicker.TabIndex = 0;
            // 
            // _limitDateGroupBox
            // 
            this._limitDateGroupBox.Controls.Add(this._limitDateTimePicker1);
            this._limitDateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._limitDateGroupBox.Location = new System.Drawing.Point(233, 3);
            this._limitDateGroupBox.Name = "_limitDateGroupBox";
            this._limitDateGroupBox.Size = new System.Drawing.Size(205, 39);
            this._limitDateGroupBox.TabIndex = 5;
            this._limitDateGroupBox.TabStop = false;
            this._limitDateGroupBox.Text = "終了日";
            // 
            // _limitDateTimePicker1
            // 
            this._limitDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._limitDateTimePicker1.Location = new System.Drawing.Point(3, 15);
            this._limitDateTimePicker1.Name = "_limitDateTimePicker1";
            this._limitDateTimePicker1.Size = new System.Drawing.Size(199, 19);
            this._limitDateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(213, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "～";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._startDayGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._limitDateGroupBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 45);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // _titleText
            // 
            this._titleText.Location = new System.Drawing.Point(12, 6);
            this._titleText.Name = "_titleText";
            this._titleText.Size = new System.Drawing.Size(448, 22);
            this._titleText.TabIndex = 8;
            this._titleText.Text = "";
            // 
            // _pvSettingGroupBox
            // 
            this._pvSettingGroupBox.Controls.Add(this._pvSettingControl);
            this._pvSettingGroupBox.Location = new System.Drawing.Point(12, 85);
            this._pvSettingGroupBox.Name = "_pvSettingGroupBox";
            this._pvSettingGroupBox.Size = new System.Drawing.Size(229, 326);
            this._pvSettingGroupBox.TabIndex = 10;
            this._pvSettingGroupBox.TabStop = false;
            this._pvSettingGroupBox.Text = "PV設定";
            // 
            // _pvSettingControl
            // 
            this._pvSettingControl.BackColor = System.Drawing.Color.White;
            this._pvSettingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvSettingControl.Location = new System.Drawing.Point(3, 15);
            this._pvSettingControl.Name = "_pvSettingControl";
            this._pvSettingControl.Size = new System.Drawing.Size(223, 308);
            this._pvSettingControl.TabIndex = 0;
            // 
            // EvmModelConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 417);
            this.Controls.Add(this._pvSettingGroupBox);
            this.Controls.Add(this._titleText);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._monthCalendar);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._btnCreate);
            this.Name = "EvmModelConfigurationDialog";
            this.Text = "EvmModelConfigurationForm";
            this._startDayGroupBox.ResumeLayout(false);
            this._limitDateGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this._pvSettingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private MainApp.PvSettingControl _pvSettingControl;

        private System.Windows.Forms.DateTimePicker _limitDateTimePicker1;

        private System.Windows.Forms.DateTimePicker _startDateTimePicker;

        private System.Windows.Forms.GroupBox _pvSettingGroupBox;

        private System.Windows.Forms.RichTextBox _titleText;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox _limitDateGroupBox;

        private System.Windows.Forms.MonthCalendar _monthCalendar;
        private System.Windows.Forms.GroupBox _startDayGroupBox;

        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.CheckBox checkBox1;

        #endregion
    }
}