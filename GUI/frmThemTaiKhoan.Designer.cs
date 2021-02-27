namespace GUI
{
    partial class frmThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.pnnhaplaimk = new System.Windows.Forms.Panel();
            this.pnmatkhau = new System.Windows.Forms.Panel();
            this.pntaikhoan = new System.Windows.Forms.Panel();
            this.pndiachi = new System.Windows.Forms.Panel();
            this.pnhoten = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.lbchucvu = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(224)))), ((int)(((byte)(196)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.27826F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1028, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 178);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUploadPicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(224)))), ((int)(((byte)(196)))));
            this.btnUploadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPicture.Location = new System.Drawing.Point(676, -4);
            this.btnUploadPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(137, 43);
            this.btnUploadPicture.TabIndex = 0;
            this.btnUploadPicture.Text = "Choose picture";
            this.btnUploadPicture.UseVisualStyleBackColor = false;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click_1);
            // 
            // pnnhaplaimk
            // 
            this.pnnhaplaimk.BackColor = System.Drawing.Color.White;
            this.pnnhaplaimk.Location = new System.Drawing.Point(678, 611);
            this.pnnhaplaimk.Name = "pnnhaplaimk";
            this.pnnhaplaimk.Size = new System.Drawing.Size(319, 1);
            this.pnnhaplaimk.TabIndex = 19;
            // 
            // pnmatkhau
            // 
            this.pnmatkhau.BackColor = System.Drawing.Color.White;
            this.pnmatkhau.Location = new System.Drawing.Point(678, 559);
            this.pnmatkhau.Name = "pnmatkhau";
            this.pnmatkhau.Size = new System.Drawing.Size(319, 1);
            this.pnmatkhau.TabIndex = 22;
            // 
            // pntaikhoan
            // 
            this.pntaikhoan.BackColor = System.Drawing.Color.White;
            this.pntaikhoan.Location = new System.Drawing.Point(678, 497);
            this.pntaikhoan.Name = "pntaikhoan";
            this.pntaikhoan.Size = new System.Drawing.Size(319, 1);
            this.pntaikhoan.TabIndex = 21;
            // 
            // pndiachi
            // 
            this.pndiachi.BackColor = System.Drawing.Color.White;
            this.pndiachi.Location = new System.Drawing.Point(678, 374);
            this.pndiachi.Name = "pndiachi";
            this.pndiachi.Size = new System.Drawing.Size(319, 1);
            this.pndiachi.TabIndex = 20;
            // 
            // pnhoten
            // 
            this.pnhoten.BackColor = System.Drawing.Color.White;
            this.pnhoten.Location = new System.Drawing.Point(678, 330);
            this.pnhoten.Name = "pnhoten";
            this.pnhoten.Size = new System.Drawing.Size(319, 1);
            this.pnhoten.TabIndex = 32;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(224)))), ((int)(((byte)(196)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(700, 675);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 42);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // lbNhapLaiMatKhau
            // 
            this.lbNhapLaiMatKhau.AutoSize = true;
            this.lbNhapLaiMatKhau.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhapLaiMatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNhapLaiMatKhau.Location = new System.Drawing.Point(418, 586);
            this.lbNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau";
            this.lbNhapLaiMatKhau.Size = new System.Drawing.Size(194, 25);
            this.lbNhapLaiMatKhau.TabIndex = 30;
            this.lbNhapLaiMatKhau.Text = "Nhập lại mật khẩu :";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmatkhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbmatkhau.Location = new System.Drawing.Point(505, 537);
            this.lbmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(111, 25);
            this.lbmatkhau.TabIndex = 29;
            this.lbmatkhau.Text = "Mật khẩu :";
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtaikhoan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbtaikhoan.Location = new System.Drawing.Point(498, 481);
            this.lbtaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(118, 25);
            this.lbtaikhoan.TabIndex = 28;
            this.lbtaikhoan.Text = "Tài khoản :";
            // 
            // lbchucvu
            // 
            this.lbchucvu.AutoSize = true;
            this.lbchucvu.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbchucvu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbchucvu.Location = new System.Drawing.Point(512, 424);
            this.lbchucvu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbchucvu.Name = "lbchucvu";
            this.lbchucvu.Size = new System.Drawing.Size(105, 25);
            this.lbchucvu.TabIndex = 27;
            this.lbchucvu.Text = "Chức vụ :";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdiachi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbdiachi.Location = new System.Drawing.Point(527, 360);
            this.lbdiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(90, 25);
            this.lbdiachi.TabIndex = 26;
            this.lbdiachi.Text = "Địa chỉ :";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbhoten.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbhoten.Location = new System.Drawing.Point(530, 297);
            this.lbhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(88, 25);
            this.lbhoten.TabIndex = 25;
            this.lbhoten.Text = "Họ tên :";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtNhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhapLaiMK.ForeColor = System.Drawing.Color.White;
            this.txtNhapLaiMK.Location = new System.Drawing.Point(678, 582);
            this.txtNhapLaiMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.PasswordChar = '*';
            this.txtNhapLaiMK.Size = new System.Drawing.Size(321, 22);
            this.txtNhapLaiMK.TabIndex = 24;
            this.txtNhapLaiMK.Text = "123";
            this.txtNhapLaiMK.Click += new System.EventHandler(this.txtNhapLaiMK_Click);
            // 
            // cboChucVu
            // 
            this.cboChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cboChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChucVu.ForeColor = System.Drawing.Color.White;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(676, 422);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(321, 24);
            this.cboChucVu.TabIndex = 23;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.Location = new System.Drawing.Point(676, 526);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(321, 22);
            this.txtMatKhau.TabIndex = 18;
            this.txtMatKhau.Text = "123";
            this.txtMatKhau.Click += new System.EventHandler(this.txtMatKhau_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Location = new System.Drawing.Point(676, 472);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(321, 22);
            this.txtTaiKhoan.TabIndex = 17;
            this.txtTaiKhoan.Text = "Nhập tài khoản";
            this.txtTaiKhoan.Click += new System.EventHandler(this.txtTaiKhoan_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.White;
            this.txtDiaChi.Location = new System.Drawing.Point(676, 349);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(321, 22);
            this.txtDiaChi.TabIndex = 16;
            this.txtDiaChi.Text = "Nhập địa chỉ";
            this.txtDiaChi.Click += new System.EventHandler(this.txtDiaChi_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.ForeColor = System.Drawing.Color.White;
            this.txtHoTen.Location = new System.Drawing.Point(676, 297);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(321, 22);
            this.txtHoTen.TabIndex = 15;
            this.txtHoTen.Text = "Nhập Họ tên";
            this.txtHoTen.Click += new System.EventHandler(this.txtHoTen_Click);
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1028, 763);
            this.Controls.Add(this.pnnhaplaimk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnmatkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pntaikhoan);
            this.Controls.Add(this.lbtaikhoan);
            this.Controls.Add(this.pndiachi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.pnhoten);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbNhapLaiMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.lbchucvu);
            this.Controls.Add(this.lbhoten);
            this.Controls.Add(this.lbdiachi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemTaiKhoan";
            this.Text = "frmThemTaiKhoan";
            this.Load += new System.EventHandler(this.frmThemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.Panel pnnhaplaimk;
        private System.Windows.Forms.Panel pnmatkhau;
        private System.Windows.Forms.Panel pntaikhoan;
        private System.Windows.Forms.Panel pndiachi;
        private System.Windows.Forms.Panel pnhoten;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbNhapLaiMatKhau;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.Label lbchucvu;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}