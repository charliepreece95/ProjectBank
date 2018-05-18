using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> nStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();


        //constructor for the class
        public clsStaffCollection()
        {
        //var for the index
        Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proc
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create class Staffmember
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AStaff.TeleNo = Convert.ToString(DB.DataTable.Rows[Index]["TeleNo"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the record
                Index++;
            }
        }



        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                //return the priovate data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            //DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@Firstname", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@TeleNo", mThisStaff.TeleNo);
            //execute the query returning the PK balue
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisStaff
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored proc
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
}