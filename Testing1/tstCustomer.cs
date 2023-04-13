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
            string TestData = "grange lane";
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
            string TestData = "User12345";
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
            int CusId = 21;
            Found = customer.Find(CusId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCusIdFound()
        {
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CusId = 21;
            Found = customer.Find(CusId);
            if (customer.CusId != 21)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
           
        }
    }
}

