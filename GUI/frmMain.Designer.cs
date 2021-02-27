namespace GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.banHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangHoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiêtLâpGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiêmKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banHangToolStripMenuItem,
            this.hangHoaToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.giaoDichToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // banHangToolStripMenuItem
            // 
            this.banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            this.banHangToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.banHangToolStripMenuItem.Text = "Bán hàng";
            this.banHangToolStripMenuItem.Click += new System.EventHandler(this.banHangToolStripMenuItem_Click);
            // 
            // hangHoaToolStripMenuItem
            // 
            this.hangHoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucToolStripMenuItem,
            this.thiêtLâpGiaToolStripMenuItem,
            this.kiêmKhoToolStripMenuItem});
            this.hangHoaToolStripMenuItem.Name = "hangHoaToolStripMenuItem";
            this.hangHoaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hangHoaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTaiKhoanToolStripMenuItem,
            this.quanLyTaiKhoanToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // giaoDichToolStripMenuItem
            // 
            this.giaoDichToolStripMenuItem.Name = "giaoDichToolStripMenuItem";
            this.giaoDichToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.giaoDichToolStripMenuItem.Text = "Thống kê";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // thiêtLâpGiaToolStripMenuItem
            // 
            this.thiêtLâpGiaToolStripMenuItem.Name = "thiêtLâpGiaToolStripMenuItem";
            this.thiêtLâpGiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thiêtLâpGiaToolStripMenuItem.Text = "Thiết lập giá";
            // 
            // kiêmKhoToolStripMenuItem
            // 
            this.kiêmKhoToolStripMenuItem.Name = "kiêmKhoToolStripMenuItem";
            this.kiêmKhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kiêmKhoToolStripMenuItem.Text = "Kiểm kho";
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTaiKhoanToolStripMenuItem,
            this.xoaTaiKhoanToolStripMenuItem});
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // thêmTaiKhoanToolStripMenuItem
            // 
            this.thêmTaiKhoanToolStripMenuItem.Name = "thêmTaiKhoanToolStripMenuItem";
            this.thêmTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thêmTaiKhoanToolStripMenuItem.Text = "Thêm tài khoản ";
            // 
            // xoaTaiKhoanToolStripMenuItem
            // 
            this.xoaTaiKhoanToolStripMenuItem.Name = "xoaTaiKhoanToolStripMenuItem";
            this.xoaTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.xoaTaiKhoanToolStripMenuItem.Text = "Cập nhật tài khoản";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 496);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem banHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangHoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiêtLâpGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiêmKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaTaiKhoanToolStripMenuItem;
    }
}

