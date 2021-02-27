using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class sanpham
    {
        
        private static int masp;

        public static int Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private static string tensp;

        public static string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        private static int manhom;

        public static int Manhom
        {
            get { return manhom; }
            set { manhom = value; }
        }
        public static string gianhap, giaban;

        public static string Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        public static string Gianhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }
        private static string mota;

        public static string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        public static  Binary hinhsanpham;

        public static  Binary Hinhsanpham
        {
            get { return hinhsanpham; }
            set { hinhsanpham = value; }
        }


    }
}
