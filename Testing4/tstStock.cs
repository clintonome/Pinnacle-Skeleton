using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class UnitTest1
    {
        //test data
        string Description = "T-Shirt";
        string Colour = "White";
        string Price = "19.99";
        string Quantity = "20";
        string DateAdded = DateTime.Now.Date.ToString();


        [TestMethod]
        public void TestMethod1()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //test that it exists
            Assert.IsNotNull(Stock);
        }

        [TestMethod]

        public void TestStockID()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data

            int TestData = 3;

            //assigns data
            Stock.StockID = TestData;
            //test that it exists
            Assert.AreEqual(Stock.StockID, TestData);
        }

        [TestMethod]

        public void TestAvailability()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data
            Boolean TestData = true;
            //assigns data
            Stock.Availability = TestData;
            //test that it exists
            Assert.AreEqual(Stock.Availability, TestData);

        }
        [TestMethod]
        public void TestDateAdded()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data
            DateTime TestData = DateTime.Now.Date;
            //assigns data
            Stock.DateAdded = TestData;
            //test that it exists
            Assert.AreEqual(Stock.DateAdded, TestData);

        }
        [TestMethod]
        public void TestDescription()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data
            String TestData = "T-Shirt";
            //assigns data
            Stock.Description = TestData;
            //test that it exists
            Assert.AreEqual(Stock.Description, TestData);
        }
        [TestMethod]
        public void TestColour()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data
            String TestData = "Black";
            //assigns data
            Stock.Colour = TestData;
            //test that it exists
            Assert.AreEqual(Stock.Colour, TestData);
        }
        [TestMethod]
        public void TestQuantity()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data
            int TestData = 15;
            //assigns data
            Stock.Quantity = TestData;
            //test that it exists
            Assert.AreEqual(Stock.Quantity, TestData);
        }
        [TestMethod]
        public void TestPrice()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //creates test data
            const double V = 19.99;
            double TestData = (double)V;
            //assigns data
            Stock.Price = TestData;
            //test that it exists
            Assert.AreEqual(Stock.Price, TestData);
        }
        [TestMethod]
        public void TestFindMethod()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //test that it exists
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.StockID != 2)
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.Description != "T-Shirt")
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.DateAdded != Convert.ToDateTime("22/02/2023"))
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestColourFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.Colour != "White")
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.Quantity != 20)
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.Price != 19.99)
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 StockID = 2;
            //invokes instance
            Found = Stock.Find(StockID);
            //checks address
            if (Stock.Availability != true)
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestValidation()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestDescriptionMinLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionMin()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "a";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionMinPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "aa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionMaxLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionMid()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "aaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionMaxPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestDescriptionExtremeMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Description = "";
            Description = Description.PadRight(500, 'a');
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TestColourMinLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestColourMin()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "a";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestColourMinPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "aa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestColourMaxLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestColourMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestColourMid()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "aaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestColourMaxPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestColourExtremeMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Colour = "";
            Colour = Colour.PadRight(500, 'a');
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TestQuantityMinLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityMin()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "a";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityMinPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "aa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityMaxLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityMid()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "aaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityMaxPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestQuantityExtremeMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Quantity = "";
            Quantity = Quantity.PadRight(500, 'a');
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void TestPriceMinLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceMin()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "a";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceMinPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "aa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceMaxLessOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceMid()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "aaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceMaxPlusOne()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestPriceExtremeMax()
        {
            //create class instance
            clsStock Stock = new clsStock();
            //Stores error messege
            String Error = "";
            //test data for method
            string Price = "";
            Price = Price.PadRight(500, 'a');
            //invoke the method
            Error = Stock.Valid(Description, Colour, Quantity, Price, DateAdded);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }




    }
}