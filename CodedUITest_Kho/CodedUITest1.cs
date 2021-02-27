using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using BLL_DAL;


namespace CodedUITest_Kho
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        Kho_BLL a = new Kho_BLL();
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            this.UIMap.RecordedMethod5Params.UICboLoaiComboBoxSelectedItem = "Sua Tam";
            this.UIMap.RecordedMethod5Params.UICboSanPhamComboBoxSelectedItem = "2";
            this.UIMap.RecordedMethod5Params.UITxtNhaCungCapEditText = "vandat";
            this.UIMap.RecordedMethod5Params.UITxtSoLuongNhapEditText = "12";
            this.UIMap.AssertMethod5ExpectedValues.UITxtSoLuongEditText = (12 + int.Parse(a.laysotonTheoSPham("2").ToString())).ToString();
            this.UIMap.RecordedMethod5();
        
        }

        [TestMethod]
        public void CodedUITestMethodChiDuocNhapSo()
        {

            this.UIMap.RecordedNhapSo1();
            this.UIMap.AssertNhapSo1();

        }

        [TestMethod]
        public void CodedUITestKhongDuocBoTrong()
        {

            this.UIMap.RecordedBoTrong();
            this.UIMap.AssertBoTrong();

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
