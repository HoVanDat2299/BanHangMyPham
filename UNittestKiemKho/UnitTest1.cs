using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL_DAL;

namespace UNittestKiemKho
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNhapSaiSoLuong()
        {
            Kho_BLL kho = new Kho_BLL();
            int masp = 1;
            int soluongnhap = -1;
            string nhaCungCap = "dat";
            string result = kho.themPhieuNhapUnitTest(masp, soluongnhap, nhaCungCap);
            Assert.AreEqual("Loi", result);
        }

        [TestMethod]
        public void TestKhongNhapGiCa()
        {
            Kho_BLL kho = new Kho_BLL();
            int masp = 1;
            int soluongnhap = 0;
            string nhaCungCap = "";
            string result = kho.themPhieuNhapUnitTest(masp, soluongnhap, nhaCungCap);
            Assert.AreEqual("Loi", result);
        }

        [TestMethod]
        public void TestThanhCong()
        {
            Kho_BLL kho = new Kho_BLL();
            int masp = 1;
            int soluongnhap = 10;
            string nhaCungCap = "Dat 1";
            string result = kho.themPhieuNhapUnitTest(masp, soluongnhap, nhaCungCap);
            Assert.AreEqual("Cập nhật sản phẩm thành công", result);
        }
    }
}
