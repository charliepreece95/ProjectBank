using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff Property
        private Int32 mStaffNo;
        //private data member for the FirstName
        private string mFirstName;
        //prviate data member for the LastName
        private string mLastFirst;
        //private data member for the Email
        private string mEmail;
        //private data member for the Position
        private string mPosition;
        //private data member for the TeleNo
        private string mTeleNo;

        //public property for the StaffNo
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set the value of the private data member
                mStaffNo = value;
            }
        }

        //public property for the FirstName
        public string FirstName
        {
            get
            {
                //return the private data 
                return mFirstName;
            }
            set
            {
                //set the value of the prviate
                mFirstName = value;
            }
        }

        //public property for the last name
        public string LastName
        {
            get
            {
                //return the private data
                return mLastFirst;
            }
            set
            {
                //set the value of the private data member
                mLastFirst = value;
            }
        }

        //public property for the Email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the private data member
                mEmail = value;
            }
        }

        //public property for the Position
        public string Position
        {
            get
            {
                //return the private data
                return mPosition;
            }
            set
            {
                //set the value of the private data member
                mPosition = value;
            }
        }

        //public property for the TeleNo
        public string TeleNo
        {
            get
            {
                //return the private data
                return mTeleNo;
            }
            set
            {
                //set the value of the private data member
                mTeleNo = value;
            }
        }




        public bool Find(int StaffNo)
        {
            //crate an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the sotred proc
            DB.Execute("sproc_tblStaff_FiterByStaffNo");
            //if one record if found (There should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy from the db to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastFirst = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mTeleNo = Convert.ToString(DB.DataTable.Rows[0]["TeleNo"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
     

        }

        public bool Valid(string firstName, string lastName, string email, string position, string teleNo)
        {
            //create a boolean var to flag the error
            Boolean OK = true;
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the FirstName is greater than 20 chars
            if (firstName.Length > 20)
            {
                //set the flag to false
                OK = false;
            }
            if (lastName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the lastName is greater than 20 chars
            if (lastName.Length > 20)
            {
                //set the flag to false
                OK = false;
            }
            if (email.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the email is greater than 20 chars
            if (email.Length > 50)
            {
                //set the flag to false
                OK = false;
            }
            if (position.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the position is greater than 20 chars
            if (position.Length > 15)
            {
                //set the flag to false
                OK = false;
            }
            if (teleNo.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the FirstName is greater than 20 chars
            if (teleNo.Length > 15)
            {
                //set the flag to false
                OK = false;
            }
            //return the value of OK
            return OK;
        }
    }
}