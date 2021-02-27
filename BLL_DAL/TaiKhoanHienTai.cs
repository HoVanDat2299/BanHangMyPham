using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class TaiKhoanHienTai
    {
        public static string TaiKhoan, DiaChi, HoTen;
        private static int maNhomNV;

        public static int MaNhomNV
        {
            get { return TaiKhoanHienTai.maNhomNV; }
            set { TaiKhoanHienTai.maNhomNV = value; }
        }
        public static string HoTen1
        {
            get { return TaiKhoanHienTai.HoTen; }
            set { TaiKhoanHienTai.HoTen = value; }
        }

      
        public static string DiaChi1
        {
            get { return TaiKhoanHienTai.DiaChi; }
            set { TaiKhoanHienTai.DiaChi = value; }
        }

        public static string TaiKhoan1
        {
            get { return TaiKhoanHienTai.TaiKhoan; }
            set { TaiKhoanHienTai.TaiKhoan = value; }
        }
        private static Binary HinhAnh;

        public static Binary HinhAnh1
        {
            get { return TaiKhoanHienTai.HinhAnh; }
            set { TaiKhoanHienTai.HinhAnh = value; }
        }

    }
}
