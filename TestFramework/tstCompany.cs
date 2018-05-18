using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Frame_Company
{
    [TestClass]
    public class tstCompany
    {
        [TestMethod]
        public void CompanyInstanceOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //check if it exists
            Assert.IsNotNull(ACompany);
        }

        [TestMethod]
        public void CompanyIDPropertyOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACompany.CompanyID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.CompanyID, TestData);
        }

        [TestMethod]
        public void CompanyNamePropertyOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to the property
            string TestData = "Audi";
            //assign the data to the property
            ACompany.CompanyName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.CompanyName, TestData);
        }

        [TestMethod]
        public void CompanyAddressPropertyOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to the property
            string TestData = "420 weed lane";
            //assign the data to the property
            ACompany.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.Address, TestData);

        }

        [TestMethod]
        public void CompanyPostCodePropertyOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to the property
            string TestData = "Le2 7et";
            //assign the data to the property
            ACompany.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.PostCode, TestData);

        }

        [TestMethod]
        public void CompanyTeleNumOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to the property
            string TestData = "123";
            //assign the data to the property
            ACompany.TeleNum = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.TeleNum, TestData);

        }

        [TestMethod]
        public void CompanyEmailOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to the property
            string TestData = "example@example.co.uk";
            //assign the data to the property
            ACompany.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.Email, TestData);

        }

        [TestMethod]
        public void CompanyDescriptionOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //create some test data to the property
            string TestData = "this is an example";
            //assign the data to the property
            ACompany.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACompany.Description, TestData);

        }

        [TestMethod]
        public void CompanyFindMethodOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCompanyIDFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.CompanyID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyNameFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.CompanyName != "Test Company")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyAddressFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.Address != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyPostCodeFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyTeleNumFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.TeleNum != "1234567890")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyEmailFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.Email != "Test@email.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyDescriptionFound()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CompanyID = 1;
            //invoke the method 
            Found = ACompany.Find(CompanyID);
            //check the CompanyID
            if (ACompany.Description != "Test some data")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyValidMethodOK()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyNameMinLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = ""; //should fail
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyNameNoMin()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "a"; //should pass
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyNameMinPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "aa"; //should pass
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyNameMid()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(25, 'a'); //should pass
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyNameMaxLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(49, 'a'); //should pass
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyNameMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(50, 'a'); //should pass
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyNameMaxPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(51, 'a'); //should fail
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyNameExtremeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(100, 'a'); //should fail
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        
        [TestMethod]
        public void CompanyAddressMinLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company"; 
            string Address = ""; //should fail
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyAddressNoMin()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "a"; //should pass
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyAddressMinPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "aa"; //should pass
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyAddressMid()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "";
            Address = Address.PadLeft(25, 'a'); //should pass
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyAddressMaxLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "";
            Address = Address.PadLeft(49, 'a'); //should pass
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyAddressMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "";
            Address = Address.PadLeft(50, 'a'); //should pass
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
  
        [TestMethod]
        public void CompanyAddressMaxPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "";
            Address = Address.PadLeft(51, 'a'); //should fail
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyAddressExtremeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "";
            Address = Address.PadLeft(100, 'a'); //should fail
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeMinLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road"; 
            string PostCode = ""; //should fail
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeNoMin()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road"; 
            string PostCode = "a"; //should pass
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeMinPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "aa"; //should pass
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeMid()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "";  //should pass
            PostCode = PostCode.PadLeft(4, 'a');
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeMaxLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "";
            PostCode = PostCode.PadLeft(7, 'a'); //should pass
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "";
            PostCode = PostCode.PadLeft(8, 'a'); //should pass
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeMaxPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "";
            Address = Address.PadLeft(9, 'a'); //should fail
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyPostCodeExtremeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "";
            Address = Address.PadLeft(20, 'a'); //should fail
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumMinLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL"; 
            string TeleNum = ""; //should fail
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumNoMin()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL"; 
            string TeleNum = "a"; //should pass
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumMinPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL"; 
            string TeleNum = "aa"; //should pass
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumMid()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";  
            string TeleNum = ""; //should pass
            TeleNum = TeleNum.PadLeft(6, 'a');
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumMaxLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = ""; //should pass
            TeleNum = TeleNum.PadLeft(10, 'a');
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = ""; //should pass
            TeleNum = TeleNum.PadLeft(11, 'a');
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumMaxPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = ""; //should fail
            TeleNum = TeleNum.PadLeft(12, 'a');
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyTeleNumExtremeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = ""; //should fail
            TeleNum = TeleNum.PadLeft(20, 'a');
            string Email = "SomeEmail@example.com";
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyEmailMinLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = ""; //should fail
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyEmailNoMin()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = "a"; //should pass
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyEmailMinPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = "aa"; //should pass
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyEmailMid()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = ""; //should pass
            Email = Email.PadLeft(25, 'a');
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyEmailMaxLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = ""; //should pass
            Email = Email.PadLeft(49, 'a');
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyEmailMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = ""; //should pass
            Email = Email.PadLeft(50, 'a');
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyEmailMaxPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = ""; //should fail
            Email = Email.PadLeft(51, 'a');
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyEmailExtremeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321"; 
            string Email = ""; //should fail
            Email = Email.PadLeft(100, 'a');
            string Description = "This is an example";
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionMinLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com"; 
            string Description = ""; //should fail
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionNoMin()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com"; 
            string Description = "a"; //should pass
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionMinPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = "aa"; //should pass
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionMid()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com"; 
            string Description = ""; //should pass
            Description = Description.PadLeft(25, 'a');
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionMaxLessOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com"; 
            string Description = ""; //should pass
            Description = Description.PadLeft(49, 'a');
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com"; 
            string Description = ""; //should pass
            Description = Description.PadLeft(50, 'a');
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionMaxPlusOne()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com"; 
            string Description = ""; //should fail
            Description = Description.PadLeft(51, 'a');
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CompanyDescriptionExtremeMax()
        {
            //create an instance of the class clsCompany
            clsCompany ACompany = new clsCompany();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to pass to the  method
            string CompanyName = "Some Company";
            string Address = "123 Some Road";
            string PostCode = "SY2 5QL";
            string TeleNum = "0987654321";
            string Email = "SomeEmail@example.com";
            string Description = ""; //should fail
            Description = Description.PadLeft(100, 'a');
            //invoke the method
            Ok = ACompany.Valid(CompanyName, Address, PostCode, TeleNum, Email, Description);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
    }
}
