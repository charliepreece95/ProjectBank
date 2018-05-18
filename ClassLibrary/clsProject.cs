using System;

namespace ClassLibrary
{
    public class clsProject
    {
        private int mAProjectID;
        private int mAppointmentID;
        private string mAProjectDescription;
        private int mStaffID;
        private string mProjectName;
        private DateTime mEstimatedCompletionDate;
        private int mClientID;

        public string AProjectDescription
        {
            get
            {
                return mAProjectDescription;
            }

            set
            {
                mAProjectDescription = value;
            }
        }

        public int AProjectID
        {
            get
            {
                //return the private data
                return mAProjectID;
            }

            set
            {
                //set the value of the private
                mAProjectID = value;
            }
        }

        public int ClientID
        {
            get
            {
                //return the private data
                return mClientID;
            }

            set
            {
                //set the value of the private
                mClientID = value;
            }
        }
        public DateTime EstimatedCompletionDate
        {
            get
            {
                //return the private data
                return mEstimatedCompletionDate;
            }

            set
            {
                //set the value of the private
                mEstimatedCompletionDate = value;
            }
        }

        public string ProjectName
        {
            get
            {
                //return the private data
                return mProjectName;
            }

            set
            {
                //set the value of the private
                mProjectName = value;
            }
        }

        public int StaffID
        {
            get
            {
                //return the private data
                return mStaffID;
            }

            set
            {
                //set the value of the private
                mStaffID = value;
            }
        }

        public int AppointmentID
        {
            get
            {
                //return the private data
                return mAppointmentID;
            }

            set
            {
                //set the value of the private
                mAppointmentID = value;
            }
        }

        public bool Find(int ProjectID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the ProjectID to search for
            DB.AddParameter("@ProjectID", ProjectID);
            //execute the stored Procedure
            DB.Execute("sproc_tblProject_filterbyProjectID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mAProjectID = Convert.ToInt32(DB.DataTable.Rows[0]["ProjectID"]);
                mAppointmentID = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentID"]);
                mAProjectDescription = Convert.ToString(DB.DataTable.Rows[0]["ProjectDescription"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mProjectName = Convert.ToString(DB.DataTable.Rows[0]["ProjectName"]);
                mEstimatedCompletionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EstimatedCompletionDate"]);
                mClientID = Convert.ToInt32(DB.DataTable.Rows[0]["ClientID"]);
                return true;
            }
            //if no record was found 
            else
            {
                return false;
            }
        }

        public bool Valid(string ProjectName, string ProjectDescription, string EstimatedCompletionDate)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //If the ProjectName is blank
            if (ProjectName.Length == 0)
            {
                OK = false;
            }
            if (ProjectName.Length > 50)
            {
                OK = false;
            }

            //try the date validation asumming the data is a valid date
            try
            {
                //copy the EstimatedCompletionDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(EstimatedCompletionDate);
                //check to see if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a fate so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }

            //is the ProjectDescription false
            if (ProjectDescription.Length == 0)
            {
                OK = false;
            }
            if (ProjectDescription.Length > 50)
            {
                OK = false;
            }
            //is the EstimatedCompletionDate blank
            if (EstimatedCompletionDate.Length == 0)
            {
                OK = false;
            }
            if (EstimatedCompletionDate.Length > 50)
            {
                OK = false;
            }
            return OK;
        }
    }
}