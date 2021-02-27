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
    public partial class frmDangNhap : Form
    {
        TaiKhoan_BLL tk = new TaiKhoan_BLL();
        CapNhatTaiKhoan_BLL_DAL tk1 = new CapNhatTaiKhoan_BLL_DAL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.user__2_;
            panel1.ForeColor = Color.FromArgb(50, 224, 196);
            txtTaiKhoan.ForeColor = Color.FromArgb(50, 224, 196);

            pictureBox3.BackgroundImage = Properties.Resources.padlock__1_;
            txtMatKhau.ForeColor = Color.White;

        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            txtMatKhau.PasswordChar = '*';
            pictureBox3.BackgroundImage = Properties.Resources.open_lock__1_;
            txtMatKhau.ForeColor = Color.FromArgb(50, 224, 196);


            pictureBox2.BackgroundImage = Properties.Resources.user__1_;
            panel1.ForeColor = Color.White;
            txtTaiKhoan.ForeColor = Color.White;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Nhập tài khoản");
                return;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Nhập mật khẩu");
                return;
            }
            try
            {
                if (tk.kiemtrataikhoan(txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    tk1.loadDuLieuTaiKhoanHienTai(txtTaiKhoan.Text);
                    this.Hide();
                    frmTrangChu a = new frmTrangChu();
                    a.Show();
                  

                }
            }
            catch
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không chính xác");
                return;
            }
            
        }

        private void ptThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
