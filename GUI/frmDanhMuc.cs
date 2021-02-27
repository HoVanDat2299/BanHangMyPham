using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmDanhMuc : Form
    {

        DanhMuc_BLL dm_bll = new DanhMuc_BLL();

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            loadDanhMucSanPham();
        }

       private void loadDanhMucSanPham()
        {
            dm_bll.getDataLoaiSP(listBoxDanhMuc);
            listBoxDanhMuc.DisplayMember = "TenNhomSP";
            listBoxDanhMuc.ValueMember = "MaNhomSP";
        }

       private void listBoxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
       {
           string ma = listBoxDanhMuc.SelectedValue.ToString().Trim();
           int masp;
           Int32.TryParse(ma, out masp);
           dm_bll.getDataSanPhamForGridView(masp, dataGridViewChiTiet);
       }

       public void hienThiThietLapGia()
       {
           frmThietLapGia gia = new frmThietLapGia();
           gia.TopLevel = false;
           this.pnThietLapGia.Controls.Add(gia);
           gia.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           gia.Dock = DockStyle.Fill;
           gia.Show();
       }

       public void hienthipanel()
       {
           pnThietLapGia.Visible = true;
       }

       private void btnthem_Click(object sender, EventArgs e)
       {
           hienThiThietLapGia();
       }
    }
}
