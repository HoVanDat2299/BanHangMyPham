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
    public partial class frmPhanQuyen : Form
    {
        PhanQuyen_BLL_DAL qlcf = new PhanQuyen_BLL_DAL();
        public frmPhanQuyen()
        {
            InitializeComponent();
            qlcf.GetDataNhom(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            qlcf.GetDataPhanQuyen(dataGridView2, dataGridView1.Rows[row].Cells[0].Value.ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtTenNhom.Text=dataGridView2.Rows[row].Cells[1].Value.ToString();
            txtTenManHinh.Text = dataGridView2.Rows[row].Cells[3].Value.ToString();
            checkBox1.Checked =(bool) dataGridView2.Rows[row].Cells[4].Value;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            qlcf.CapNhatPhanQuyen(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView2.CurrentRow.Cells[0].Value.ToString(), checkBox1.Checked);
            qlcf.GetDataPhanQuyen(dataGridView2, dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
