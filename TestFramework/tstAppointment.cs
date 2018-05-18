using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace AppointmentTestFramework
{
    [TestClass]
    public class tstAppointment
    {
        [TestMethod]
        public void AppointmentInstanceOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //test to see that it exists
            Assert.IsNotNull(AnAppointment);
        }

        [TestMethod]
        public void AppointmentTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "Website";
            //assign the data to the property
            AnAppointment.AppointmentTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.AppointmentTitle, TestData);
        }

        [TestMethod]
        public void AppointmentNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.AppointmentNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.AppointmentNo, TestData);
        }

        [TestMethod]
        public void AppointmentBookingDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAppointment.BookingDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.BookingDate, TestData);
        }

        [TestMethod]
        public void AppointmentClientNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.ClientNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.ClientNo, TestData);
        }

        [TestMethod]
        public void AppointmentLocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "LondonOffice";
            //assign the data to the property
            AnAppointment.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.Location, TestData);
        }

        [TestMethod]
        public void AppointmentStaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.StaffNo, TestData);
        }

        [TestMethod]
        public void AppointmentStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "Pending";
            //assign the data to the property
            AnAppointment.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.Status, TestData);
        }



        //testing for the find method
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAppointmentNoFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the appointment no
            if (AnAppointment.AppointmentNo !=1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentTitleFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the appointment title
            if (AnAppointment.AppointmentTitle != "Website")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

       [TestMethod]
        public void TestBookingDateFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the property
            if (AnAppointment.BookingDate !=Convert.ToDateTime("10/02/2017"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        

        [TestMethod]
        public void TestAppointmentClientNoFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the appointment title
            if (AnAppointment.ClientNo != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the appointment title
            if (AnAppointment.Location != "Birmingham")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentStaffNoFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the appointment title
            if (AnAppointment.StaffNo != 7)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to pass to the method
            Int32 AppointmentNo = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNo);
            //check the appointment title
            if (AnAppointment.Status != "Pending")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //testing for the valid method
        [TestMethod]
        public void AppointmentValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "LondonOffice";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke the method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        //This sections conducts a series of tests for a single parameter, starting with AppointmentTitle
        //APPOINTMENT TITLE

        [TestMethod]
        public void AppointmentTitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = ""; //this should trigger an error
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentTitleMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "a"; //this should be ok
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "aa"; //this should be ok
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentTitleMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop"; //this should be ok (50 characters) VARCHAR50
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentTitleMid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "qwertyuiopqwertyuiopqwert"; //this should be ok (25 characters) VARCHAR50
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopq"; //this should fail (51 characters) VARCHAR50
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void AppointmentTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "";
            AppointmentTitle.PadRight(500, 'a'); //this should fail (500 characters) VARCHAR50
            string BookingDate = DateTime.Now.Date.ToString();
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        //the following tests are for the BookingDate parameter
        //BOOKINGDATE

        [TestMethod]
        public void BookingDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //crate a variable to srtore the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BookingDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //crate a variable to srtore the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BookingDateMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //crate a variable to srtore the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date; //min will be todays date plus 1
            //change the date to whatever the day is plus 1
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookingDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //crate a variable to srtore the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddDays(2); //min plus 1 will be todays date +2
            //change the date to whatever the day is plus 2
            //TestDate = TestDate.AddDays(2);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookingDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //crate a variable to srtore the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the day is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BookingDateInvalidData()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "Pending";
            //set the DateAdded to a non date value
            string BookingDate = "this is not a date";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        //the following tests are for the ClientNo parameter
        //CLIENTNO

        [TestMethod]
        public void ClientNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "";
            string Location = "";
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = "17/03/2017";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ClientNoMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "a";
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        //the following tests are for the Location parameter
        //LOCATION

        [TestMethod]
        public void LocationMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "";
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = "17/03/2017";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LocationMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "a";
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LocationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "aa";
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LocationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuio"; //varchar 50 so 49 characters
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LocationMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop"; //varchar 50 so 50 characters
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LocationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopq"; //varchar 50 so 51 characters
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = "17/03/2017";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void LocationMid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "qwertyuiopqwertyuiopqwert"; //varchar 50 so 25 characters
            string StaffNo = "1";
            string Status = "Pending";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        //the following tests are for the Status parameter
        //STATUS 

        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "";
            string BookingDate = "17/03/2017";
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void StatusMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "a";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "aa";
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "qwertyuiopqwertyuio"; //VARCHAR(20) so 19 characters
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StatusMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "qwertyuiopqwertyuiop"; //VARCHAR(20) so 20 characters
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "qwertyuiopqwertyuiopq"; //VARCHAR(20) so 21 characters
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentTitle = "Website";
            string ClientNo = "1";
            string Location = "Birmingham";
            string StaffNo = "1";
            string Status = "qwertyuiop"; //VARCHAR(20) so 10 characters
            string BookingDate = Convert.ToString(DateTime.Now.Date);
            //invoke this method
            OK = AnAppointment.Valid(AppointmentTitle, BookingDate, ClientNo, Location, StaffNo, Status);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}

    

