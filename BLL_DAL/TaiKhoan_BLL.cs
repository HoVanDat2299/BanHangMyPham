using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class TaiKhoan_BLL
    {

        QLMyPhamDataContext qlmypham = new QLMyPhamDataContext();
        public TaiKhoan_BLL() { }

        public bool kiemtrataikhoan(string taikhoan,string matkhau)
        {
            var user = (from s in qlmypham.TaiKhoans where s.TaiKhoan1 == taikhoan  select s).First();
            if (user.MatKhau == matkhau)
                return true;
                   
            return false;
        }

    }
}
