using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsClientCollection
    {
        //private data member for the list 
        List<clsClient> mClientList = new List<clsClient>();
        //private data member thisClient
        clsClient mThisClient = new clsClient();


        //public property for the Client list
        public List<clsClient> ClientList
        {
            get
            {
                //return the private data 
                return mClientList;
            }
            set
            {
                //set the private data 
                mClientList = value;
            }
        }

        //publuc property for Count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mClientList.Count;
            }
            set
            {
                //Add code later 
            }
        }

        //constructore for the class
        //public clsClientCollection()
        //{
        //create the items of test data 
        //clsClient TestItem = new clsClient();
        //set its properties 
        //TestItem.ClientNo = 1;
        //TestItem.ClientFirstName = "Lennis";
        //TestItem.ClientLastName = "Ngugi";
        //TestItem.ClientEmail = "lennisngugi@companyname.com";
        //TestItem.ClientPosition = "Human Resource";
        //TestItem.ClientTelephone = "0723456789";
        //TestItem.ClientFaxNumber = "0234567891";
        //add the item to the test list
        //mClientList.Add(TestItem);
        //re initialise the object for some new data 
        //TestItem = new clsClient();
        //set its properties
        //TestItem.ClientNo = 2;
        //TestItem.ClientFirstName = "Luigi";
        //TestItem.ClientLastName = "Lennis";
        //TestItem.ClientEmail = "luigilennis@companyname.com";
        //TestItem.ClientPosition = "Human Resource";
        //TestItem.ClientPosition = "0733456789";
        //TestItem.ClientFaxNumber = "0264567891";
        //add the item to the test list
        //mClientList.Add(TestItem);
        //}

        //constructor for the class
        public clsClientCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblClient_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Client 
                clsClient AClient = new clsClient();
                //read in the fields from the current records
                AClient.ClientNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ClientNo"]);
                AClient.CompanyNo = Convert.ToString(DB.DataTable.Rows[Index]["CompanyNo"]);
                AClient.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AClient.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AClient.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AClient.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AClient.TelephoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["Telephone"]);
                AClient.FaxNumber = Convert.ToString(DB.DataTable.Rows[Index]["FaxNumber"]);
                //add the record to the private data memeber 
                mClientList.Add(AClient);
                //point at the next record 
                Index++;
            }
        }
        public clsClient ThisClient
        {
            get
            {
                //return the private data
                return mThisClient;
                //
            }
            set
            {
                //set the private data
                mThisClient = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            //DB.AddParameter("@ClientNo", mThisClient.ClientNo);
            DB.AddParameter("@CompanyNo", mThisClient.CompanyNo);
            DB.AddParameter("@FirstName", mThisClient.FirstName);
            DB.AddParameter("@LastName", mThisClient.LastName);
            DB.AddParameter("@Email", mThisClient.Email);
            DB.AddParameter("@FaxNumber", mThisClient.FaxNumber);
            DB.AddParameter("@TelephoneNumber", mThisClient.TelephoneNumber);
            DB.AddParameter("@Position", mThisClient.Position);
            //execute the query returning the PK balue
            return DB.Execute("sproc_tblClient_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisStaff
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            DB.AddParameter("@ClientNo", mThisClient.ClientNo);
            //execute the stored proc
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
}