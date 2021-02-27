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
using System.IO;

namespace GUI
{
    public partial class frmXemChiTietSanPham : Form
    {
        public frmXemChiTietSanPham()
        {
            InitializeComponent();
            loadChiTietSanPham();
        }

        public void loadChiTietSanPham()
        {
            lblMaSanPham.Text = sanpham.Masp.ToString();
            lblMaNhom.Text = sanpham.Masp.ToString();
            lblTenSanPham.Text = sanpham.Tensp;
            lblMaNhom.Text = sanpham.Manhom.ToString();
            lblGiaNhap.Text = sanpham.Gianhap ;
            lblGiaBan.Text = sanpham.Giaban;
            lblMaNhom.Text = sanpham.Manhom.ToString() ; 
            lblMoTaSanPham.Text = sanpham.Mota;
            if(sanpham.hinhsanpham == null)
            {
                return;
            }
            MemoryStream memory = new MemoryStream(sanpham.hinhsanpham.ToArray());
            Image image = Image.FromStream(memory);
            if(image == null)
            {
                return;
            }
            pictureBoxHinhAnh.Image = image;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
