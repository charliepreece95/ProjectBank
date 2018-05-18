using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsAppointments
    {
        //private data member for the AppointmentNo property
        private Int32 mAppointmentNo;
        //private data member for the AppointmentTitle property
        private string mAppointmentTitle;
        //private data member for the BookingDate property
        private DateTime mBookingDate;
        //private data member for the ClientNo property
        private Int32 mClientNo;
        //private data member for the Location property
        private string mLocation;
        //private data member for StaffNo property
        private Int32 mStaffNo;
        //private data member for Status property
        private string mStatus;

        //public property for appointmentNo
        public int AppointmentNo
        {
            get
            {
                //return the private data
                return mAppointmentNo;
            }
            set
            {
                //ste the value of the private data member
                mAppointmentNo = value;
            }
        }

        //public property for appointmentTitle
        public string AppointmentTitle
        {
            get
            {
                //return the private data
                return mAppointmentTitle;
            }
            set
            {
                //set the value of the private data member
                mAppointmentTitle = value;
            }
        }


        //public property for the BookingDate
        public DateTime BookingDate
        {
            get
            {
                //return the private data
                return mBookingDate;
            }
            set
            {
                //set the value of the private data member
                mBookingDate = value;
            }
        }
        
        //public property for the ClientNo
        public int ClientNo
        {
            get
            {
                //return the private data 
                return mClientNo;
            }
            set
            {
                //set the value of the private data member
                mClientNo = value;
            }
        }

        //publc property for the location
        public string Location
        {
            get
            {
                //return the private data
                return mLocation;
            }
            set
            {
                //set the private data
                mLocation = value;
            }
        }

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
                //set the private data
                mStaffNo = value;
            }
        } 

        public string Status
        {
            get
            {
                //return the private data
                return mStatus;
            }
            set
            { 
                //set the private data
                mStatus = value;
            }
        }

        //Find method
        public bool Find(int AppointmentNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the appointment No to search for
            DB.AddParameter("@AppointmentNo", AppointmentNo);
            //execture the stored procedure
            DB.Execute("sproc_tblAppointment_FilterByAppointmentNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the dat from the database to the private data members
                mAppointmentNo = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentNo"]);
                mAppointmentTitle = Convert.ToString(DB.DataTable.Rows[0]["AppointmentTitle"]);
                mClientNo = Convert.ToInt32(DB.DataTable.Rows[0]["ClientNo"]);
                mLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public bool Valid(string AppointmentTitle, string BookingDate, string ClientNo, string Location, string StaffNo, string Status)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temp variable to store date values
            DateTime DateTemp;
            //if the appointmentTitle is blank
            if (AppointmentTitle.Length == 0)
            {
                //set the flag OK to flase
                OK = false;
            }
            //if appointmentTitle is greater than 50 characters
            if (AppointmentTitle.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //try the date validation assuming the data is a valid data
            try
            {
                //copy the bookingdate value to the datetemp variable
                DateTemp = Convert.ToDateTime(BookingDate);
                //check to see if the date is less than todays date
                if (DateTemp <= DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date +1 (cant book an appointment on that day has to atleast be a day in advance)
                if (DateTemp > DateTime.Now.Date.AddYears(2))
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //if the AppointmentTitle is blank
            if (AppointmentTitle.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the APpointment Title is too long
            if (AppointmentTitle.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the ClientNo is blank
            if (ClientNo.Length == 0)
            {
                //set the flag to false
                OK = false;
            }
            //if the StaffNo is blank
            if (StaffNo.Length == 0)
            {
                //set the flag to false
                OK = false;
            }
            //if the location blank
            if (Location.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the location is too long
            if (Location.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the status is blank
            if (Status.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Status is too long
            if (Status.Length > 20)
            {
                //set the flag OK to false
                OK = false;
            }

            //return the value of OK
            return OK;
        }
    }
}