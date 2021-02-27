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
    public partial class frm_dialog_ThemKhachHang : Form
    {
        frmBanHang frmOut;
        public frm_dialog_ThemKhachHang(frmBanHang frmIn)
        {
            InitializeComponent();
            frmOut = frmIn;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Mời nhập dữ liệu");
                return;


            }
            else
            {
                foreach (char c in txtSoDienThoai.Text)
                {
                    if (!Char.IsNumber(c) || Char.IsSymbol(c))
                    {
                        MessageBox.Show("So dien thoai phai nhap so va khong co ki tu dac biet");
                        return;
                    }
                }

                foreach (char c in txtTenKhachHang.Text)
                {
                    if (Char.IsNumber(c) || Char.IsSymbol(c))
                    {
                        MessageBox.Show("Ho ten khong duoc nhap so hoac ki tu");
                        return;
                    }
                }

                KhachHang_BLL_DAL khachhang = new KhachHang_BLL_DAL();
                khachhang.themKhachHang(txtTenKhachHang.Text.ToString(), txtDiaChi.Text.ToString(), txtSoDienThoai.Text.ToString());
                frmOut.loadKhachHang(txtTenKhachHang.Text.ToString().Trim());
                this.Hide();
            }
               


            
          
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmOut.loadKhachHang(txtTenKhachHang.Text.ToString().Trim());
            this.Hide();
        }
    }
}
