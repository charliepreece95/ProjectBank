using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCompany
    {
        private Int32 mCompanyID;
        private string mCompanyName;
        private string mAddress;
        private string mPostCode;
        private string mTeleNum;
        private string mEmail;
        private string mDescription;

        public int CompanyID
        {
            get
            {
                //return the private data
                return mCompanyID;
            }
            set
            {
                //set the value of the private data member
                mCompanyID = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return mCompanyName;
            }
            set
            {
                mCompanyName = value;
            }
        }


        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }


        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        
        public string TeleNum
        {
            get
            {
                return mTeleNum;
            }
            set
            {
                mTeleNum = value;
            }
        }

        
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
       
        public bool Find(int CompanyID)
        {
            //create m instmce of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CompanyID to search for
            DB.AddParameter("@CompanyID", CompanyID);
            //execute the stored procedure
            DB.Execute("sproc_tblCompany_FilterByCompanyID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mCompanyID = Convert.ToInt32(DB.DataTable.Rows[0]["CompanyID"]);
                mCompanyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mTeleNum = Convert.ToString(DB.DataTable.Rows[0]["TeleNum"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem 
                return false;
            }
          
        }

        public bool Valid(string CompanyName, string Address, string PostCode, string TeleNum, string Email, string Description)
        {
            //create a boolean variable to flag an error
            Boolean OK = true;
            //if the CompanyName is blank
            if (CompanyName.Length < 1)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the CompanyName has 51 characters
            if (CompanyName.Length > 50)
            { 
                //set the flag OK to false
                OK = false;
            }

            //if the Address is blank
            if (Address.Length <= 0 )
            {
                 //set the flag OK to false
                 OK = false;
            }

            //if the Address has 51 characters
            if (Address.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the PostCode is blank
            if (PostCode.Length < 1)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the PostCode has 9 characters
            if (PostCode.Length > 8)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the TeleNum is blank
            if (TeleNum.Length < 1)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the TeleNum has 11 characters
            if (TeleNum.Length > 11)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the Email is blank
            if (Email.Length <= 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the Email has 51 characters
            if (Email.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the Description is blank
            if (Description.Length < 1)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the Description has 51 characters
            if (Description.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //return the value of OK
            return OK;              
        }
    }
}