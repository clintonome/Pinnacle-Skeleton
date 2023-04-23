using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data create test to pass the method
        string cusUsername = "BradJohn";
        string cusPassword = "Password1";
        string cusEmail = "BradJohn@gmail.com";
        string cusAdress = "LE2 1EE";
        string cusDOB = DateTime.Now.Date.ToString();


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
        public void CusDOBOk()
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            Error = customer.Valid(cusUsername, cusPassword,cusEmail,cusAdress,cusDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestcusUsernameMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, ""); 
        }
        [TestMethod]
        public void TestcusUsernameMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "a";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        public void TestcusUsernameMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "aa";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusUsernameMaxMinusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "";
            cusUsername = cusUsername.PadRight(49,'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusUsernameMaxBoundry()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "";
            cusUsername = cusUsername.PadRight(50, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusUsernameMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "";
            cusUsername = cusUsername.PadRight(25, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusUsernameMaxExtreme()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusUsername = "";
            cusUsername = cusUsername.PadRight(300, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusPasswordMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusPasswordMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "a";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        public void TestcusPasswordMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "aa";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusPasswordMaxMinusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "";
            cusPassword = cusPassword.PadRight(49, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusPasswordMaxBoundry()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "";
            cusPassword = cusPassword.PadRight(50, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusPasswordMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "";
            cusPassword = cusPassword.PadRight(25, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusPasswordMaxExtreme()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusPassword = "";
            cusPassword = cusPassword.PadRight(300, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        public void TestcusEmailMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcuscusEmailMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "a";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        public void TestcusEmailMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "aa";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusEmailMaxMinusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "";
            cusEmail = cusEmail.PadRight(49, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusEmailMaxBoundry()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "";
            cusEmail = cusEmail.PadRight(50, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusEmaildMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "";
            cusEmail = cusEmail.PadRight(25, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusEmailMaxExtreme()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "";
            cusEmail = cusEmail.PadRight(300, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        public void TestcusAdressMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusAdress = "";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusAdressMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusEmail = "a";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        public void TestcusAdressMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusAdress = "aa";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusAdressMaxMinusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusAdress = "";
            cusAdress = cusAdress.PadRight(8, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusAdressMaxBoundry()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusAdress = "";
            cusAdress = cusAdress.PadRight(9, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusAdressldMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusAdress = "";
            cusUsername = cusAdress.PadRight(6,'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestcusAdressMaxExtreme()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusAdress = "";
            cusAdress = cusAdress.PadRight(100, 'a');
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestCusDOBExtremeMin()
        {
            
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string cusDOB = TestDate.ToString();
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCusDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string cusDOB = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCusDOBMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string cusDOB = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestCusDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string cusDOB = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCusDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string cusDOB = TestDate.ToString();
            //invoke the method
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CusDOBInvalidData()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string cusDOB = "This is not date";
            Error = customer.Valid(cusUsername, cusPassword, cusEmail, cusAdress, cusDOB);
        }




    }
}

