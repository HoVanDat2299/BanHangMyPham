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
    public partial class frmThemTaiKhoan : Form
    {
        CapNhatTaiKhoan_BLL_DAL taikhoan = new CapNhatTaiKhoan_BLL_DAL();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
          
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            loadCbo();
        }

        public void loadCbo()
        {
            cboChucVu.DataSource = taikhoan.LoadcboChucVu();
            cboChucVu.ValueMember = "MaNhomNV";
            cboChucVu.DisplayMember = "TenNhomNV";
        }

        private void btnUploadPicture_Click_1(object sender, EventArgs e)
        {
            taikhoan.uploadHinhAnh(pictureBox1);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            lbdiachi.ForeColor = Color.FromArgb(50, 224, 196);
            txtDiaChi.ForeColor = Color.FromArgb(50, 224, 196);
            pndiachi.BackColor = Color.FromArgb(50, 224, 196);

            
            lbtaikhoan.ForeColor = Color.White;
            txtTaiKhoan.ForeColor = Color.White;
            pntaikhoan.BackColor = Color.White;

         

            lbmatkhau.ForeColor = Color.White;
            txtMatKhau.ForeColor = Color.White;
            pnmatkhau.BackColor = Color.White;

            lbNhapLaiMatKhau.ForeColor = Color.White;
            txtNhapLaiMK.ForeColor = Color.White;
            pnnhaplaimk.BackColor = Color.White;

            lbhoten.ForeColor = Color.White;
            txtHoTen.ForeColor = Color.White;
            pnhoten.BackColor = Color.White;


        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {

            txtHoTen.Clear();
            lbhoten.ForeColor = Color.FromArgb(50, 224, 196);
            txtHoTen.ForeColor = Color.FromArgb(50, 224, 196);
            pnhoten.BackColor = Color.FromArgb(50, 224, 196);

            lbtaikhoan.ForeColor = Color.White;
            txtTaiKhoan.ForeColor = Color.White;
            pntaikhoan.BackColor = Color.White;

            lbdiachi.ForeColor = Color.White;
            txtDiaChi.ForeColor = Color.White;
            pndiachi.BackColor = Color.White;

            lbmatkhau.ForeColor = Color.White;
            txtMatKhau.ForeColor = Color.White;
            pnmatkhau.BackColor = Color.White;

            lbNhapLaiMatKhau.ForeColor = Color.White;
            txtNhapLaiMK.ForeColor = Color.White;
            pnnhaplaimk.BackColor = Color.White;




        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            lbtaikhoan.ForeColor = Color.FromArgb(50, 224, 196);
            txtTaiKhoan.ForeColor = Color.FromArgb(50, 224, 196);
            pntaikhoan.BackColor = Color.FromArgb(50, 224, 196);


            lbdiachi.ForeColor = Color.White;
            txtDiaChi.ForeColor = Color.White;
            pndiachi.BackColor = Color.White;

            lbmatkhau.ForeColor = Color.White;
            txtMatKhau.ForeColor = Color.White;
            pnmatkhau.BackColor = Color.White;

            lbNhapLaiMatKhau.ForeColor = Color.White;
            txtNhapLaiMK.ForeColor = Color.White;
            pnnhaplaimk.BackColor = Color.White;

            lbhoten.ForeColor = Color.White;
            txtHoTen.ForeColor = Color.White;
            pnhoten.BackColor = Color.White;

        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();

            lbmatkhau.ForeColor = Color.FromArgb(50, 224, 196);
            txtMatKhau.ForeColor = Color.FromArgb(50, 224, 196);
            pnmatkhau.BackColor = Color.FromArgb(50, 224, 196);

            lbNhapLaiMatKhau.ForeColor = Color.White;
            txtNhapLaiMK.ForeColor = Color.White;
            pnnhaplaimk.BackColor = Color.White;


            lbhoten.ForeColor = Color.White;
            txtHoTen.ForeColor = Color.White;
            pnhoten.BackColor = Color.White;

            lbdiachi.ForeColor = Color.White;
            txtDiaChi.ForeColor = Color.White;
            pndiachi.BackColor = Color.White;


            lbtaikhoan.ForeColor = Color.White;
            txtTaiKhoan.ForeColor = Color.White;
            pntaikhoan.BackColor = Color.White;


        }

        private void txtNhapLaiMK_Click(object sender, EventArgs e)
        {
            txtNhapLaiMK.Clear();
            lbNhapLaiMatKhau.ForeColor = Color.FromArgb(50, 224, 196);
            pnnhaplaimk.BackColor = Color.FromArgb(50, 224, 196);


            txtNhapLaiMK.ForeColor = Color.FromArgb(50, 224, 196);

            lbhoten.ForeColor = Color.White;
            txtHoTen.ForeColor = Color.White;
            pnhoten.BackColor = Color.White;

            lbdiachi.ForeColor = Color.White;
            txtDiaChi.ForeColor = Color.White;
            pndiachi.BackColor = Color.White;

            lbtaikhoan.ForeColor = Color.White;
            txtTaiKhoan.ForeColor = Color.White;
            pntaikhoan.BackColor = Color.White;

            lbmatkhau.ForeColor = Color.White;
            txtMatKhau.ForeColor = Color.White;
            pnmatkhau.BackColor = Color.White;

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (taikhoan.kiemTrakhoachinh(txtTaiKhoan.Text.Trim()))
            {
                taikhoan.ThemTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text, txtDiaChi.Text, int.Parse(cboChucVu.SelectedValue.ToString()), pictureBox1);
            }
            else
                MessageBox.Show("Tài khoản đã tồn tại");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
