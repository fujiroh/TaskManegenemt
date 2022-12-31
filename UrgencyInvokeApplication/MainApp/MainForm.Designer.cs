using RemainingTimerChartControl = MainApp.RemainTimer.RemainingTimerChartControl;

namespace MainApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._menu = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileNewCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.上書き保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.印刷PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷プレビューVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて選択AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カスタマイズCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.インデックスIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ファイルFToolStripMenuItem, this.編集EToolStripMenuItem, this.ツールTToolStripMenuItem, this.ヘルプHToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(471, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this._menuFileNewCreate, this.開くOToolStripMenuItem, this.toolStripSeparator, this.上書き保存SToolStripMenuItem, this.名前を付けて保存AToolStripMenuItem, this.toolStripSeparator1, this.印刷PToolStripMenuItem, this.印刷プレビューVToolStripMenuItem, this.toolStripSeparator2, this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // _menuFileNewCreate
            // 
            this._menuFileNewCreate.Image = ((System.Drawing.Image) (resources.GetObject("_menuFileNewCreate.Image")));
            this._menuFileNewCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._menuFileNewCreate.Name = "_menuFileNewCreate";
            this._menuFileNewCreate.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._menuFileNewCreate.Size = new System.Drawing.Size(184, 22);
            this._menuFileNewCreate.Text = "新規作成(&N)";
            this._menuFileNewCreate.Click += new System.EventHandler(this._menuFileNewCreate_Click);
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("開くOToolStripMenuItem.Image")));
            this.開くOToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.開くOToolStripMenuItem.Text = "開く(&O)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // 上書き保存SToolStripMenuItem
            // 
            this.上書き保存SToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("上書き保存SToolStripMenuItem.Image")));
            this.上書き保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem";
            this.上書き保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存SToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.上書き保存SToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // 名前を付けて保存AToolStripMenuItem
            // 
            this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
            this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // 印刷PToolStripMenuItem
            // 
            this.印刷PToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("印刷PToolStripMenuItem.Image")));
            this.印刷PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷PToolStripMenuItem.Name = "印刷PToolStripMenuItem";
            this.印刷PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.印刷PToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.印刷PToolStripMenuItem.Text = "印刷(&P)";
            // 
            // 印刷プレビューVToolStripMenuItem
            // 
            this.印刷プレビューVToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("印刷プレビューVToolStripMenuItem.Image")));
            this.印刷プレビューVToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷プレビューVToolStripMenuItem.Name = "印刷プレビューVToolStripMenuItem";
            this.印刷プレビューVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.印刷プレビューVToolStripMenuItem.Text = "印刷プレビュー(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.元に戻すUToolStripMenuItem, this.やり直しRToolStripMenuItem, this.toolStripSeparator3, this.切り取りTToolStripMenuItem, this.コピーCToolStripMenuItem, this.貼り付けPToolStripMenuItem, this.toolStripSeparator4, this.すべて選択AToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 元に戻すUToolStripMenuItem
            // 
            this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
            this.元に戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)";
            // 
            // やり直しRToolStripMenuItem
            // 
            this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
            this.やり直しRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.やり直しRToolStripMenuItem.Text = "やり直し(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // 切り取りTToolStripMenuItem
            // 
            this.切り取りTToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("切り取りTToolStripMenuItem.Image")));
            this.切り取りTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem";
            this.切り取りTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りTToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.切り取りTToolStripMenuItem.Text = "切り取り(&T)";
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("コピーCToolStripMenuItem.Image")));
            this.コピーCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("貼り付けPToolStripMenuItem.Image")));
            this.貼り付けPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // すべて選択AToolStripMenuItem
            // 
            this.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem";
            this.すべて選択AToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.すべて選択AToolStripMenuItem.Text = "すべて選択(&A)";
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.カスタマイズCToolStripMenuItem, this.オプションOToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // カスタマイズCToolStripMenuItem
            // 
            this.カスタマイズCToolStripMenuItem.Name = "カスタマイズCToolStripMenuItem";
            this.カスタマイズCToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.カスタマイズCToolStripMenuItem.Text = "カスタマイズ(&C)";
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.内容CToolStripMenuItem, this.インデックスIToolStripMenuItem, this.検索SToolStripMenuItem, this.toolStripSeparator5, this.バージョン情報AToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            // 
            // インデックスIToolStripMenuItem
            // 
            this.インデックスIToolStripMenuItem.Name = "インデックスIToolStripMenuItem";
            this.インデックスIToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.インデックスIToolStripMenuItem.Text = "インデックス(&I)";
            // 
            // 検索SToolStripMenuItem
            // 
            this.検索SToolStripMenuItem.Name = "検索SToolStripMenuItem";
            this.検索SToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.検索SToolStripMenuItem.Text = "検索(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this._menu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this._menu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuFileNewCreate;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 印刷PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 印刷プレビューVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 切り取りTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem すべて選択AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem カスタマイズCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem インデックスIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem;

        private System.Windows.Forms.MenuStrip _menu;

        #endregion
    }
}