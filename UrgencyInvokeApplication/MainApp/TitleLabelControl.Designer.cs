using System.ComponentModel;

namespace MainApp
{
    partial class TitleLabelControl
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
            this._expandBtnPicture = new System.Windows.Forms.PictureBox();
            this._textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._expandBtnPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // _expandBtnPicture
            // 
            this._expandBtnPicture.BackColor = System.Drawing.Color.Transparent;
            this._expandBtnPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this._expandBtnPicture.Location = new System.Drawing.Point(210, 0);
            this._expandBtnPicture.Margin = new System.Windows.Forms.Padding(0);
            this._expandBtnPicture.Name = "_expandBtnPicture";
            this._expandBtnPicture.Size = new System.Drawing.Size(32, 32);
            this._expandBtnPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._expandBtnPicture.TabIndex = 0;
            this._expandBtnPicture.TabStop = false;
            this._expandBtnPicture.Click += new System.EventHandler(this._expandBtnPicture_Click);
            this._expandBtnPicture.Paint += new System.Windows.Forms.PaintEventHandler(this._expandBtnPicture_Paint);
            // 
            // _textLabel
            // 
            this._textLabel.AutoEllipsis = true;
            this._textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textLabel.Location = new System.Drawing.Point(0, 0);
            this._textLabel.Margin = new System.Windows.Forms.Padding(0);
            this._textLabel.Name = "_textLabel";
            this._textLabel.Size = new System.Drawing.Size(210, 32);
            this._textLabel.TabIndex = 1;
            this._textLabel.Text = "タイトル";
            this._textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._textLabel.Click += new System.EventHandler(this._textLabel_Click);
            // 
            // TitleLabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._textLabel);
            this.Controls.Add(this._expandBtnPicture);
            this.Name = "TitleLabelControl";
            this.Size = new System.Drawing.Size(242, 32);
            ((System.ComponentModel.ISupportInitialize) (this._expandBtnPicture)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _textLabel;

        private System.Windows.Forms.PictureBox _expandBtnPicture;

        #endregion
    }
}