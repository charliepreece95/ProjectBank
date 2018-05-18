using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace AppointmentTestFramework
{
    [TestClass]
    public class tstProjectCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProjectCollection AllProjects = new clsProjectCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProjects);
        }
        
        [TestMethod]
        public void ListNamesOk()
        {
            //create an instance of the class we want to create
            clsProjectCollection AllProjects = new clsProjectCollection();
            //create some test data to assign to the property
            List<clsProject> TestList = new List<clsProject>();
            //add an item to the list 
            //create the item of test data
            clsProject TestItem = new clsProject();
            //set its properties
            TestItem.AppointmentID = 11;
            TestItem.AProjectDescription = "project";
            TestItem.AProjectID = 2;
            TestItem.ClientID = 13;
            TestItem.ProjectName = "Website Creation";
            TestItem.StaffID = 15;
            TestItem.EstimatedCompletionDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the the property
            AllProjects.ListNames = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProjects.ListNames, TestList);
        }

        [TestMethod]

        public void CountProperty()
        {
            //create an instance of the class we want to create
            clsProjectCollection AllProjects = new clsProjectCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllProjects.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllProjects.Count, SomeCount);
        }

        [TestMethod]

        public void ThisProjectPropertyOK()
        {
            //create an instance of the class we want to create 
            clsProjectCollection AllProjects = new clsProjectCollection();
            //create some test data to assign to the property
            clsProject TestProject = new clsProject();
            //set the properties of the test object
            TestProject.AppointmentID = 11;
            TestProject.AProjectDescription = "project";
            TestProject.AProjectID = 2;
            TestProject.EstimatedCompletionDate = DateTime.Now.Date;
            TestProject.ClientID = 13;
            TestProject.StaffID = 15;
            TestProject.ProjectName = "Website Creation";
            //assign the data to the property
            AllProjects.ThisProject = TestProject;
            //test to see that the two values are the same
            Assert.AreEqual(AllProjects.ThisProject, TestProject);
        }

        [TestMethod]

        public void ListAndCount()
        {
            //create an instance of the class we want to create
            clsProjectCollection AllProjects = new clsProjectCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProject> TestList = new List<clsProject>();
            //add an item to the list
            //create the item of test data
            clsProject TestItem = new clsProject();
            //set its properties
            TestItem.AppointmentID = 11;
            TestItem.AProjectDescription = "project";
            TestItem.AProjectID = 2;
            TestItem.ClientID = 13;
            TestItem.EstimatedCompletionDate = DateTime.Now.Date;
            TestItem.ProjectName = "ProjectName";
            TestItem.StaffID = 15;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProjects.ListNames = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProjects.Count, TestList.Count);
        }
    }
}
