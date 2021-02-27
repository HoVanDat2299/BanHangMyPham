using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DanhMuc_BLL
    {
        QLMyPhamDataContext qlmypham = new QLMyPhamDataContext();
       
        public DanhMuc_BLL() { }

        public void getDataLoaiSP(ListBox lst)
        {
            var sps = from sp in qlmypham.NhomSPs select new { sp.MaNhomSP, sp.TenNhomSP };
            lst.DataSource = sps;
        }

        public void getDataSanPhamForGridView(int masp, DataGridView da)
        {
            var sps = from sp in qlmypham.SanPhams.Where(t => t.MaNhomSP == masp) 
                      select new { sp.MaSP, sp.TenSP, sp.MaNhomSP, sp.GiaNhapSP, sp.GiaBanSP, sp.MoTaSP,sp.HinhAnh};

            da.DataSource = sps;
        }

        public void themLoaiSanPham(string tenloai)
        {
            NhomSP nhom = new NhomSP();
            nhom.TenNhomSP = tenloai;
            qlmypham.NhomSPs.InsertOnSubmit(nhom);
            qlmypham.SubmitChanges();
        }

        public void xoaLoaiSanPham(int maloai)
        {
            var loais = qlmypham.NhomSPs.Where(t => t.MaNhomSP == maloai).FirstOrDefault();
            var sp = qlmypham.SanPhams.Where(t1 => t1.MaNhomSP == maloai).FirstOrDefault();
            if (sp == null && loais != null)
            {
                qlmypham.NhomSPs.DeleteOnSubmit(loais);
                qlmypham.SubmitChanges();
                MessageBox.Show("Xóa thành công nhé!");
            }
            else 
            {
                MessageBox.Show("Sản phẩm còn hàng nên không được xóa đâu nhé");
            }
        }

        public void themSanPham(int masp, string tensp, int manhomsp, int gianhap, int giasuat, string mota,PictureBox picture)
        {
            SanPham sp = qlmypham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
            if (sp == null)
            {
                MemoryStream memory = new MemoryStream();
                picture.Image.Save(memory, ImageFormat.Jpeg);
                SanPham sanpham = new SanPham();
                sanpham.TenSP = tensp;
                sanpham.MaNhomSP = manhomsp;
                sanpham.GiaNhapSP = gianhap;
                sanpham.GiaBanSP = giasuat;
                sanpham.MoTaSP = mota;
                sanpham.HinhAnh = memory.ToArray();

                qlmypham.SanPhams.InsertOnSubmit(sanpham);
                qlmypham.SubmitChanges();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo vui!");
            }

            else 
            {
                SanPham spp = qlmypham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
                spp.GiaBanSP = giasuat;                
                qlmypham.SubmitChanges();
                MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo vui!");

            }
            qlmypham.SubmitChanges();
            

        }
        private byte[] ByteToImg(PictureBox picHinhSp)
        {
            FileStream fs;
            fs = new FileStream(picHinhSp.ToString(), FileMode.Open, FileAccess.Read);
            byte[] picturebyte = new byte[fs.Length];
            fs.Read(picturebyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picturebyte;
        }
        //upload hình ảnh theo định dạng
        public void uploadHinhAnh(PictureBox picture)
        {
            // open file dialog
            string imagelocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imagelocation = open.FileName;

                    picture.ImageLocation = imagelocation;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi hình ảnh");
            }
        }

        public void xoaSanPham(int masp)
        {
            SanPham sp = qlmypham.SanPhams.Where(t => t.MaSP == masp).FirstOrDefault();
            if(sp != null)
            {
                qlmypham.SanPhams.DeleteOnSubmit(sp);
                qlmypham.SubmitChanges();
            }
        }

        public bool ktraSanPham()
        {
            var sp = from k in qlmypham.SanPhams select k;
            if (sp != null)
                return false;
            return true;
        }

        //public void getHinhAnh( PictureBox picture )
        //{
        //    MemoryStream memory = new MemoryStream(sanpham.hinhsanpham.ToArray());
        //    Image image = Image.FromStream(memory);
        //    if (image == null)
        //    {
        //        MessageBox.Show("Không có hình");
        //        return;
        //    }
        //    picture.Image = image;
        //}

        
    }
}
