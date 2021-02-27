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


namespace TestUIBanHang
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    this.UIMap.TestLan2Params.UICboSanPhamComboBoxSelectedItem = "White conc";
                    this.UIMap.TestLan2Params.UICbSoLuongComboBoxSelectedItem = "2";
                    this.UIMap.TestLan2Params.UICbKhachHangComboBoxSelectedItem = "Lê Vĩnh Khiêm";
                    this.UIMap.TestLan2();
                    this.UIMap.TestValue();
                }
                if (i == 1)
                {
                    this.UIMap.TestLan2Params.UICboSanPhamComboBoxSelectedItem = "Sữa tắm Manis";
                    this.UIMap.TestLan2Params.UICbSoLuongComboBoxSelectedItem = "3";
                    this.UIMap.TestLan2Params.UICbKhachHangComboBoxSelectedItem = "Lê Vĩnh Khiêm";
                    this.UIMap.TestLan2();
                    this.UIMap.TestValue();
                }
            }
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
