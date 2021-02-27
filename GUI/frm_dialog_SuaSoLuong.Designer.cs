namespace GUI
{
    partial class frm_dialog_SuaSoLuong
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
            this.numericUpDownSuaSoLuong = new System.Windows.Forms.NumericUpDown();
            this.tata = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuaSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSuaSoLuong
            // 
            this.numericUpDownSuaSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownSuaSoLuong.Location = new System.Drawing.Point(29, 114);
            this.numericUpDownSuaSoLuong.Name = "numericUpDownSuaSoLuong";
            this.numericUpDownSuaSoLuong.Size = new System.Drawing.Size(159, 29);
            this.numericUpDownSuaSoLuong.TabIndex = 12;
            // 
            // tata
            // 
            this.tata.AutoSize = true;
            this.tata.Location = new System.Drawing.Point(26, 42);
            this.tata.Name = "tata";
            this.tata.Size = new System.Drawing.Size(67, 13);
            this.tata.TabIndex = 13;
            this.tata.Text = "Sản phẩm  : ";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(129, 45);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(26, 13);
            this.lblTenSanPham.TabIndex = 14;
            this.lblTenSanPham.Text = "Tên";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(242, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(179, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "LƯU SỐ LƯỢNG MỚI";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(363, 339);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số lượng Sản phẩm  : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "XÓA SẢN PHẨM KHỎI GIỎ HÀNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_dialog_SuaSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.tata);
            this.Controls.Add(this.numericUpDownSuaSoLuong);
            this.Name = "frm_dialog_SuaSoLuong";
            this.Text = "Sửa";
            this.Load += new System.EventHandler(this.frm_dialog_SuaSoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuaSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSuaSoLuong;
        private System.Windows.Forms.Label tata;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}