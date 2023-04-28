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
        [TestMethod]
        public void AddMethodOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CusUsername = "BradJohn";
            TestItem.CusId = 1;
            TestItem.CusPassword = "Passsword1";
            TestItem.CusEmail = "BradJohn@gmail.com";
            TestItem.CusAdress = "LE2 1EE";
            TestItem.CusDOB = DateTime.Now.Date;
            allCustomer.ThisCustomer = TestItem;
            PrimaryKey = allCustomer.Add();
            allCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(allCustomer.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void UpdateMethod()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CusUsername = "BradJohn";
            TestItem.CusId = 1;
            TestItem.CusPassword = "Passsword1";
            TestItem.CusEmail = "BradJohn@gmail.com";
            TestItem.CusAdress = "LE2 1EE";
            TestItem.CusDOB = DateTime.Now.Date;
            allCustomer.ThisCustomer = TestItem;
            PrimaryKey = allCustomer.Add();
            TestItem.Active = true;
            TestItem.CusUsername = "BenJohn";
            TestItem.CusId = 3;
            TestItem.CusPassword = "Passsword1231";
            TestItem.CusEmail = "BenJohn@gmail.com";
            TestItem.CusAdress = "LE2 6EE";
            TestItem.CusDOB = DateTime.Now.Date;
            allCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(allCustomer.ThisCustomer, TestItem);

        }

       [TestMethod]
       public void DeleteMethodOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CusUsername = "BradJohn";
            TestItem.CusId = 1;
            TestItem.CusPassword = "Passsword1";
            TestItem.CusEmail = "BradJohn@gmail.com";
            TestItem.CusAdress = "LE2 1EE";
            TestItem.CusDOB = DateTime.Now.Date;
            allCustomer.ThisCustomer = TestItem;
            PrimaryKey = allCustomer.Add();
            TestItem.CusId = PrimaryKey;
            allCustomer.ThisCustomer.Find(PrimaryKey);
            allCustomer.Delete();
            Boolean Found = allCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
       [TestMethod]
       public void ReportByUsernameOk()
        {
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            clsCustomer FilteredUsername = new clsCustomer();
            FilteredUsername.ReportByUsername("");
            Assert.AreEqual(allCustomer.Count, FilteredUsername);
        }
        [TestMethod]
        public void ReportByCusUsername()
        {
            clsCustomerCollection FilteredUsername = new clsCustomerCollection();
            Boolean Ok = false;
            FilteredUsername.ReportByUsername("XXXXXX");
            if (FilteredUsername.Count == 8)
            {
                if (FilteredUsername.CustomerList[0].CusId != 36)
                {
                    Ok = false;
                }
                if (FilteredUsername.CustomerList[1].CusId != 37)
                {
                    Ok = false;
                }

            }
            else
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
