using System.ComponentModel;

namespace MainApp
{
    partial class EvmContentControl
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
            this._titleLabel = new MainApp.TitleLabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._infoText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titleLabel
            // 
            this._titleLabel.BackColor = System.Drawing.Color.Peru;
            this._titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleLabel.Location = new System.Drawing.Point(0, 0);
            this._titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(276, 32);
            this._titleLabel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._infoText, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 115);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _infoText
            // 
            this._infoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._infoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._infoText.Location = new System.Drawing.Point(0, 32);
            this._infoText.Margin = new System.Windows.Forms.Padding(0);
            this._infoText.Name = "_infoText";
            this._infoText.Size = new System.Drawing.Size(276, 83);
            this._infoText.TabIndex = 1;
            this._infoText.Text = "a";
            // 
            // EvmContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EvmContentControl";
            this.Size = new System.Drawing.Size(276, 115);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox _infoText;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private MainApp.TitleLabelControl _titleLabel;

        #endregion
    }
}