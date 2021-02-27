using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKe_BLL
    {
        QLMyPhamDataContext QLMP = new QLMyPhamDataContext();
        public ThongKe_BLL()
        { }
        public IQueryable getDoanhThuNgay(DateTime a)
        {

            var th = from v in QLMP.HoaDons where (v.NgayBan == a) select new { v.MaHD, v.MaKH, v.NgayBan, v.TongTien };
            return th;
        }
        public IQueryable getDoanhThuThang(string thang, string nam)
        {

            var th = from HoaDons in QLMP.HoaDons
                     where
                       Convert.ToString(HoaDons.NgayBan.Value.Month) == thang &&
                       Convert.ToString(HoaDons.NgayBan.Value.Year) == nam
                     select new
                     {
                         MaHD = HoaDons.MaHD,
                         NgayBan = HoaDons.NgayBan,
                         MaKH = HoaDons.MaKH,
                         TongTien = HoaDons.TongTien
                     };
            return th;
        }


    }
}
