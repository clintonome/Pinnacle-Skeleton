using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{

    [TestClass]
    public class tstOrder
    {
        string CustName = "Fatima";
        string ShippingAddress = "LE5 4QB";
        string Price = "51";
        string Quantity = "2";
        string DateAdded = DateTime.Now.Date.ToString();

        private const double V = 100.25;

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void TestDelivered()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void TestDateAdded()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateAdded = TestData;
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void TestQuantity()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 20;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
        [TestMethod]
        public void TestPrice()
        {
            //create class instance
            clsOrder AnOrder = new clsOrder();
            //creates test data
            const double V = 100.25;
            double TestData = (double)V;

            AnOrder.Price = TestData;
            //test that it exists
            Assert.AreEqual(AnOrder.Price, TestData);
        }
        [TestMethod]
        public void TestCustName()
        {
            //create class instance
            clsOrder AnOrder = new clsOrder();
            //creates test data
            String TestData = "fatima";
            //assigns data
            AnOrder.CustName = TestData;
            //test that it exists
            Assert.AreEqual(AnOrder.CustName, TestData);
        }
        [TestMethod]
        public void TestShipAddress()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "LE5 4QB";
            AnOrder.ShippingAddress = TestData;
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustName != "Fatima")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.DateAdded != Convert.ToDateTime("12/01/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Quantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Price != 51)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShipAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.ShippingAddress != "LE5 4QB")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestValidation()
        {
            //create class instance
            clsOrder AnOrder = new clsOrder();
            //creates test data
            String Error = "";

            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCustNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCustNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "a";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCustnameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "aa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCustnameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "aaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCustnameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "aaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCustnameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "aaaaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCustnameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCustnameExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustName = "";
            CustName = CustName.PadRight(300, 'a');
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "a";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaaaaa";
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestShipAddExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(300, 'a');
            Error = AnOrder.Valid(CustName, Quantity, Price, DateAdded, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
    }
}

