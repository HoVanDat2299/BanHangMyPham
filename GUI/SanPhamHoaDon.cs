using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class SanPhamHoaDon
    {
        private int maSP,giaBan, soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        private string tenSP, moTaSP;

        public string MoTaSP
        {
            get { return moTaSP; }
            set { moTaSP = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public SanPhamHoaDon(int maSP, string tenSP, string moTaSP, int giaBan, int soLuong)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.moTaSP = moTaSP;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
        }
        public SanPhamHoaDon()
        {
        }


    }
}
