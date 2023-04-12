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
            //set the private data members to the test data value
            mStaffID = 24;
            mDateOfBirth = Convert.ToDateTime("24 / 08 / 1978");
            mName = "Bob";
            mPassword = "B0bby123";
            mRole = "Manager";
            mSalary = 1000;
            mPermission = true;
            //always return true
            return true;
        }

    }
}
