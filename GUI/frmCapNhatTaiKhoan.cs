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
    public partial class frmCapNhatTaiKhoan : Form
    {
        CapNhatTaiKhoan_BLL_DAL tk = new CapNhatTaiKhoan_BLL_DAL();
        public frmCapNhatTaiKhoan()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loadDataGridView()
        {
            tk.ShowTaiKhoan(grdViewTaiKhoan);
        }

        private void frmCapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            
        }
    }
}
