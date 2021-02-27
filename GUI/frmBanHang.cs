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
    public partial class frmBanHang : Form
    {
        GioHang_BLL_DAL GioHang = new GioHang_BLL_DAL();
        List<SanPhamHoaDon> lstGioHang = new List<SanPhamHoaDon>();
        private int tienKhachDuaChoQuay;
        int check = 0;
        public int TienKhachDuaChoQuay
        {
            get { return tienKhachDuaChoQuay; }
            set { tienKhachDuaChoQuay = value; }
        }

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cboSanPham.DataSource = GioHang.getAllSanPham();
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";

            cbKhachHang.DataSource = GioHang.LayDanhSachKhachHang();
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "MaKH";

            txtTienTraKhach.Text = tienKhachDuaChoQuay+"";

            btnTaoHoaDon.Enabled = false;

        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ma = int.Parse(cboSanPham.SelectedValue.ToString());
            
            SanPham s = GioHang.getSanPhamTheoMa(ma);
            int giaBan = (int)s.GiaBanSP;
            string tenSP = s.TenSP;
            string moTa = s.MoTaSP;
            txtTenSanPham.Text = s.TenSP;
            txtMaSanPham.Text = ma+"";
            txtTenSanPham.Text = tenSP;
            txtMoTa.Text = moTa;
            txtGiaBan.Text = giaBan+"";
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text != "")
            {
                int masanpham = int.Parse(txtMaSanPham.Text);
                int soluongton = GioHang.laySoLuongSanPhamTrongKho(masanpham);
                int soluongchon;
                try
                {
                    soluongchon = int.Parse(cbSoLuong.Text.ToString());
                }
                catch
                {
                    soluongchon = 1;
                }
                if (soluongchon > soluongton)
                {
                    MessageBox.Show("Số lượng trong kho không đủ. Trong kho chỉ còn " + soluongton + " sản phẩm.");
                }
                else
                {

                    if (txtMaSanPham.Text == "")
                    {
                        MessageBox.Show("Cần chọn sản phẩm trước khi thêm vào giỏ ", "Thông báo !!!");
                        return;
                    }
                    else if (cbSoLuong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn số lượng", "Thông báo !!!");
                        return;
                    }
                    else
                    {
                        SanPhamHoaDon sp = new SanPhamHoaDon();
                        sp.MaSP = int.Parse(txtMaSanPham.Text);
                        sp.TenSP = txtTenSanPham.Text;
                        sp.MoTaSP = txtMoTa.Text;
                        sp.GiaBan = int.Parse(txtGiaBan.Text);
                        sp.SoLuong = int.Parse(cbSoLuong.Text.ToString());
                        int dem = 0;
                        for (int i = 0; i < lstGioHang.Count; i++)
                        {
                            dem++;
                            if (lstGioHang[i].MaSP == sp.MaSP)
                            {
                                if ((lstGioHang[i].SoLuong + sp.SoLuong) > soluongton)
                                {
                                    MessageBox.Show("Số lượng trong kho không đủ. Trong kho chỉ còn " + soluongton + " sản phẩm.");
                                    return;
                                }
                                else
                                {
                                    lstGioHang[i].SoLuong = lstGioHang[i].SoLuong + sp.SoLuong;
                                    LoadDataGridView();
                                    return;
                                }
                            }

                        }
                        if (dem == (lstGioHang.Count))
                        {
                            lstGioHang.Add(sp);
                            LoadDataGridView();
                        }

                        if (lstGioHang.Count == 0)
                        {
                            lstGioHang.Add(sp);
                            LoadDataGridView();
                        }



                    }
                }
              
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
            }
        }


        public void LoadDataGridView()
        {
            dataGridViewDanhSachDaChon.DataSource = "";
            dataGridViewDanhSachDaChon.DataSource = lstGioHang;

            
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {

         
                
            int tongtien = 0;
            //int mahoadon = GioHang.layMaHoaDonVuaLap();
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                tongtien += lstGioHang[i].GiaBan * lstGioHang[i].SoLuong;
                
            }
            txtTongTienHang.Text = tongtien+"";
            txtKhachCanTra.Text = (tongtien - (int.Parse(txtGiamGia.Text)))+"";
            DateTime time = DateTime.Now;
            String nv = TaiKhoanHienTai.TaiKhoan1;
            int maKhachHang;
            if (ckbKhachHangVangLai.Checked == true)
            {
                maKhachHang = 7;
            }
            else
            {
                maKhachHang = int.Parse(cbKhachHang.SelectedValue.ToString());//Lấy giá trị load lên từ combobox
            }
            
            GioHang.TaoHoaDon(nv, time, maKhachHang, int.Parse(txtKhachCanTra.Text.ToString()));
            int mahoadon = GioHang.layMaHoaDonVuaLap();
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                
                GioHang.TaoChiTietHoaDon(mahoadon, lstGioHang[i].MaSP, lstGioHang[i].SoLuong,
                    lstGioHang[i].GiaBan, int.Parse(txtKhachCanTra.Text.ToString()));
                GioHang.capNhatSoLuongTonSauKhiBan(lstGioHang[i].MaSP, lstGioHang[i].SoLuong);
            }

            GioHang.capNhatDiemTichLuyChoKhachHang(maKhachHang, tongtien);
            //lưu các giá trị để chuẩn bị cho quá trình in hóa đơn
            ThongTinHoaDon.NgayMua = DateTime.Now.ToShortDateString();
            ThongTinHoaDon.TenNhanVien = TaiKhoanHienTai.HoTen;
            ThongTinHoaDon.TenKhachHang = cbKhachHang.Text.ToString();
            ThongTinHoaDon.TongTien = txtKhachCanTra.Text.ToString();
            List<SanPhamTrongGioHang> listSP = new List<SanPhamTrongGioHang>();
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                listSP.Add(new SanPhamTrongGioHang(lstGioHang[i].TenSP, lstGioHang[i].SoLuong + "", (lstGioHang[i].GiaBan * lstGioHang[i].SoLuong)+""));

            }
            ThongTinHoaDon.Sanhams = listSP;

            frm_HoaDon frmhoadon = new frm_HoaDon();
            frmhoadon.ShowDialog();
            listSP.Clear();
            lstGioHang.Clear();
            LoadDataGridView();
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtTienTraKhach.Text = "";
            txtTongTienHang.Text = "";
            txtGiamGia.Text = "";
            txtKhachCanTra.Text = "";
            txtKhachThanhToan.Text = "";
            txtGiaBan.Text = "";
            cbSoLuong.Text = "0";
            txtMoTa.Text = "";
            btnTaoHoaDon.Enabled = false;
            txtGiaBan.Text = "";

        }

        private void btnTamTinh_Click(object sender, EventArgs e)
        {
            check++;
            int tongtien = 0;
            int giamGia = 0;//xét điều kiện của đối tượng khách để thực hiện giảm giá
            int khachCanTra = 0;
            int tienKhachDua = 0;
            int tienTraKhach = 0;
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                tongtien += lstGioHang[i].GiaBan * lstGioHang[i].SoLuong;
            }
            int makh = int.Parse(cbKhachHang.SelectedValue.ToString());
            giamGia = (GioHang.layKhuyenMai(makh) * tongtien) / 100;
            
            khachCanTra = tongtien - giamGia;
            tienKhachDua = int.Parse(txtKhachThanhToan.Text.ToString());
            tienTraKhach = tienKhachDua - khachCanTra;

            txtTongTienHang.Text = tongtien + "";
            txtKhachCanTra.Text = khachCanTra + "";
            txtTienTraKhach.Text = (tienKhachDua - khachCanTra) + "";
            txtGiamGia.Text = giamGia + "";

            if (int.Parse(txtTienTraKhach.Text.ToString()) >= 0)
            {
                btnTaoHoaDon.Enabled = true;
                check = 0;
            }
            else
            {
                if (check == 1)
                    MessageBox.Show("Chọn tiền khách đưa");
            }
            

            
            
        }

        private void cbSoLuong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int masanpham = int.Parse(txtMaSanPham.Text);
            int soluongton = GioHang.laySoLuongSanPhamTrongKho(masanpham);
            int soluongchon = int.Parse(cbSoLuong.Text.ToString());
            if (soluongchon > soluongton)
            {
                MessageBox.Show("Số lượng trong kho không đủ. Trong kho chỉ còn " + soluongton + " sản phẩm.");
            }
            else
                cbSoLuong.Text = soluongton+"";
            
        }

        private void cbSoLuong_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKhachThanhToan_MouseClick(object sender, MouseEventArgs e)
        {
            frm_ChonTien frm = new frm_ChonTien(this);
            frm.ShowDialog();
        }
        public void xacNhanTienKhachDua(int n)
        {
            if (n == 1)
            {
                txtKhachThanhToan.Text = tienKhachDuaChoQuay + "";
                int tienLD = int.Parse(txtKhachThanhToan.Text.ToString()) - int.Parse(txtKhachCanTra.Text.ToString());
                txtTienTraKhach.Text = tienLD.ToString();
                if (tienLD >= 0)
                {
                    
                    btnTaoHoaDon.Enabled = true;
                }
            }
            else
            {
                txtKhachThanhToan.Text = txtKhachCanTra.Text;
                txtTienTraKhach.Text = "0";
            }
        }

        private void dataGridViewDanhSachDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int maSP = int.Parse(dataGridViewDanhSachDaChon.Rows[row].Cells[2].Value.ToString());
                int soLuong = int.Parse(dataGridViewDanhSachDaChon.Rows[row].Cells[0].Value.ToString());
                string ten = dataGridViewDanhSachDaChon.Rows[row].Cells[4].Value.ToString();
                frm_dialog_SuaSoLuong frm = new frm_dialog_SuaSoLuong(this, maSP, soLuong, ten);
                frm.ShowDialog();
            }
            catch { }
        }

        public void thayDoiSoLuongChon(int maSP, int soLuongMoi)
        {
            if (soLuongMoi == 0)
            {
                for (int i = 0; i < lstGioHang.Count; i++)
                {
                    if (lstGioHang[i].MaSP == maSP)
                    {
                        lstGioHang.Remove(lstGioHang[i]);
                    }
                }
                LoadDataGridView();
            }
            else
            {
                for (int i = 0; i < lstGioHang.Count; i++)
                {
                    if (lstGioHang[i].MaSP == maSP)
                    {
                        lstGioHang[i].SoLuong = soLuongMoi;
                    }
                }
                LoadDataGridView();
            }
            
        }

        public void xoaSanPham(int maSp)
        {
            for (int i = 0; i < lstGioHang.Count; i++)
            {
                if (lstGioHang[i].MaSP == maSp)
                {
                    lstGioHang.Remove(lstGioHang[i]);
                }
            }
            LoadDataGridView();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ma;
            try
            {
                ma = int.Parse(dataGridViewDanhSachDaChon.CurrentRow.Cells[2].Value.ToString());
                for (int i = 0; i < lstGioHang.Count; i++)
                {
                    if (lstGioHang[i].MaSP == ma)
                    {
                        lstGioHang.Remove(lstGioHang[i]);
                    }
                }
                LoadDataGridView();
            }
            catch
            {
                MessageBox.Show("Chưa chọn sản phẩm");
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frm_dialog_ThemKhachHang frm = new frm_dialog_ThemKhachHang(this);
            frm.ShowDialog();
        }

        public void loadKhachHang(String ten)
        {
            cbKhachHang.DataSource = GioHang.LayDanhSachKhachHang();
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "MaKH";

            cbKhachHang.Text = ten;
        }

        private void txtTongTienHang_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
