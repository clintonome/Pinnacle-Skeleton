using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void Instanceok()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void EmailAlertOk()
        {
            //Create new instance of customer class
            clsCustomer Customer = new clsCustomer();
            //Test to see if boolean works to assign to a property.
            Boolean TestData = true;
            //assign boolean to the property
            Customer.Active = TestData;
            // test to see if this works
            Assert.AreEqual(Customer.Active, TestData);
        }
        [TestMethod]
        public void CusAdressOk()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
            string TestData = "LE3 6EE ";
            //assign the data to the property
            Customer.CusAdress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CusAdress, TestData);
        }
        [TestMethod]
        public void CusPasswordOk()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
            string TestData = "Password123!";
            Customer.CusPassword = TestData;
            Assert.AreEqual(Customer.CusPassword, TestData);
        }
        [TestMethod]
        public void CusUsernameOk()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
            string TestData = "JohnSmith";
            Customer.CusUsername = TestData;
            Assert.AreEqual(Customer.CusUsername, TestData);
        }
        [TestMethod]
        public void CusEmailOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
            string TestData = "johnsmith@gmail.com";
            Customer.CusEmail = TestData;
            Assert.AreEqual(Customer.CusEmail, TestData);
        }
        [TestMethod]
        public void CusDOB()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
            DateTime TestData = DateTime.Now;
            Customer.CusDOB = TestData;
            Assert.AreEqual(Customer.CusDOB, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            int CusId = 1;
            Found = customer.Find(CusId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCusIdFound()
        {
            
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressNo = 5;
            Found = customer.Find(AddressNo);
            if (customer.CusId != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCusAdressFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CusId = 5;
            Found = customer.Find(CusId);
            if (customer.CusAdress != "XXX XXX")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCusDOBFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CusId = 5;
            Found = customer.Find(CusId);
            if (customer.CusDOB != Convert.ToDateTime("01/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAlertsActiveFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CusId = 5;
            Found = customer.Find(CusId);
            if (customer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCusEmailFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CusId = 5;
            Found = customer.Find(CusId);
            if (customer.CusEmail != "TestName@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCusUsernameFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CusId = 5;
            Found = customer.Find(CusId);
            if (customer.CusUsername != "TestName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCusPasswordFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CusId = 5;
            Found = customer.Find(CusId);
            if (customer.CusPassword != "TestPassword")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

