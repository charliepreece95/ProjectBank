using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace AppointmentTestFramework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void StaffInstanceOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //test to see if it exsists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "NameHere";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "NameHere";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "EmailHere";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void StaffPositionPropertyOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "PositionHere";
            //assign the data to the property
            AStaff.Position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Position, TestData);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void StaffTeleNoPropertyOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "07969960008";
            //assign the data to the property
            AStaff.TeleNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.TeleNo, TestData);
        }

        [TestMethod]
        public void StaffFindMethodOK()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the validation
            Boolean Found = false;
            //crate some test data to store the result
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StaffTestStaffNoNotFound()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK (Assume it is)
            Boolean OK = true;
            //createw some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffNo != 21)
            {
                OK = false;
            }
            //test to se eif the results are correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTestFirstNameNotFound()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK (Assume it is)
            Boolean OK = true;
            //createw some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.FirstName != "Ashley")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTestLastNameNotFound()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK (Assume it is)
            Boolean OK = true;
            //createw some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.LastName != "Redman")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTestPositionNotFound()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK (Assume it is)
            Boolean OK = true;
            //createw some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Position != "Manager")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTestEmailNotFound()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK (Assume it is)
            Boolean OK = true;
            //createw some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Email != "example@domain.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTestTeleNoNotFound()
        {
            //crate an instance of the clsStaff class
            clsStaff AStaff = new clsStaff();
            //bool var to store the result of the search
            Boolean Found = false;
            //bool var to record if data is OK (Assume it is)
            Boolean OK = true;
            //createw some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.TeleNo != "01509263756")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void StaffTestValidMethodOK()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        // TEST PLAN tests
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = ""; //this will trigger an error
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "a"; //this should test as OK
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "aa"; //this should test as OK
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "aaaaaaaaaaaaaaaaaaaa"; //this should test as OK (19 chars)
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "aaaaaaaaaaaaaaaaaaaa"; //this should test as OK (20 chars)
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "aaaaaaaaaa"; //this should test as OK
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa"; //this should test as OK (21 chars)
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); // this should fail (500 chars)
            string LastName = "Redman";
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        //
        //these tests are for the LastName property
        //
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley"; 
            string LastName = ""; //this will trigger an error
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "aa"; //this should pass
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMin()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "a"; //this will pass
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMid()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "aaaaaaaaaa"; //this will pass (10 chars)
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "aaaaaaaaaaaaaaaaaaaaa"; //this will trigger an error
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "aaaaaaaaaaaaaaaaaaa"; //this will pass (19 chars)
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "aaaaaaaaaaaaaaaaaaaa"; //this will pass (20 chars)
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void LastNameExtremeMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "";
            LastName = LastName.PadRight(500, 'a'); // this should fail (500 chars)
            string Email = "example@example.com";
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        //
        //this is for the Email property test
        //
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "a";//this will pass 
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "";//this will fail
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMin()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "a";//this will pass
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMid()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "aaaaaaaaaa";//this will pass
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "";
            Email = Email = Email.PadRight(50, 'a');
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "aaaaaaaaaaaaaaaaaaa";//this will pass (19 chars)
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "";
            Email = Email.PadRight(51, 'a');
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "";
            Email = Email.PadRight(500, 'a'); // pad the string with 500 a chars
            string Position = "Manager";
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PositionMin()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "M"; //this will pass 1 char
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PositionMinLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = ""; //this will fail no chars
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "aa"; //this will pass 2 chars
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PositionMid()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "aaaaaaa"; //this will pass 7 chars
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PositionMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "aaaaaaaaaaaaaaa"; //this will pass 15 chars
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "aaaaaaaaaaaaaa"; //this will pass 14 chars
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "aaaaaaaaaaaaaaaa"; //this will fail 16 chars
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PositionExtremeMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "";
            Position = Position.PadRight(500, 'a');// pad the string with 500 chars of a
            string TeleNo = "01509263756";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        //
        //these tests are for the teleNo property
        //
        [TestMethod]
        public void TeleNoMin()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "0";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TeleNoMinPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "00";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TeleNoMinLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TeleNoMid()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "0000000";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TeleNoMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "000000000000000";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TeleNoMaxLessOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "00000000000000";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TeleNoMaxPlusOne()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "0000000000000000"; //(16 chars)
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TeleNoExtremeMax()
        {
            //crate an instance of clsSTaff
            clsStaff AStaff = new clsStaff();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string FirstName = "Ashley";
            string LastName = "Redman";
            string Email = "example@domain.com";
            string Position = "Manager";
            string TeleNo = "";
            TeleNo = TeleNo.PadRight(500, 'a');//padd the string with 500 chars
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, Email, Position, TeleNo);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


    }
}
