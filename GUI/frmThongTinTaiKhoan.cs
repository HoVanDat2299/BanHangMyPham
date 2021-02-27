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
    public partial class frmThongTinTaiKhoan : Form
    {
        CapNhatTaiKhoan_BLL_DAL tk = new CapNhatTaiKhoan_BLL_DAL();
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            ShowDuLieu();
        }

        public void ShowDuLieu()
        {
            tk.loadDuLieu(lblDiaChi,lblHoTen,pictureBox1);
        }

        
    }
}
