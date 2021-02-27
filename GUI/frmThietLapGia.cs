using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using System.IO;

namespace GUI
{
    public partial class frmThietLapGia : Form
    {
        DanhMuc_BLL dm_bll = new DanhMuc_BLL();
        int idssp;
        public frmThietLapGia()
        {
            InitializeComponent();
        }

        private void frmThietLapGia_Load(object sender, EventArgs e)
        {
            loadDanhMucSanPham();
            pnThemLoai.Visible = false;
            pnChiTietSanPham.Visible = false;
        }
        private void loadDanhMucSanPham()
        {
            dm_bll.getDataLoaiSP(lstLoaiSP);
            lstLoaiSP.DisplayMember = "TenNhomSP";
            lstLoaiSP.ValueMember = "MaNhomSP";
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            pnThemLoai.Visible = true;
        }

        private void btnLuuLoai_Click(object sender, EventArgs e)
        {
            string ten = txtTenLoai.Text.Trim();
            if (ten != "")
            {
                dm_bll.themLoaiSanPham(ten);
                MessageBox.Show("Thêm loại thành công nhé!", "Thông báo!");
                loadDanhMucSanPham();
                //pnThemLoai.Visible = false;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập tên loại!", "Thông báo buồn!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoai.Focus();
            }

        }
        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            string id = lstLoaiSP.SelectedValue.ToString().Trim();
            int i = int.Parse(id);
            dm_bll.xoaLoaiSanPham(i);
            loadDanhMucSanPham();
        }

        private void lstLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lstLoaiSP.SelectedValue.ToString().Trim();

            int i;
            Int32.TryParse(id, out  i);

            dm_bll.getDataSanPhamForGridView(i, dataGridSanPham);
        }

        private void dataGridSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            idssp = int.Parse(dataGridSanPham.Rows[row].Cells[0].Value.ToString());
            txtTenSP.Text = dataGridSanPham.Rows[row].Cells[1].Value.ToString();
            txtGiaNhap.Text = dataGridSanPham.Rows[row].Cells[3].Value.ToString();
            txtGiaBan.Text = dataGridSanPham.Rows[row].Cells[4].Value.ToString();
            txtMoTa.Text = dataGridSanPham.Rows[row].Cells[5].Value.ToString();

            //sanpham.Masp = idssp;
            //sanpham.Tensp = dataGridSanPham.Rows[row].Cells[1].Value.ToString();

            //sanpham.gianhap = dataGridSanPham.Rows[row].Cells[3].Value.ToString();
            //sanpham.giaban = dataGridSanPham.Rows[row].Cells[4].Value.ToString();
            //string man = dataGridSanPham.Rows[row].Cells[2].Value.ToString();
            //int manhom;
            //Int32.TryParse(man, out manhom);
            //sanpham.Manhom = manhom;
            //sanpham.Mota = dataGridSanPham.Rows[row].Cells[5].Value.ToString();

            //sanpham.hinhsanpham = (Binary)dataGridSanPham.Rows[row].Cells[6].Value;

            //frmXemChiTietSanPham frmSanPham = new frmXemChiTietSanPham();
            //frmSanPham.ShowDialog();
            pnChiTietSanPham.Visible = true;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            idssp = -1;
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtMoTa.Text = "";
            btnXoaSP.Enabled = false;
            btnSuaSP.Enabled = false;
            txtTenSP.Focus();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(!checkSo(txtGiaNhap.Text.ToString()) || !checkSo(txtGiaBan.Text.ToString()))
                {
                    MessageBox.Show("Không được nhập số", "Thông báo");
                }
                else
                {
                    string tensp = txtTenSP.Text.Trim();
                    //int gianhap = int.Parse(txtGiaNhap.Text.Trim());
                    string gianhap = txtGiaNhap.Text.Trim();
                    int gn;
                    Int32.TryParse(gianhap, out gn);

                    int giaban = int.Parse(txtGiaBan.Text.Trim());
                    string id = lstLoaiSP.SelectedValue.ToString().Trim();
                    int maloai;
                    Int32.TryParse(id, out maloai);

                    string mota = txtMoTa.Text.Trim();
                    dm_bll.themSanPham(idssp, tensp, maloai, gn, giaban, mota, picHinhSp);
                    dm_bll.getDataSanPhamForGridView(maloai, dataGridSanPham);
                    btnThemSP.Enabled = true;
                    idssp = -1;
                    btnXoaSP.Enabled = true;
                    btnSuaSP.Enabled = true;
                    txtTenSP.Text = "";
                    txtGiaBan.Text = "";
                    txtGiaNhap.Text = "";
                    txtMoTa.Text = "";
                   // picHinhSp.Visible = false;
                }
           
            }
            catch
            {
                MessageBox.Show("Thông tin không được bỏ trống!","Thông báo");
            }            
        }

        public bool checkSo(string str)
        {
            foreach(char c in str)
            {
                if(!char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }



        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            //txtTenSP.Enabled = false;
            //txtGiaNhap.Enabled = false;
            //txtMoTa.Enabled = false;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string id = lstLoaiSP.SelectedValue.ToString().Trim();
            int maloai;
            Int32.TryParse(id, out maloai);
            dm_bll.xoaSanPham(idssp);
            MessageBox.Show("Xóa thành công nhé!", "Thông báo vui!");
            dm_bll.getDataSanPhamForGridView(maloai, dataGridSanPham);
        }

        private void btnUpLoadHinh_Click(object sender, EventArgs e)
        {
            dm_bll.uploadHinhAnh(picHinhSp);
            picHinhSp.Visible = true;
        }

        private void dataGridSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridSanPham.Rows[e.RowIndex].Cells[6].Value = Properties.Resources.Ontime;
            //MemoryStream ms = new MemoryStream((byte[])dataGridSanPham.CurrentRow.Cells[6].Value);
            //dataGridSanPham.Rows[e.RowIndex].Cells[6].Value 
        }

        private void btnChiTietSanPham_Click(object sender, EventArgs e)
        {
            string id = dataGridSanPham.CurrentRow.Cells[0].Value.ToString();
            int masp;
            Int32.TryParse(id, out masp);
            sanpham.Masp = masp;
            sanpham.Tensp = dataGridSanPham.CurrentRow.Cells[1].Value.ToString();

            sanpham.gianhap = dataGridSanPham.CurrentRow.Cells[3].Value.ToString();
            sanpham.giaban = dataGridSanPham.CurrentRow.Cells[4].Value.ToString();
            string man = dataGridSanPham.CurrentRow.Cells[2].Value.ToString();
            int manhom;
            Int32.TryParse(man, out manhom);
            sanpham.Manhom = manhom;
            sanpham.Mota = dataGridSanPham.CurrentRow.Cells[5].Value.ToString();

            sanpham.hinhsanpham = (Binary)dataGridSanPham.CurrentRow.Cells[6].Value;

            frmXemChiTietSanPham frmSanPham = new frmXemChiTietSanPham();
            frmSanPham.ShowDialog();
            pnChiTietSanPham.Visible = false;
        }


    }
}
