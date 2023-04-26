using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection

    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer aCustomer = new clsCustomer();
                aCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailAlerts"]);
                aCustomer.CusAdress = Convert.ToString(DB.DataTable.Rows[Index]["CusAdress"]);
                aCustomer.CusEmail = Convert.ToString(DB.DataTable.Rows[Index]["CusEmail"]);
                aCustomer.CusPassword = Convert.ToString(DB.DataTable.Rows[Index]["CusPassword"]);
                aCustomer.CusUsername = Convert.ToString(DB.DataTable.Rows[Index]["CusUsername"]);
                aCustomer.CusId = Convert.ToInt32(DB.DataTable.Rows[Index]["CusId"]);
                mCustomerList.Add(aCustomer);
                Index++;
            }
        }
    }

}