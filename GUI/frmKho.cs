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
    public partial class frmKho : Form
    {
        Kho_BLL qlKho = new Kho_BLL();
        public frmKho()
        {
            InitializeComponent();
            loadCboLoai();
            cboSanPham.Enabled = false;
        }

        public void loadCboLoai()
        {
            cboLoai.DataSource =  qlKho.getLoai();
            cboLoai.DisplayMember = "TenNhomSP";
            cboLoai.ValueMember = "MaNhomSP";

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            loadKho();
        }
        public void loadKho()
        {
            qlKho.loadDataGridViewKho(dtgKho);
        }

        private void dtgKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhaCungCap.Text != "" && txtSoLuong.Text != "")
                {
                    if (!checkSoLuong(txtSoLuongNhap.Text.ToString()))
                    {
                        MessageBox.Show("Chi duoc nhap so", "Thong bao");
                        return;
                    }

                    int masp = int.Parse(cboSanPham.SelectedValue.ToString());
                    int soluong = int.Parse(txtSoLuongNhap.Text.Trim());
                    string nhacungcap = txtNhaCungCap.Text.ToString();
                    qlKho.themPhieuNhap(masp, soluong, nhacungcap);
                    loadKho();
                    txtSoLuongNhap.Clear();
                    txtNhaCungCap.Clear();
                }
                else
                {
                    MessageBox.Show("Khong duoc bo trong", "Thong bao");
                }
               
            }
            catch
            {
                MessageBox.Show("Khong duoc bo trong", "Thong bao");
            }

            
        }

        private void cboLoai_SelectedValueChanged(object sender, EventArgs e)

        {
            cboSanPham.Enabled = true;
            cboSanPham.DataSource = qlKho.loadSanPhamTheoLoai(cboLoai.SelectedValue.ToString());
            cboSanPham.DisplayMember = "MaSP";
            cboSanPham.ValueMember = "MaSP";
            
        }

        public bool checkSoLuong(string str)
        {
            foreach (char c in str)
            {
                if (char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void cboSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            
                
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSoLuong.Text = qlKho.laysotonTheoSPham(cboSanPham.SelectedValue.ToString());
            txtSoLuongNhap.Clear();
            txtNhaCungCap.Clear();
        }
    }
}
