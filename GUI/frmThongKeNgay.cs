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
    public partial class frmThongKeNgay : Form
    {
        ThongKe_BLL TK = new ThongKe_BLL();
        public frmThongKeNgay()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToShortDateString();

            DateTime a = DateTime.Parse(ngay);
            dataGridNgay.DataSource = TK.getDoanhThuNgay(a);
           
            MessageBox.Show(ngay.ToString());
        }

        private void btn_thongkethang_Click(object sender, EventArgs e)
        {
            string thang = dateTimePicker1.Value.Month.ToString();
            string nam = dateTimePicker1.Value.Year.ToString();
            dataGridNgay.DataSource = TK.getDoanhThuThang(thang,nam);


        }
    }
}
