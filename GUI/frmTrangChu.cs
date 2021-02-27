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
    public partial class frmTrangChu : Form
    {
        CapNhatTaiKhoan_BLL_DAL tk = new CapNhatTaiKhoan_BLL_DAL();
        PhanQuyen_BLL_DAL pq= new PhanQuyen_BLL_DAL();
        public frmTrangChu()
        {
            InitializeComponent();
            phanQuyen();    
            hideSubMenu();
           
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
           
            openChildForm(new frmThongTinTaiKhoan());      
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemTaiKhoan());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCapNhatTaiKhoan());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDanhMuc());
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThietLapGia());
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKho());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            hideSubMenu();
        }
        #endregion

     
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBanHang());
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
         
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmPhanQuyen());
            hideSubMenu();
        }


        private void phanQuyen()
        {
            List<Button> btn = new List<Button>(); btn.Add(btnBanHang); btn.Add(BtnThongTinTaiKhoan); btn.Add(btnThemTaiKhoan); btn.Add(btnCapNhatTaiKhoan); btn.Add(btnHangHoa); btn.Add(btnDanhMuc); btn.Add(btnThietlapGia); btn.Add(btnKiemKho); btn.Add(btnThongKe); btn.Add(btnPhanQuyen);

            foreach (Button bn in btn)
            {
                if (pq.kiemtraphanquyenmanhinh(int.Parse(bn.Tag.ToString()), TaiKhoanHienTai.MaNhomNV))
                {
                    bn.Visible = true;
                    bn.Enabled = true;
                }
                else
                {
                    bn.Visible = false;
                    bn.Enabled = false      ;
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeNgay());
            hideSubMenu();
        }

    }
}
