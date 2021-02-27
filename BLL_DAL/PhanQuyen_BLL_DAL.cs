using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace BLL_DAL
{
    public class PhanQuyen_BLL_DAL
    {
        QLMyPhamDataContext ql = new QLMyPhamDataContext();
        public void GetDataNhom(DataGridView data)
        {
            var nhom = from n in ql.NhomNVs select n;
            data.DataSource = nhom;
        }
        public void GetDataPhanQuyen(DataGridView data,string maNhom)
        {
            var nhom = from n in ql.PhanQuyens join m in ql.ManHinhs on n.MaManHinh equals m.MaManHinh join l in ql.NhomNVs on n.MaNhomNV equals l.MaNhomNV where (n.MaNhomNV == int.Parse(maNhom)) select new { m.MaManHinh,m.TenManHinh,l.MaNhomNV,l.TenNhomNV,n.CoQuyen };
            data.DataSource = nhom;
        }

        public void CapNhatPhanQuyen(string manhom,string mamanhinh,bool coquyen)
        {
            PhanQuyen pq;
            int mn = int.Parse(manhom);
            int mmh = int.Parse(mamanhinh);
            pq = ql.PhanQuyens.Where(t => t.MaNhomNV == mn  && t.MaManHinh == mmh).FirstOrDefault();


            pq.CoQuyen = coquyen;
            ql.SubmitChanges();
        }

        public bool kiemtraphanquyenmanhinh(int mamanhinh,int manhomnv)
        {
          PhanQuyen  pq = ql.PhanQuyens.Where(t => t.MaNhomNV == manhomnv && t.MaManHinh == mamanhinh).FirstOrDefault();
            bool phanquyen= (bool)pq.CoQuyen;
          if (phanquyen)
          {
              return true;
          }
          return false;
        }
    }
}
