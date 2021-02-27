using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_DAL;
namespace BLL_DAL
{
    public class KhachHang_BLL_DAL
    {
        QLMyPhamDataContext khachhang = new QLMyPhamDataContext();
        public KhachHang_BLL_DAL()
        {
        }
        public void themKhachHang(String tenkh, String diaChi, String SDT)
        {
            KhachHang kh = new KhachHang();
            kh.TenKH = tenkh;
            kh.DiaChi = diaChi;
            kh.SĐT = SDT;
            kh.MaLoaiKH = 1;
            kh.Diem = 0;

            khachhang.KhachHangs.InsertOnSubmit(kh);
            khachhang.SubmitChanges();
        }
    }
}
