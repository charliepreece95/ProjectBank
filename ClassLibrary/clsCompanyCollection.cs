using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCompanyCollection
    {

        //private data member for the list
        List<clsCompany> mCompanyList = new List<clsCompany>();
        //private data member thisCompany
        clsCompany mThisCompany = new clsCompany();


        //public property for the company list
        public List<clsCompany> CompanyList
        {
            get
            {
                //return the private data
                return mCompanyList;
            }
            set
            {
                //set the private data 
                mCompanyList = value;
            }

        }

        //public property for count
        public int Count
        {
            get
            {
                //return the list of companies
                return mCompanyList.Count;
            }
            set
            {
                //worry about it later
            }
        }

        public clsCompany ThisCompany
        {
            get
            {
                //return the private data
                return mThisCompany;
            }
            set
            {
                //set the private data
                mThisCompany = value;
            }
        }


        public clsCompanyCollection()
        {
            //var for the index 
            var Index = 0;
            //var to store the record count 
            var RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCompany_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank company 
                clsCompany AnCompany = new clsCompany();
                //read in the fields from the current record
                AnCompany.CompanyID = Convert.ToInt32(DB.DataTable.Rows[Index]["CompanyID"]);
                AnCompany.CompanyName = Convert.ToString(DB.DataTable.Rows[Index]["CompanyName"]);
                AnCompany.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCompany.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCompany.TeleNum = Convert.ToString(DB.DataTable.Rows[Index]["TeleNum"]);
                AnCompany.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCompany.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                //add the record to the private data member 
                mCompanyList.Add(AnCompany);
                //point at the next record 
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            DB.AddParameter("@CompanyName", mThisCompany.CompanyName);
            DB.AddParameter("@Address", mThisCompany.Address);
            DB.AddParameter("@PostCode", mThisCompany.PostCode);
            DB.AddParameter("@TeleNum", mThisCompany.TeleNum);
            DB.AddParameter("@Email", mThisCompany.Email);
            DB.AddParameter("@Description", mThisCompany.Description);
            //execute the query returning the PK balue
            return DB.Execute("sproc_tblCompany_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisCompany
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            DB.AddParameter("@CompanyID", mThisCompany.CompanyID);
            //execute the stored proc
            DB.Execute("sproc_tblCompany_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCompany
            //connect to the database
            clsDataConnection db = new clsDataConnection();
            //set the parameters for the stored procedure
            db.AddParameter("@CompanyID", mThisCompany.CompanyID);
            db.AddParameter("@CompanyName", mThisCompany.CompanyName);
            db.AddParameter("@Address", mThisCompany.Address);
            db.AddParameter("@PostCode", mThisCompany.PostCode);
            db.AddParameter("@TeleNum", mThisCompany.TeleNum);
            db.AddParameter("@Email", mThisCompany.Email);
            db.AddParameter("@Description", mThisCompany.Description);
            //execute the stored procedure
            db.Execute("sproc_tblCompany_Update");
        }
    }
}
