using System;

namespace ClassLibrary
{
    public class clsStock
    {

        private bool mAvailability;
        public bool Availability
        {
            get
            {
                //out of property 
                return mAvailability;
            }
            set
            {
                //in property
                mAvailability = value;

            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //out of property 
                return mDateAdded;
            }
            set
            {
                //in property
                mDateAdded = value;

            }
        }
        private string mDescription;
        public string Description
        {
            get
            {
                //out of property 
                return mDescription;
            }
            set
            {
                //in property
                mDescription = value;

            }
        }
        private string mColour;

        public string Colour
        {
            get
            {
                //out of property 
                return mColour;
            }
            set
            {
                //in property
                mColour = value;

            }
        }
        private int mQuantity;
        public int Quantity
        {
            get
            {
                //out of property 
                return mQuantity;
            }
            set
            {
                //in property
                mQuantity = value;

            }
        }
        private double mPrice;
        public double Price
        {
            get
            {
                //out of property 
                return mPrice;
            }
            set
            {
                //in property
                mPrice = value;

            }
        }
        private Int32 mStockID;
        public Int32 StockID
        {
            get
            {
                //out of property 
                return mStockID;
            }
            set
            {
                //in property
                mStockID = value;

            }

        }


        public bool Find(int StockID)
        {
            //creates Instance
            clsDataConnection DB = new clsDataConnection();
            //adds parameter
            DB.AddParameter("@StockID", StockID);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");
            if (DB.Count == 1)
            {
                //sets private data members to test value
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);

                //Always True
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string description, string colour, string quantity, string price, string dateAdded)
        {
            String Error = "";
            //if Value is blank
            if (description.Length == 0)
            {
                Error = Error + "The Description should not be blank : ";
            }
            if (description.Length > 20)
            {
                Error = Error + "The Description should not be over 20 characters : ";
            }
            if (colour.Length == 0)
            {
                Error = Error + "The colour should not be blank : ";
            }
            if (colour.Length > 20)
            {
                Error = Error + "The colour should not be over 20 characters : ";
            }
            if (quantity.Length == 0)
            {
                Error = Error + "The colour should not be blank : ";
            }
            if (quantity.Length > 20)
            {
                Error = Error + "The colour should not be over 20 characters : ";
            }
            if (price.Length == 0)
            {
                Error = Error + "The colour should not be blank : ";
            }
            if (price.Length > 20)
            {
                Error = Error + "The colour should not be over 20 characters : ";
            }
            //return any error messege
            return Error;
        }
    }
}