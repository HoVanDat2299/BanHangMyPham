using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class Kho_BLL
    {
        QLMyPhamDataContext qlMyPham = new QLMyPhamDataContext();

        public IQueryable getLoai()
        {
            var l = from li in qlMyPham.NhomSPs select li;
            return l;
        }
        public IQueryable loadSanPhamTheoLoai( string maloa)
        {
            var sanphams = from k in qlMyPham.SanPhams where Convert.ToString(k.MaNhomSP) == maloa select k;
            return sanphams;
            
        }

        public void loadDataGridViewKho(DataGridView da)
        {
            var sanphams = from k in qlMyPham.Khos select new { k.MaSP, k.SoLuongTon };
            da.DataSource = sanphams;
        }
        public string laysotonTheoSPham( string ten)
        {
            Kho sanphams = qlMyPham.Khos.Where(t=>t.MaSP==int.Parse(ten)).FirstOrDefault();
            if (sanphams != null)
            {
                return sanphams.SoLuongTon.ToString();
            }
            return "0";
            
        }
        public void themPhieuNhap(int masp, int soluongnhap, string nhacungcap)
        {
            SanPham sps = qlMyPham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
            if(sps!= null)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                ct.MaSP = masp;
                ct.NgayNhap = DateTime.Now;
                ct.SoLuong = soluongnhap;
                ct.NhaCungCap = nhacungcap;
                qlMyPham.ChiTietPhieuNhaps.InsertOnSubmit(ct);
                qlMyPham.SubmitChanges();

                Kho k = qlMyPham.Khos.Where(t =>t.MaSP == masp).FirstOrDefault();
                if(k!=null)
                {
                    k.SoLuongTon = ct.SoLuong + k.SoLuongTon;
                    qlMyPham.SubmitChanges();
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo");
                }
                
            }
            qlMyPham.SubmitChanges();
        }

        public string themPhieuNhapUnitTest(int masp, int soluongnhap, string nhacungcap)
        {
            if (soluongnhap > 0 && nhacungcap != "")
            {
                SanPham sps = qlMyPham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
                if (sps != null)
                {
                    ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                    ct.MaSP = masp;
                    ct.NgayNhap = DateTime.Now;
                    ct.SoLuong = soluongnhap;
                    ct.NhaCungCap = nhacungcap;
                    qlMyPham.ChiTietPhieuNhaps.InsertOnSubmit(ct);
                    qlMyPham.SubmitChanges();

                    Kho k = qlMyPham.Khos.Where(t => t.MaSP == masp).FirstOrDefault();
                    if (k != null)
                    {
                        k.SoLuongTon = ct.SoLuong + k.SoLuongTon;
                        qlMyPham.SubmitChanges();
                        return "Cập nhật sản phẩm thành công";
                    }
                    qlMyPham.SubmitChanges();
                }
            }            
            return "Loi";
           
        }

    }
}
