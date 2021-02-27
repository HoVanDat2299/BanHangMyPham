namespace GUI
{
    partial class frmDanhMuc
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
            this.pnDanhMuc = new System.Windows.Forms.Panel();
            this.pnChiTiet = new System.Windows.Forms.Panel();
            this.listBoxDanhMuc = new System.Windows.Forms.ListBox();
            this.dataGridViewChiTiet = new System.Windows.Forms.DataGridView();
            this.pnThietLapGia = new System.Windows.Forms.Panel();
            this.pnDanhMuc.SuspendLayout();
            this.pnChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDanhMuc
            // 
            this.pnDanhMuc.Controls.Add(this.listBoxDanhMuc);
            this.pnDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.pnDanhMuc.Name = "pnDanhMuc";
            this.pnDanhMuc.Size = new System.Drawing.Size(142, 478);
            this.pnDanhMuc.TabIndex = 0;
            // 
            // pnChiTiet
            // 
            this.pnChiTiet.Controls.Add(this.pnThietLapGia);
            this.pnChiTiet.Controls.Add(this.dataGridViewChiTiet);
            this.pnChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChiTiet.Location = new System.Drawing.Point(142, 0);
            this.pnChiTiet.Name = "pnChiTiet";
            this.pnChiTiet.Size = new System.Drawing.Size(817, 478);
            this.pnChiTiet.TabIndex = 1;
            // 
            // listBoxDanhMuc
            // 
            this.listBoxDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDanhMuc.FormattingEnabled = true;
            this.listBoxDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.listBoxDanhMuc.Name = "listBoxDanhMuc";
            this.listBoxDanhMuc.Size = new System.Drawing.Size(142, 478);
            this.listBoxDanhMuc.TabIndex = 0;
            this.listBoxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.listBoxDanhMuc_SelectedIndexChanged);
            // 
            // dataGridViewChiTiet
            // 
            this.dataGridViewChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            this.dataGridViewChiTiet.Size = new System.Drawing.Size(817, 252);
            this.dataGridViewChiTiet.TabIndex = 0;
            // 
            // pnThietLapGia
            // 
            this.pnThietLapGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThietLapGia.Location = new System.Drawing.Point(0, 252);
            this.pnThietLapGia.Name = "pnThietLapGia";
            this.pnThietLapGia.Size = new System.Drawing.Size(817, 226);
            this.pnThietLapGia.TabIndex = 1;
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 478);
            this.Controls.Add(this.pnChiTiet);
            this.Controls.Add(this.pnDanhMuc);
            this.Name = "frmDanhMuc";
            this.Text = "frmDanhMuc";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.pnDanhMuc.ResumeLayout(false);
            this.pnChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDanhMuc;
        private System.Windows.Forms.ListBox listBoxDanhMuc;
        private System.Windows.Forms.Panel pnChiTiet;
        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.Panel pnThietLapGia;
    }
}