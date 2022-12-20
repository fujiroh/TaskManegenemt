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
            this._pvNumeric = new System.Windows.Forms.NumericUpDown();
            this._pvAllSetAtOnceCheckBox = new System.Windows.Forms.CheckBox();
            this._pvSetEachDayCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._pvLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._setAtOnceTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this._pvNumeric)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this._setAtOnceTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pvNumeric
            // 
            this._pvNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvNumeric.Location = new System.Drawing.Point(38, 3);
            this._pvNumeric.Name = "_pvNumeric";
            this._pvNumeric.Size = new System.Drawing.Size(130, 19);
            this._pvNumeric.TabIndex = 0;
            // 
            // _pvAllSetAtOnceCheckBox
            // 
            this._pvAllSetAtOnceCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvAllSetAtOnceCheckBox.Location = new System.Drawing.Point(3, 3);
            this._pvAllSetAtOnceCheckBox.Name = "_pvAllSetAtOnceCheckBox";
            this._pvAllSetAtOnceCheckBox.Size = new System.Drawing.Size(97, 29);
            this._pvAllSetAtOnceCheckBox.TabIndex = 1;
            this._pvAllSetAtOnceCheckBox.Text = "一括設定";
            this._pvAllSetAtOnceCheckBox.UseVisualStyleBackColor = true;
            // 
            // _pvSetEachDayCheckBox
            // 
            this._pvSetEachDayCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvSetEachDayCheckBox.Location = new System.Drawing.Point(106, 3);
            this._pvSetEachDayCheckBox.Name = "_pvSetEachDayCheckBox";
            this._pvSetEachDayCheckBox.Size = new System.Drawing.Size(105, 29);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // _pvLabel
            // 
            this._pvLabel.AutoSize = true;
            this._pvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pvLabel.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._pvLabel.ForeColor = System.Drawing.Color.Blue;
            this._pvLabel.Location = new System.Drawing.Point(3, 0);
            this._pvLabel.Name = "_pvLabel";
            this._pvLabel.Size = new System.Drawing.Size(29, 30);
            this._pvLabel.TabIndex = 5;
            this._pvLabel.Text = "PV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this.label1.Location = new System.Drawing.Point(174, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "/ 日";
            // 
            // _setAtOnceTableLayout
            // 
            this._setAtOnceTableLayout.ColumnCount = 3;
            this._setAtOnceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._setAtOnceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._setAtOnceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this._setAtOnceTableLayout.Controls.Add(this.label1, 2, 0);
            this._setAtOnceTableLayout.Controls.Add(this._pvLabel, 0, 0);
            this._setAtOnceTableLayout.Controls.Add(this._pvNumeric, 1, 0);
            this._setAtOnceTableLayout.Location = new System.Drawing.Point(3, 44);
            this._setAtOnceTableLayout.Name = "_setAtOnceTableLayout";
            this._setAtOnceTableLayout.RowCount = 1;
            this._setAtOnceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._setAtOnceTableLayout.Size = new System.Drawing.Size(214, 30);
            this._setAtOnceTableLayout.TabIndex = 7;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // PvSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._setAtOnceTableLayout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PvSettingControl";
            this.Size = new System.Drawing.Size(230, 270);
            ((System.ComponentModel.ISupportInitialize) (this._pvNumeric)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this._setAtOnceTableLayout.ResumeLayout(false);
            this._setAtOnceTableLayout.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;

        private System.Windows.Forms.TableLayoutPanel _setAtOnceTableLayout;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label _pvLabel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.CheckBox _pvAllSetAtOnceCheckBox;

        private System.Windows.Forms.NumericUpDown _pvNumeric;
        private System.Windows.Forms.CheckBox _pvSetEachDayCheckBox;

        #endregion
    }
}