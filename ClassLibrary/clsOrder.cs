using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private string sCustName;
        private Boolean sActive;
        private DateTime sDateAdded;
        private int sQuantity;
        private double sPrice;
        private string sShippingAddress;
        private Int32 sOrderID;

        public Int32 OrderID
        {
            get
            {
                return sOrderID;
            }
            set
            {
                sOrderID = value;
            }
        }
        public bool Active
        {
            get
            {
                return sActive;

            }
            set
            {
                sActive = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return sDateAdded;
            }
            set
            {
                sDateAdded = value;
            }
        }
        public int Quantity
        {
            get
            {
                return sQuantity;
            }
            set
            {
                sQuantity = value;
            }
        }
        public double Price
        {
            get
            {
                return sPrice;
            }
            set
            {
                sPrice = value;
            }
        }
        public string CustName
        {
            get
            {
                return sCustName;
            }
            set
            {

                sCustName = value;
            }
        }
        public string ShippingAddress
        {
            get
            {
                return sShippingAddress;
            }
            set
            {
                sShippingAddress = value;
            }
        }


        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FlterByOrderID");
            if (DB.Count == 1)
            {


                sCustName = Convert.ToString(DB.DataTable.Rows[0]["CustName"]);
                sOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                sActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                sDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                sQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                sPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                sShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string custname, string dateAdded, string shippingAddress,
                             string quantity, string price)
        {
            String Error = "";
            if (custname.Length == 0)
            {
                Error = Error + "The Customer name may not be blank : ";
            }
            if (custname.Length > 20)
            {
                Error = Error + "The Customer name must not be more than 20 : ";
            }
            if (shippingAddress.Length == 0)
            {
                Error = Error + "The Shipping Address must not be blank : ";
            }
            if (shippingAddress.Length > 9)
            {
                Error = Error + "The Shipping Address must not more than 9 : ";
            }

            return Error;
        }
    }
}