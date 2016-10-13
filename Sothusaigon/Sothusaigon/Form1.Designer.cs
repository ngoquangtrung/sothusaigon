namespace Sothusaigon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lstThumoi = new System.Windows.Forms.ListBox();
            this.lstdanhsach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnluudanhsach = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoChépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstThumoi
            // 
            this.lstThumoi.AllowDrop = true;
            this.lstThumoi.FormattingEnabled = true;
            this.lstThumoi.Location = new System.Drawing.Point(19, 76);
            this.lstThumoi.Name = "lstThumoi";
            this.lstThumoi.Size = new System.Drawing.Size(139, 225);
            this.lstThumoi.TabIndex = 0;
            this.lstThumoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstThumoi_MouseDown);
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.AllowDrop = true;
            this.lstdanhsach.FormattingEnabled = true;
            this.lstdanhsach.Location = new System.Drawing.Point(176, 76);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.Size = new System.Drawing.Size(139, 225);
            this.lstdanhsach.TabIndex = 1;
            this.lstdanhsach.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstdanhsach_DragDrop);
            this.lstdanhsach.DragOver += new System.Windows.Forms.DragEventHandler(this.lstdanhsach_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thú mới :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách thú :";
            // 
            // btnluudanhsach
            // 
            this.btnluudanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluudanhsach.Location = new System.Drawing.Point(249, 309);
            this.btnluudanhsach.Name = "btnluudanhsach";
            this.btnluudanhsach.Size = new System.Drawing.Size(69, 24);
            this.btnluudanhsach.TabIndex = 4;
            this.btnluudanhsach.Text = "Lưu DS";
            this.toolTip1.SetToolTip(this.btnluudanhsach, "Lưu Danh sách con thú vào file .txt");
            this.btnluudanhsach.UseVisualStyleBackColor = true;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(7, 318);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(35, 13);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "label3";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.lưuDanhSáchToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ sơ";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(151, 22);
            this.mnuLoad.Text = "Tải danh sách";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // lưuDanhSáchToolStripMenuItem
            // 
            this.lưuDanhSáchToolStripMenuItem.Name = "lưuDanhSáchToolStripMenuItem";
            this.lưuDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.lưuDanhSáchToolStripMenuItem.Text = "Lưu danh sách";
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoChépToolStripMenuItem,
            this.dánToolStripMenuItem,
            this.cắtToolStripMenuItem});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa đổi";
            // 
            // saoChépToolStripMenuItem
            // 
            this.saoChépToolStripMenuItem.Name = "saoChépToolStripMenuItem";
            this.saoChépToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.saoChépToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saoChépToolStripMenuItem.Text = "Sao chép";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + X";
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 340);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnluudanhsach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstdanhsach);
            this.Controls.Add(this.lstThumoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstThumoi;
        private System.Windows.Forms.ListBox lstdanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnluudanhsach;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem lưuDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoChépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

