using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ThongTinHoaDon
    {
        public static String tenNhanVien, tenKhachHang, ngayMua, tongTien;

        public static String TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public static String NgayMua
        {
            get { return ngayMua; }
            set { ngayMua = value; }
        }

        public static String TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }

        public static String TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
         public static List<SanPhamTrongGioHang> sanhams;

        public static List<SanPhamTrongGioHang> Sanhams
        {
            get { return sanhams; }
            set { sanhams = value; }
        }
    }
}
