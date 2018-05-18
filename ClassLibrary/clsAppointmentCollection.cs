using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAppointmentCollection
    {
        //private data member for th elis
        List<clsAppointments> nAppointmentList = new List<clsAppointments>();
        //private data member this staff
        clsAppointments mThisAppointment = new clsAppointments();

        //Constructor for the class
        public clsAppointmentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execture the stored procedure
            DB.Execute("sproc_tblAppointment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank appointment
                clsAppointments AnAppointment = new clsAppointments();
                //read in the fields from the current record
                AnAppointment.AppointmentNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentNo"]);
                AnAppointment.AppointmentTitle = Convert.ToString(DB.DataTable.Rows[Index]["AppointmentTitle"]);
                AnAppointment.ClientNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ClientNo"]);
                AnAppointment.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AnAppointment.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnAppointment.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnAppointment.BookingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BookingDate"]);
                //add the record to the private data member
                mAppointmentList.Add(AnAppointment);
                //point at the next record
                Index++;
            }
        }

        //private data member for the list
        List<clsAppointments> mAppointmentList = new List<clsAppointments>();


        //public property for the appointment list
        public List<clsAppointments> AppointmentList
        {
            get
            {
                //return the private data
                return mAppointmentList;
            }
            set
            {
                //set the private data
                mAppointmentList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mAppointmentList.Count;
            }
            set
            {
                //We shall worry about this later
            }
        }
        public clsAppointments ThisAppointment
        {
            get
            {
                //return the private data
                return mThisAppointment;
            }
            set
            {
                //set the private data
                mThisAppointment = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            //DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@AppointmentTitle", mThisAppointment.AppointmentTitle);
            DB.AddParameter("@BookingDate", mThisAppointment.BookingDate);
            DB.AddParameter("@ClientNo", mThisAppointment.ClientNo);
            DB.AddParameter("@Location", mThisAppointment.Location);
            DB.AddParameter("@StaffNo", mThisAppointment.StaffNo);
            DB.AddParameter("@Status", mThisAppointment.Status);
            //execute the query returning the PK balue
            return DB.Execute("sproc_tblAppointment_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisAppointment
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            DB.AddParameter("@AppointmentNo", mThisAppointment.AppointmentNo);
            //execute the stored proc
            DB.Execute("sproc_tblAppointment_Delete");
        }
    }
}