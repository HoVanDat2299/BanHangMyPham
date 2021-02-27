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
    public partial class frm_ChonTien : Form
    {
        frmBanHang frmOut;

        public frm_ChonTien(frmBanHang frmIn)
        {
            InitializeComponent();
            frmOut = frmIn;
        }
        int tienKhachDua = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 1000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 2000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 5000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 10000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 20000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 50000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 100000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 200000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            tienKhachDua = int.Parse(txtTienKhachDua.Text.ToString());
            tienKhachDua += 500000;
            txtTienKhachDua.Text = tienKhachDua + "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            frmOut.TienKhachDuaChoQuay = int.Parse(txtTienKhachDua.Text.ToString());
            frmOut.xacNhanTienKhachDua(1);
            this.Close();
        }

        private void btnKhachDuaDu_Click(object sender, EventArgs e)
        {
            frmOut.TienKhachDuaChoQuay = int.Parse(txtTienKhachDua.Text.ToString());
            frmOut.xacNhanTienKhachDua(2);
            this.Close();
        }
    }
}
