using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstReturns
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReturns AnReturns = new clsReturns();
            Assert.IsNotNull(AnReturns);
        }

        [TestMethod]
        public void TestReturnedOnTime()
        {
            clsReturns AnReturns = new clsReturns();
            Boolean TestData = true;
            AnReturns.Active = TestData;
            Assert.AreEqual(AnReturns.Active, TestData);
        }

        [TestMethod]
        public void TestDateReturned()
        {
            clsReturns AnReturns = new clsReturns();
            DateTime TestData = DateTime.Now.Date;
            AnReturns.DateReturned = TestData;
            Assert.AreEqual(AnReturns.DateReturned, TestData);
        }

        [TestMethod]
        public void TestDescription()
        {
            clsReturns AnReturns = new clsReturns();
            string TestData = "Jeans";
            AnReturns.Description = TestData;
            Assert.AreEqual(AnReturns.Description, TestData);
        }

        [TestMethod]
        public void TestCustomerName()
        {
            clsReturns AnReturns = new clsReturns();
            string TestData = "Joe";
            AnReturns.CustomerName = TestData;
            Assert.AreEqual(AnReturns.CustomerName, TestData);
        }

        [TestMethod]
        public void TestQuantity()
        {
            clsReturns AnReturns = new clsReturns();
            int TestData = 5;
            AnReturns.Quantity = TestData;
            Assert.AreEqual(AnReturns.Quantity, TestData);
        }

        [TestMethod]
        public void TestPrice()
        {
            clsReturns AnReturns = new clsReturns();
            const double V = 15.99;
            decimal TestData = (decimal)V;
            AnReturns.Price = TestData;
            Assert.AreEqual(AnReturns.Price, TestData);
        }

    }
}