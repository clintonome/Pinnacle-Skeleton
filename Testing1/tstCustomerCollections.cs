using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {



        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            Assert.IsNotNull(allCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //Creates instance
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            //Creates some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CusId = 1;
            TestItem.CusUsername = "benjames";
            TestItem.CusPassword = "password1";
            TestItem.CusAdress = "le2 7ea";
            TestItem.CusEmail = "benjames@gmail";
            TestItem.CusDOB = DateTime.Now.Date;
            //Add the item to the test list
            TestList.Add(TestItem);
            //assign data to the property
            allCustomer.CustomerList = TestList;
            //test to see if the two value are the same
            Assert.AreEqual(allCustomer.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            Int32 SomeCount = 0;
            allCustomer.Count = SomeCount;
            Assert.AreEqual(allCustomer.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Active = true;
            TestCustomer.CusId = 1;
            TestCustomer.CusUsername = "benjames";
            TestCustomer.CusPassword = "password1";
            TestCustomer.CusAdress = "le2 7ea";
            TestCustomer.CusEmail = "benjames@gmail";
            TestCustomer.CusDOB = DateTime.Now.Date;
            allCustomer.ThisCustomer = TestCustomer;
        }

        [TestMethod]
        public void CustomerListOk()
        {
            //Creates instance
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            //Creates some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CusId = 1;
            TestItem.CusUsername = "benjames";
            TestItem.CusPassword = "password1";
            TestItem.CusAdress = "le2 7ea";
            TestItem.CusEmail = "benjames@gmail";
            TestItem.CusDOB = DateTime.Now.Date;
            TestList.Add(TestItem);
            allCustomer.CustomerList = TestList;

        }

        [TestMethod]
        public void CustomerPropertyOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CusUsername = "BradJohn";
            TestItem.CusId = 1;
            TestItem.CusPassword = "Passsword 1";
            TestItem.CusEmail = "BradJohn@gmail.com";
            TestItem.CusAdress = "LE2 1EE";
            TestItem.CusDOB = DateTime.Now.Date;
            //allCustomer.(TestItem);

        }



    }
}
