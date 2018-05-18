using System;

namespace ClassLibrary
{
    public class clsClient
    {
        //private data member for ClientNo
        private Int32 cclientNo;
        //private data Member for CompanyNo
        private string ccompanyNo;
        //Private data member for ClientEmail
        private string cclientEmail;

        //Private data member for ClientFirstName
        private string cclientFirstName;
        //private data member for ClientLastName
        private string cclientLastName;
        //private data member for ClientPosition
        private string cclientPosition;
        //private data member for ClientTelephone
        private string cclientTelephone;
        //Private data member for ClientFaxNumber
        private string cclientFaxNumber;

        //public property for ClientNo
        public Int32 ClientNo
        {
            get
            {
                //return the private data 
                return cclientNo;
            }
            set
            {
                //set the value of the private data member 
                cclientNo = value;
            }
        }

        //public property for CompanyNo
        public string CompanyNo
        {
            get
            {
                //return the private data 
                return ccompanyNo;
            }
            set
            {
                //set the value of the private data member 
                ccompanyNo = value;
            }
        }


        //public property for the ClientEmail
        public string Email
        {
            get
            {
                //return the private data 
                return cclientEmail;
            }
            set
            {
                //set the value of the private data member 
                cclientEmail = value;
            }
        }
        //public property for ClientFaxNumber
        public string FaxNumber
        {
            get
            {
                //return the private data
                return cclientFaxNumber;
            }
            set
            {
                //set the value of the private data member
                cclientFaxNumber = value;
            }
        }
        //public property for ClientFirstName
        public string FirstName
        {
            get
            {
                //return the private data
                return cclientFirstName;
            }
            set
            {
                //set the value of the private data member
                cclientFirstName = value;
            }
        }

        //public property for ClientLastName   
        public string LastName
        {
            get
            {
                //return the private data 
                return cclientLastName;
            }
            set
            {
                //set the value of the private data member
                cclientLastName = value;
            }
        }

        //Public property for Client Postion 
        public string Position
        {
            get
            {
                //return the private data 
                return cclientPosition;
            }
            set
            {
                //set the value of the private data 
                cclientPosition = value;
            }
        }

        //public property for ClientTelephone 
        public string TelephoneNumber
        {
            get
            {
                //return the private data 
                return cclientTelephone;
            }
            set
            {
                //set the value of the private 
                cclientTelephone = value;
            }
        }

        public bool Valid(string Client)
        {
            Boolean Ok = true;
            //test to see if client has 0 chars
            if (Client.Length == 0)
            {
                //
                Ok = false;
            }
            //test to see if client has more than 50 chars
            if (Client.Length > 50)
            {
                Ok = false;
            }
            //return 
            return Ok;
        }


        //  public bool Find(int clientNo)
        //  {
        //   AclientNo = 1;
        // AclientEmail = "lennisngugi@companyname.com";
        // AclientFaxNumber = 0234567891;
        // AclientFirstName = "Lennis";
        // AclientLastName = "Ngugi";
        // AclientPosition = "Human Resource";
        //  AclientTelephone = 0123456789;
        // always return true
        // return true;
        //    }

        public bool Find(int ClientNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for 
            DB.AddParameter("@ClientNo", ClientNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblClient_filterByClientID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                ClientNo = Convert.ToInt32(DB.DataTable.Rows[0]["ClientNo"]);
                FirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                LastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                Position = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                TelephoneNumber = Convert.ToString(DB.DataTable.Rows[0]["Telephone"]);
                FaxNumber = Convert.ToString(DB.DataTable.Rows[0]["FaxNumber"]);
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

        public bool Valid(string firstName, string lastName, string email, string position, long telephone, long faxNumber)
        {
            return true;
        }

        public bool Valid(string companyNo, string firstName, string lastName, string email, string position, string telephone, string faxNumber)
        {
            //create a Boolean variable to flag the error 
            Boolean OK = true;
            //if the CompanyNo is blank 
            if (companyNo.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the CompanyNo is greater than 6 characters
            if (companyNo.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the First Name is blank 
            if (firstName.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the First Name is greater than 50 characters 
            if (firstName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Last Name is blank 
            if (lastName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Last Name is greater than 50 characters
            if (lastName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the email address is blank 
            if (email.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the email is greater than 80 characters
            if (email.Length > 80)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the position is blank 
            if (position.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the position is greater than 75 characters
            if (position.Length > 75)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Telephone is blank
            if (telephone.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Telephone is greater than 15 characters
            if (telephone.Length > 15)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Faxnumber is blank 
            if (faxNumber.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the faxnumber if greater than 15 characters
            if (faxNumber.Length > 15)
            {
                //set the flag OK to false 
                OK = false;
            }

            //return the value of OK 

            return OK;
        }
    }
}
