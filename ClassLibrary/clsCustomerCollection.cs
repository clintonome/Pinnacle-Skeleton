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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
           
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CusUsername", mThisCustomer.CusUsername);
            DB.AddParameter("@CusPassword", mThisCustomer.CusPassword);
            DB.AddParameter("@CusAdress", mThisCustomer.CusAdress);
            DB.AddParameter("@CusEmail", mThisCustomer.CusEmail);
            DB.AddParameter("@CusDOB", mThisCustomer.CusDOB);
            DB.AddParameter("@EmailAlerts", mThisCustomer.Active);
           
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CusUsername", mThisCustomer.CusUsername);
            DB.AddParameter("@CusPassword", mThisCustomer.CusPassword);
            DB.AddParameter("@CusAdress", mThisCustomer.CusAdress);
            DB.AddParameter("@CusEmail", mThisCustomer.CusEmail);
            DB.AddParameter("@CusDOB", mThisCustomer.CusDOB);
            DB.AddParameter("@EmailAlerts", mThisCustomer.Active);
            DB.AddParameter("@CusId", mThisCustomer.CusId);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CusId", mThisCustomer.CusId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByUsername(string CusUsername)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CusUsername", CusUsername);
            DB.Execute("sproc_tblCustomer_FilterByCusUsername");
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer aCustomer = new clsCustomer();
                aCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailAlerts"]);
                aCustomer.CusAdress = Convert.ToString(DB.DataTable.Rows[Index]["CusAdress"]);
                aCustomer.CusEmail = Convert.ToString(DB.DataTable.Rows[Index]["CusEmail"]);
                aCustomer.CusPassword = Convert.ToString(DB.DataTable.Rows[Index]["CusPassword"]);
                aCustomer.CusUsername = Convert.ToString(DB.DataTable.Rows[Index]["CusUsername"]);
                aCustomer.CusId = Convert.ToInt32(DB.DataTable.Rows[Index]["CusId"]);
                aCustomer.CusDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CusDOB"]);

            }
        }
    }

}