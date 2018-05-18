using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic; //added to handle collections

namespace AppointmentTestFramework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //crate an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //crate an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some tests data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of tests data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Ashley";
            TestItem.LastName = "Redman";
            TestItem.Email = "example@domain.com";
            TestItem.Position = "Manager";
            TestItem.TeleNo = "01509263756";
            //add the item to the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        /* REMOVED TESTS AS TestMethod ListAndCountOK tests is more thorough
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we wantto create
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
        */

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we wantto create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some tests data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the tests object
            TestStaff.StaffNo = 1;
            TestStaff.FirstName = "Ashley";
            TestStaff.LastName = "Redman";
            TestStaff.Email = "example@domain.com";
            TestStaff.Position = "Manager";
            TestStaff.TeleNo = "01509263756";
            //Assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we wantto create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some tests data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the tests data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Ashley";
            TestItem.LastName = "Redman";
            TestItem.Email = "example@domain.com";
            TestItem.Position = "Manager";
            TestItem.TeleNo = "01509263756";
            //add the data to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        /* REDUNDANT TEST (Programing pathways page 121)
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //tests to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, 2);
        }
        */

        [TestMethod]
        public void StaffAddMethodOK()
        {
            //create an instance of the class we wantto create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item for tests data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its props
            //TestItem.StaffNo = 0;
            TestItem.FirstName = "TestAddMethodFirstName";
            TestItem.LastName = "TestAddMethodLastName";
            TestItem.Email = "Test@example.com";
            TestItem.Position = "TestPos";
            TestItem.TeleNo = "07969960008";
            //Set this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the recird
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void StaffDeleteMethodOK()
        {
            //create an instance of the class we wantto create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item for tests data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its props
            //TestItem.StaffNo = 0;
            TestItem.FirstName = "TestAddMethodFirstName";
            TestItem.LastName = "TestAddMethodLastName";
            TestItem.Email = "Test@example.com";
            TestItem.Position = "TestPos";
            TestItem.TeleNo = "07969960008";
            //Set this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the recird
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
            
        }

        /*
         Test Method for Update Here 

        Unable to complete due to using html tables to display data rather than listboxes 

         */

        /*
         Test Method for FilterByFirstName Here

        Unable to complete 
         
         */

    }
}
