using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }
        [TestMethod]
        public void PermissionOK()
        {
            clsStaff staff = new clsStaff();
            Boolean TestData = true;
            staff.Permission = TestData;
            Assert.AreEqual(staff.Permission, TestData);
        }
        [TestMethod]
        public void StaffDateofBirthOK()
        {
            clsStaff staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staff.DateOfBirth = TestData;
            Assert.AreEqual(staff.DateOfBirth, TestData);
        }
        [TestMethod]
        public void StaffNameOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "Bob Reed";
            staff.Name = TestData;
            Assert.AreEqual(staff.Name, TestData);
        }
        [TestMethod]
        public void StaffPasswordOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "B0bby123";
            staff.Password = TestData;
            Assert.AreEqual(staff.Password, TestData);
        }
        [TestMethod]
        public void StaffRoleOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "Manager";
            staff.Role = TestData;
            Assert.AreEqual(staff.Role, TestData);
        }
        [TestMethod]
        public void StaffSalaryOK()
        {
            clsStaff staff = new clsStaff();
            int TestData = 1000;
            staff.Salary = TestData;
            Assert.AreEqual(staff.Salary, TestData);
        }
        [TestMethod]
        public void StaffID()
        {
            clsStaff staff = new clsStaff();
            int TestData = 1;
            staff.StaffID = TestData;
            Assert.AreEqual(staff.StaffID, TestData);
        }
        [TestMethod]
        public void FindMethodsOK()
        {
            //Creates an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creates some test data to use the method
            Int32 StaffID = 1;
            //Invoke the method
            Found = staff.Find(StaffID);
            //Test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffNoFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK
            Boolean OK = true;
            //Creates some test data to use with the method
            Int32 StaffID = 1;
            //Invoke the method
            Found = staff.Find(StaffID);
            //Check the ID
            if (staff.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestNameFoundOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = staff.Find(StaffID);
            if (staff.Name != "Bob Reed")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFoundOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = staff.Find(StaffID);
            if (staff.Password != "B0bby123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRoleFoundOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = staff.Find(StaffID);
            if (staff.Role != "Manager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSalaryFoundOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = staff.Find(StaffID);
            if (staff.Salary != 1000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFoundOK()
        {
            //Creates an instance of class
            clsStaff staff = new clsStaff();
            //Boolean variable variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffID = 1;
            //Invoke the method
            Found = staff.Find(StaffID);
            //Check the property
            if (staff.DateOfBirth != Convert.ToDateTime("23/08/1978"))
            {
                OK = false;
            }
            //Test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPermissionFoundOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = staff.Find(StaffID);
            if (staff.Permission != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}