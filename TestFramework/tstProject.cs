using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Frame_Company
{
    [TestClass]
    public class tstProject
    {
        [TestMethod]
        public void ProjectInstanceOK()
        {
            //create an instance of the class clsCompany
            clsProject AProject = new clsProject();
            //check if it exists
            Assert.IsNotNull(AProject);
        }
        [TestMethod]

        public void ProjectAppointmentNoPropertyOK()
        {
            //create an instance of  the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            int AppointmentID = 10;
            //assign the test data to the property
            AProject.AppointmentID = AppointmentID;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.AppointmentID, AppointmentID);
        }
        [TestMethod]

        public void ProjectClientIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            int ClientID = 12;
            //assign the test data to the property
            AProject.ClientID = ClientID;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.ClientID, ClientID);
        }

        [TestMethod]

        public void ProjectEstimatedCompletedDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            DateTime EstimatedCompletedDate = DateTime.Now.Date;
            //assign the test data to the property
            AProject.EstimatedCompletionDate = EstimatedCompletedDate;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.EstimatedCompletionDate, EstimatedCompletedDate);
        }

        [TestMethod]

        public void ProjectDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string AProjectDescription = "A new Project was created";
            //assign the test data to the property
            AProject.AProjectDescription = AProjectDescription;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.AProjectDescription, AProjectDescription);
        }


        [TestMethod]

        public void ProjectIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            int AProjectID = 13;
            //assign the test data to the property
            AProject.AProjectID = AProjectID;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.AProjectID, AProjectID);
        }

        [TestMethod]

        public void ProjectNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            string ProjectName = "New Project";
            //assign the test data to the property
            AProject.ProjectName = ProjectName;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.ProjectName, ProjectName);
        }
        [TestMethod]

        public void ProjectStaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //create some test data to assign to the property
            int StaffID = 15;
            //assign the test data to the property
            AProject.StaffID = StaffID;
            //test to see that the two values are the same 
            Assert.AreEqual(AProject.StaffID, StaffID);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            int ProjectID = 2;
            //invoke the method
            Found = AProject.Find(ProjectID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestProjectID()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int AProjectID = 2;
            //invoke the method
            Found = AProject.Find(AProjectID);
            //check the ProjectID
            if (AProject.AProjectID != 2)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        
        public void TestClientIDFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int AProjectID = 2;
            //invoke the method 
            Found = AProject.Find(AProjectID);
            //check the ClientID
            if (AProject.ClientID != 13)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]

        public void TestEstimatedCompletionDateFound()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AProjectID = 2;
            //invoke the method
            Found = AProject.Find(AProjectID);
            //check the EstimatedCompletionDate
            if (AProject.EstimatedCompletionDate !=Convert.ToDateTime("19/06/2012"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestProjectDescription()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AProjectID = 2;
            //invoke the method
            Found = AProject.Find(AProjectID);
            //check the ProjectDescription
            if (AProject.AProjectDescription != "project")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

      

        [TestMethod]
        
        public void TestProjectName()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int AProjectID = 2;
            //invoke the method
            Found = AProject.Find(AProjectID);
            //check the ProjectID
            if (AProject.ProjectName != "Website Creation")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStaffID()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int AProjectID = 2;
            //invoke the method
            Found = AProject.Find(AProjectID);
            //check the staffID
            if (AProject.StaffID != 15)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentID()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK(Assume it is)
            Boolean OK = true;
            //create some test data  to use with the method
            int AProjectID = 2;
            //invoke the method 
            Found = AProject.Find(AProjectID);
            //check the AppointmentID
            if (AProject.AppointmentID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass on the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new website was created";
            //invoke the method 
            OK = AProject.Valid(ProjectName, ProjectDescription,EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "";//this should fail
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(EstimatedCompletionDate, ProjectName, ProjectDescription);
            //test to see the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void ProjectNameMinBoundary()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "a";//this should pass
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription,EstimatedCompletionDate);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "aa";//this should pass
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription,EstimatedCompletionDate);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "aaaa";//this should pass
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameMax()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "aaaaa";//this should pass
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(ProjectName,ProjectDescription,EstimatedCompletionDate);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "aaaaaa";//this should pass
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameMid()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "aaaaaaa";//this should pass
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription,EstimatedCompletionDate);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectName = "";//this should fail
            ProjectName = ProjectName.PadRight(500, 'a');
            string ProjectDescription = "A new Website was created";
            //invoke the method
            OK = AProject.Valid(EstimatedCompletionDate, ProjectName, ProjectDescription);
            //test to see the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]

        public void EstimatedCompletionDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateMin()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;   
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        public void EstimatedCompletionDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateMax()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);                                      
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateMid()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "A new Website was created";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string EstimatedCompletionDate = TestDate.ToString();
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void EstimatedCompletionDateInvalidData()
        {
            //create an instance of the class we want to create
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string ProjectDescription = "a new website was created";
            //set the EstimatedCompletionDate to a non date value
            string EstimatedCompletionDate = "no EstimatedCompletionDate mentioned";
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = Convert.ToString(DateTime.Now.Date);
            string ProjectDescription = "";//this should fail
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMin()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "a";//this should pass
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "aa";//this should pass
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "";//this should fail
            ProjectDescription = ProjectDescription.PadRight(49, 'a');
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMax()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "";//this should fail
            ProjectDescription = ProjectDescription.PadRight(50, 'a');
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "";//this should fail
            ProjectDescription = ProjectDescription.PadRight(51, 'a');
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void ProjectDescriptionMid()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "";//this should fail
            ProjectDescription = ProjectDescription.PadRight(25, 'a');
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ProjectDescriptionExtremeMax()
        {
            //create an instance of the class we want to create 
            clsProject AProject = new clsProject();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string ProjectName = "Website Creation";
            string EstimatedCompletionDate = DateTime.Now.Date.ToString();
            string ProjectDescription = "";
            ProjectDescription = ProjectDescription.PadRight (500, 'a');//this should fail
            //invoke the method
            OK = AProject.Valid(ProjectName, ProjectDescription, EstimatedCompletionDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

    }
}
