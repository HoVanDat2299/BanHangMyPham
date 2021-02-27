using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL_DAL
{
    
    public class GioHang_BLL_DAL
    {
        QLMyPhamDataContext QLMP = new QLMyPhamDataContext();
        
        public GioHang_BLL_DAL()
        {

        }

        public IQueryable getAllSanPham()
        {
            return from sp in QLMP.SanPhams select new { sp.MaSP, sp.TenSP, sp.GiaBanSP, sp.MoTaSP };
        }

        public SanPham getSanPhamTheoMa(int maSP)
        {
            SanPham s = new SanPham();
            var sanpham = from sp in QLMP.SanPhams where( sp.MaSP==maSP) select new { sp.MaSP, sp.TenSP, sp.GiaBanSP, sp.MoTaSP };
            foreach (var ss in sanpham)
            {
                s.MaSP = ss.MaSP;
                s.TenSP = ss.TenSP;
                s.MoTaSP = ss.MoTaSP;
                s.GiaBanSP = ss.GiaBanSP;
            }
            return s;
        }

        public void TaoHoaDon(String TaiKhoanNhanVien,DateTime NgayBan,int MaKH,Decimal TongTien)
        {
            HoaDon hd = new HoaDon();
            hd.TaiKhoan = TaiKhoanNhanVien;
            hd.NgayBan = NgayBan;
            hd.MaKH = MaKH;
            hd.TongTien = TongTien;

            QLMP.HoaDons.InsertOnSubmit(hd);
            QLMP.SubmitChanges();
        }

        public void TaoChiTietHoaDon(int mahoadon,int masanpham,int soluong,Decimal giaban,Decimal thanhtien)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHD = mahoadon;
            cthd.MaSP = masanpham;
            cthd.SoLuong = soluong;
            cthd.GiaBan = giaban;
            cthd.ThanhTien = thanhtien;

            QLMP.ChiTietHoaDons.InsertOnSubmit(cthd);
            QLMP.SubmitChanges();
        }
        public int layMaHoaDonVuaLap()
        {
            var count = QLMP.HoaDons.Count();
            var hd = QLMP.HoaDons.OrderBy(c => 1 == 1).Skip(count - 1).FirstOrDefault();
            int mahoadoncuoi = hd.MaHD;
            return mahoadoncuoi;
        }

        public IQueryable LayDanhSachKhachHang()
        {
            return from kh in QLMP.KhachHangs select kh;
        }

        public int laySoLuongSanPhamTrongKho(int masp)
        {
            int soluong = 0;
            Kho kho = QLMP.Khos.Where(t=>t.MaSP==masp).FirstOrDefault();
            soluong = int.Parse(kho.SoLuongTon.ToString());
            return soluong;
        }

        public void capNhatSoLuongTonSauKhiBan(int masp,int soluongban)
        {
            Kho kho = new Kho();
            kho = QLMP.Khos.Where(t => t.MaSP == masp).FirstOrDefault();
            kho.SoLuongTon = kho.SoLuongTon - soluongban;

            QLMP.SubmitChanges();
        }

        public void capNhatDiemTichLuyChoKhachHang(int makhachhang, int tongtien)
        {
            int diemcong = 0;
            KhachHang kh = QLMP.KhachHangs.Where(t => t.MaKH == makhachhang).FirstOrDefault();
            if (tongtien < 200000)
                diemcong = 10;
            else if (tongtien < 500000)
                diemcong = 20;
            else
                diemcong = 30;
            kh.Diem = kh.Diem + diemcong;

            //Thực hiện cập nhật loại khách hàng
            LoaiKH vip1 = QLMP.LoaiKHs.Where(t => t.MaLoaiKH == 1).FirstOrDefault();
            LoaiKH vip2 = QLMP.LoaiKHs.Where(t => t.MaLoaiKH == 2).FirstOrDefault();
            LoaiKH vip3 = QLMP.LoaiKHs.Where(t => t.MaLoaiKH == 3).FirstOrDefault();

            if (kh.Diem >= vip3.MocDiem)
                kh.MaLoaiKH = 3;
            else if (kh.Diem >= vip2.MocDiem && kh.Diem <= vip3.MocDiem)
                kh.MaLoaiKH = 2;
            else if (kh.Diem >= vip1.MocDiem && kh.Diem <= vip2.MocDiem)
                kh.MaLoaiKH = 1;
            else
                kh.MaLoaiKH = 4;
            QLMP.SubmitChanges();

        }

        public int layKhuyenMai(int makhach)
        {
            int loai = 0;
            KhachHang kh = new KhachHang();
            kh = QLMP.KhachHangs.Where(t => t.MaKH == makhach).FirstOrDefault();
            loai = int.Parse(kh.MaLoaiKH.ToString());
            LoaiKH loaikhachhang = QLMP.LoaiKHs.Where(t => t.MaLoaiKH == loai).FirstOrDefault();
            int khuyenmai = 0;
            khuyenmai = int.Parse(loaikhachhang.KhuyenMai.ToString());

            return khuyenmai;
        }
    }
}
