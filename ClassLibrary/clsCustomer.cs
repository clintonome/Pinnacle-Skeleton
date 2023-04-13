using System;

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
            CusId = 21;
            return true;
        }
    }
}