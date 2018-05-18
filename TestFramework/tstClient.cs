using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClientsTest
{
    [TestClass]
    public class tstClient
    {
        [TestMethod]
        public void ClientInstanceOk()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //test to see what exist 
            Assert.IsNotNull(Aclient);
        }


        [TestMethod]
        public void ClientFirstNamePropertyOK()
        {
            //create an instance of the class
            clsClient AClient = new clsClient();
            //create a variable to store the name of the client 
            String FirstName;
            //Assign a client to variable 
            FirstName = "Lennis";
            //try to send some data to the variable and property are the same 
            AClient.FirstName = FirstName;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AClient.FirstName, FirstName);

        }

        [TestMethod]
        public void ClientFirstNameMax()
        {
            //create an instance of the class
            clsClient AClient = new clsClient();
            //create a variable to record the result of the validation test
            Boolean OK;
            //50 characters entry
            string SomeText = "LennisLennisLennisLennisLennisLennisLenLennisLennis";
            //test the valid method with a blank string
            OK = AClient.Valid("");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void ClientFirstNameMinLessOne()
        {
            //create an instance of the class
            clsClient AClient = new clsClient();
            //create a variable to record the result of the validation test
            Boolean OK;
            //49 characters entry
            string SomeText = "LennisLennisLennisLennisLennisLennisLenLennisLennisL";
            //test the valid method with a blank string
            OK = AClient.Valid("");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ClientFirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //create a variable to record 
            Boolean Ok;
            //51 characters entry
            string SomeText = "LennisLennisLennisLennisLennisLennisLenLennisLennisLen";
            //Test the valid method with a two character string 
            Ok = Aclient.Valid(SomeText);
            //Assert that the outcome should be true 
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ClientFirstNameMid()
        {
            //create an instaqnce of the class we want to create 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = " ";
            FirstName = FirstName.PadRight(15, 'a');
            string LastName = "Ngugi";
            string Email = "lennisngugi@companyname.com";
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientFirstExtremeMax()
        {
            //create an instaqnce of the class we want to create 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = " ";
            FirstName = FirstName.PadRight(54, 'a');
            string LastName = "Ngugi";
            string Email = "lennisngugi@companyname.com";
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ClientLastNamePropertyOK()
        {
            //create an instance of the class
            clsClient AClient = new clsClient();
            //create a variable to store the name of the client 
            String LastName;
            //Assign a client to variable 
            LastName = "Ngugi";
            //try to send some data to the variable and property are the same 
            AClient.LastName = LastName;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AClient.LastName, LastName);
        }

        
        [TestMethod]
        public void ClientLastNameMinLessOne()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //create a variable to record 
            Boolean Ok;
            //51 characters entry
            string SomeText = "LennisLennisLennisLennisLennisLennisLenLennisLennisL";
            //Test the valid method with a two character string 
            Ok = Aclient.Valid(SomeText);
            //Assert that the outcome should be true 
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ClientLastNameMaxPlusOne()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //create a variable to record 
            Boolean Ok;
            //51 characters entry
            string SomeText = "LennisLennisLennisLennisLennisLennisLenLennisLennisLen";
            //Test the valid method with a two character string 
            Ok = Aclient.Valid(SomeText);
            //Assert that the outcome should be true 
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ClientLastNameMid()
        {
            //create an instaqnce of the class we want to create 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = " ";
            LastName = LastName.PadRight(15, 'a');
            string Email = "lennisngugi@companyname.com";
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientLastNameExtremeMax()
        {
            //create an instaqnce of the class we want to create 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = " ";
            LastName = LastName.PadRight(60, 'a');
            string Email = "lennisngugi@companyname.com";
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ClientEmailPropertyOK()
        {
            //create an instance of the class
            clsClient AClient = new clsClient();
            //create a variable to store the name of the client 
            String Email;
            //Assign a client to variable 
            Email = "Lennisngugi@hotmail.co.uk";
            //try to send some data to the variable and property are the same 
            AClient.Email = Email;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AClient.Email, Email);
        }

        [TestMethod]
        public void ClientEmailMax()
        {
            //create an instaqnce of the class we want to create 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = " ";
            Email = Email.PadRight(50, 'a');
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientEmailMaxPlusOne()
        {
            //create an instaqnce of the class we want to create 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = " ";
            Email = Email.PadRight(50, 'a');
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientEmailMin()
        {
            //create an instance of the class 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = " ";
            Email = Email.PadRight(1, 'a');
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientEmailMinPlusOne()
        {
            //create an instance of the class 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = " ";
            Email = Email.PadRight(2, 'a');
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientEmailPlusOne()
        {
            //create an instance of the class 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = " ";
            Email = Email.PadRight(51, 'a');
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientEmailExtremeMax()
        {
            //create an instance of the class 
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = " ";
            Email = Email.PadRight(60, 'a');
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 04545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ClientPositionPropertyOK()
        {
            //create an instance of the class
            clsClient AClient = new clsClient();
            //create a variable to store the name of the client 
            String Position;
            //Assign a position to variable 
            Position = "Human Resource";
            //try to send some data to the variable and property are the same 
            AClient.Position = Position;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AClient.Position, Position);
        }

        [TestMethod]
        public void ClientPositionMin()
        {
            //create an instance of the class 
            clsClient Aclient = new clsClient();
            //Assign a client to variable 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "Lennisngugi@companyname.com";
            string Position = " ";
            Position = Position.PadRight(10, 'a');
            //try to send some data to the variable and property are the same
            Aclient.Position = Position;
            //check to see that the data in the variable and property are the same 
            Assert.AreEqual(Aclient.Position, Position);
        }

        [TestMethod]
        public void ClientPositionMinLessOne()
        {
            //create an instancce of the class 
            clsClient Aclient = new clsClient();
            //Assign a client to variable 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "Lennisngugi@companyname.com";
            string Position = " ";
            Position = Position.PadRight(9, 'a');
            //try to send some data to the variable and property are the same 
            Aclient.Position = Position;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(Aclient.Position, Position);
        }

        [TestMethod]
        public void ClientPositionMax()
        {
            //create an instance of the class we want to create
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //assign a position to variable 
            string Position = " ";
            Position = Position.PadRight(50, 'a');
            //try to send some data to the variable and property are the same 
            Aclient.Position = Position;
            //invoke the method 
            OK = Aclient.Valid(Position);
            //check to see that the data in the variable and property are the same 
            Assert.AreEqual(Aclient.Position, Position);
        }
    
        [TestMethod]
        public void ClientPositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //assign a position to variable 
            string Position = " ";
            Position = Position.PadRight(51, 'a');
            //try to send some data to the variable and property are the same 
            Aclient.Position = Position;
            //invoke the method 
            OK = Aclient.Valid(Position);
            //check to see that the data in the variable and property are the same 
            Assert.AreEqual(Aclient.Position, Position);
        }

        [TestMethod]
        public void ClientPositionMid()
        {
            //create an instancce of the class 
            clsClient Aclient = new clsClient();
            //Assign a client to variable 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "Lennisngugi@companyname.com";
            string Position = " ";
            Position = Position.PadRight(25, 'a');
            //try to send some data to the variable and property are the same 
            Aclient.Position = Position;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(Aclient.Position, Position);
        }

        [TestMethod]
        public void ClientPositionExtremeMax()
        {
            //create an instancce of the class 
            clsClient Aclient = new clsClient();
            //Assign a client to variable 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "Lennisngugi@companyname.com";
            string Position = " ";
            Position = Position.PadRight(60, 'a');
            //try to send some data to the variable and property are the same 
            Aclient.Position = Position;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(Aclient.Position, Position);
        }

        [TestMethod]
        public void ClientTelephonePropertyOK()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //create a variable to store the Telephone number of the client 
            string TelephoneNumber;
            //assign a client to variable 
            TelephoneNumber = "07495846385";
            //try to send same data to the client 
            Aclient.TelephoneNumber = TelephoneNumber;
            //check to see that the data in the variable and property are the same 
            Assert.AreEqual(Aclient.TelephoneNumber, TelephoneNumber);
        }
        
        [TestMethod]
        public void ClientTelephoneMin()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 0;
            Int64 FaxNumber = 02545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientTelephoneMinPlusOne()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 02;
            Int64 FaxNumber = 02545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientTelephoneMax()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk"; 
            string Position = "Human Resource";
            Int64 Telephone = 07484094234; 
            Int64 FaxNumber = 02545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientTelephoneMaxLessOne()
        {
            //create an instsance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 0748409423;
            Int64 FaxNumber = 02545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientTelephoneMaxPlusone()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 074840942345;
            Int64 FaxNumber = 02545485956;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientFaxNumberPropertyOK()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //create a variable to store the ID of the client 
            string FaxNumber;
            //assign a Faxnumber to variable 
            FaxNumber = "07495846385";
            //try to send same data to the client 
            Aclient.FaxNumber = FaxNumber;
            //check to see that the data in the variable and property are the same 
            Assert.AreEqual(Aclient.FaxNumber, FaxNumber);
        }

        
        [TestMethod]
        public void ClientFaxNumberMin()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 074840942345;
            Int64 FaxNumber = 0;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientFaxNumberMinPlusOne()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 0748409423;
            Int64 FaxNumber = 02;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void ClientFaxNumberMax()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 024840942345;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientFaxNumberMaxPlusOne()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 07484094234;
            Int64 FaxNumber = 0248409423456;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClientFaxExtremeMax()
        {
            //create an instance of the class
            clsClient Aclient = new clsClient();
            //boolean variable to store the results of the validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string FirstName = "Lennis";
            string LastName = "Ngugi";
            string Email = "lennisngugi@hotmail.co.uk";
            string Position = "Human Resource";
            Int64 Telephone = 0748409423456;
            Int64 FaxNumber = 07484094234567678;
            //invoke the method 
            OK = Aclient.Valid(FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void ClientFindMethodOk()
        {
            //create an instance of the class clsClient 
            clsClient Aclient = new clsClient();
            //boolean variable store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 ClientNo = 1;
            //invoke the method 
            Found = Aclient.Find(ClientNo);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we went to create 
            clsClient AClient = new clsClient();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method 
            String CompanyNo = "1";  
            String FirstName = "Lennis";
            String LastName = "Ngugi";
            String Email = "LennisNgugi@company.com";
            String Position = "Human Resource";
            String Telephone = "02454435435";
            String FaxNumber = "04554354354";
            //invoke the method
           OK = AClient.Valid(CompanyNo, FirstName, LastName, Email, Position, Telephone, FaxNumber);
            //test to see what the result is correct 
            Assert.IsTrue(OK);

        }
    }
}