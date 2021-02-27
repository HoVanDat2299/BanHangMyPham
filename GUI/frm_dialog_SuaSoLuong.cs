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
    public partial class frm_dialog_SuaSoLuong : Form
    {
        frmBanHang frmOut;
        int masp;


        public frm_dialog_SuaSoLuong(frmBanHang frmIn,int maSP,int SLMoi,string ten)
        {
            InitializeComponent();
            frmOut = frmIn;
            numericUpDownSuaSoLuong.Value = SLMoi;
            masp = maSP;
            lblTenSanPham.Text = ten;
        }

        private void frm_dialog_SuaSoLuong_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int slMoi = int.Parse(numericUpDownSuaSoLuong.Value.ToString());
            frmOut.thayDoiSoLuongChon(masp, slMoi);
            this.Hide();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOut.xoaSanPham(masp);
            this.Hide();
        }
    }
}
