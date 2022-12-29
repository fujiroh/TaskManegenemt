using System.ComponentModel;

namespace MainApp
{
    partial class AcTimerDialog
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
            this._startBtn = new System.Windows.Forms.Button();
            this._finishBtn = new System.Windows.Forms.Button();
            this._stopBtn = new System.Windows.Forms.Button();
            this._timeView = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this._timeView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // _startBtn
            // 
            this._startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._startBtn.ForeColor = System.Drawing.Color.Green;
            this._startBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._startBtn.Location = new System.Drawing.Point(3, 4);
            this._startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._startBtn.Name = "_startBtn";
            this._startBtn.Size = new System.Drawing.Size(129, 37);
            this._startBtn.TabIndex = 0;
            this._startBtn.Text = "▶";
            this._startBtn.UseVisualStyleBackColor = true;
            this._startBtn.Click += new System.EventHandler(this._startBtn_Click);
            // 
            // _finishBtn
            // 
            this._finishBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._finishBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._finishBtn.ForeColor = System.Drawing.Color.Red;
            this._finishBtn.Location = new System.Drawing.Point(273, 4);
            this._finishBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._finishBtn.Name = "_finishBtn";
            this._finishBtn.Size = new System.Drawing.Size(62, 37);
            this._finishBtn.TabIndex = 1;
            this._finishBtn.Text = "■";
            this._finishBtn.UseVisualStyleBackColor = true;
            this._finishBtn.Click += new System.EventHandler(this._finishBtn_Click);
            // 
            // _stopBtn
            // 
            this._stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stopBtn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this._stopBtn.ForeColor = System.Drawing.Color.Black;
            this._stopBtn.Location = new System.Drawing.Point(138, 4);
            this._stopBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._stopBtn.Name = "_stopBtn";
            this._stopBtn.Size = new System.Drawing.Size(129, 37);
            this._stopBtn.TabIndex = 2;
            this._stopBtn.Text = "||";
            this._stopBtn.UseVisualStyleBackColor = true;
            this._stopBtn.Click += new System.EventHandler(this._stopBtn_Click);
            // 
            // _timeView
            // 
            this._timeView.BackColor = System.Drawing.Color.White;
            this._timeView.Dock = System.Windows.Forms.DockStyle.Top;
            this._timeView.Location = new System.Drawing.Point(0, 0);
            this._timeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._timeView.Name = "_timeView";
            this._timeView.Size = new System.Drawing.Size(338, 66);
            this._timeView.TabIndex = 3;
            this._timeView.TabStop = false;
            this._timeView.Paint += new System.Windows.Forms.PaintEventHandler(this._timeView_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this._startBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._finishBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._stopBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 45);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // AcTimerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 115);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._timeView);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcTimerDialog";
            this.Text = "タイマー";
            ((System.ComponentModel.ISupportInitialize) (this._timeView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.PictureBox _timeView;

        private System.Windows.Forms.Button _startBtn;
        private System.Windows.Forms.Button _finishBtn;
        private System.Windows.Forms.Button _stopBtn;

        #endregion
    }
}