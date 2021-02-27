using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            lblTenNhanVien.Text = ThongTinHoaDon.TenNhanVien;
            lblTenKhachHang.Text = ThongTinHoaDon.TenKhachHang;
            lblNgayMuaHang.Text = ThongTinHoaDon.NgayMua;
            lblTongTien.Text = ThongTinHoaDon.TongTien;
            dataGridViewGioHang.DataSource = ThongTinHoaDon.Sanhams;
        }
    }
}
