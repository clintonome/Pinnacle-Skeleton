using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ClassLibrary
{
    public class clsCustomer
    {

        private Int32 mCusId;
        private string mCusUsername;
        private string mCusPassword;
        private string mCusEmail;
        private Boolean mActive;
        private DateTime mCusDOB;
        private String mCusAdress;

        //public bool Active { get; set; }
        //public string CusAdress { get; set; }
        //public string CusPassword { get; set; }
        //public string CusUsername { get; set; }
        //public string CusEmail { get; set; }
        //public DateTime CusDOB { get; set; }
        public Int32 CusId
        {
            get
            {
                return mCusId;
            }
            set
            {
                mCusId = value;
            }
        }

        public string CusUsername
        {
            get
            {
                return mCusUsername;
            }
            set
            {
                mCusUsername = value;
            }
        }

        public string CusEmail
        {
            get
            {
                return mCusEmail;
            }
            set
            {
                mCusEmail = value;
            }
        }

        public string CusPassword
        {
            get
            {
                return mCusPassword;
            }
            set
            {
                mCusPassword = value;
            }
        }

        public string CusAdress
        {
            get
            {
                return mCusAdress;
            }
            set
            {
                mCusAdress = value;
            }
        }

        public DateTime CusDOB
        {
            get
            {
                return mCusDOB;
            }
            set
            {
                mCusDOB = value;
            }
        }

        public bool Active
        {
            get
            {
                return mActive;

            }
            set
            {
                mActive = value;
            }
        }




        public bool Find(int cusId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", cusId);
            DB.Execute("sproc_tblOrder_FlterByCusId");
            if (DB.Count == 1)
            {


                mCusUsername = Convert.ToString(DB.DataTable.Rows[0]["CusUsername"]);
                mCusId = Convert.ToInt32(DB.DataTable.Rows[0]["CusId"]);
                mCusPassword = Convert.ToString(DB.DataTable.Rows[0]["CusPassword"]);
                mCusEmail = Convert.ToString(DB.DataTable.Rows[0]["CusEmail"]);
                mCusAdress = Convert.ToString(DB.DataTable.Rows[0]["CusAdress"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["EmailAlerts"]);
                mCusDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CusDOB"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string cusUsername, string cusPassword, string cusEmail, string cusAdress, string cusDOB)
        {
            String Error = "";
            //DateTime  DateTemp;
            if (cusUsername.Length == 0)
            { 
                Error = Error + "The Username must not be left blank";
            }
            if (cusUsername.Length > 51)

            {
                Error = Error + "The Username must not be greater than 50";
            }
            if (cusPassword.Length == 0)
            {
                Error = Error + "The password was left blank";
            }
            if (cusPassword.Length > 51)
            {
                Error = Error + " The password was too long";
            }
            if (cusEmail.Length == 0)
            {
                Error = Error + "The Email was left blank";
            }
            if (cusEmail.Length > 51)
            {
                Error = Error + " The password was too long";
            }
            try
            {

                DateTime DateTemp = Convert.ToDateTime(cusDOB);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date should Not be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date should Not be in the future";
                }

            }
            catch
            {
                Error = Error + "The Date added is invalid";
            }
            //return any error messege
            return Error;


            //return "";
        }
    }
}