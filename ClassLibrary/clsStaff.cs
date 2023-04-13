using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        private string mRole;
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }
        private Int32 mSalary;
        public Int32 Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        private bool mPermission;
        public bool Permission
        {
            get
            {
                return mPermission;
            }
            set
            {
                mPermission = value;
            }
        }
        public bool Find(int StaffID)
        {
            //Instance of Data Connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter to staff id to test data value
            DB.AddParameter("@StaffID", StaffID);
            //execute the store procedure
            DB.Execute("sproc_tblStaff_FilteredByStaffID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mPermission = Convert.ToBoolean(DB.DataTable.Rows[0]["Permission"]);
                //returns that everthing is ok
                return true;
            }
            else
            {
                //return false indicates problem
                return false;

            }
        }

    }
}
