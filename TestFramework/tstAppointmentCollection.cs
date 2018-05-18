using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AppointmentTestFramework
{
    [TestClass]
    public class tstAppointmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAppointments);
        }

        //create a test for the AppointmentList property
        [TestMethod]
        public void AppointmentListOK()
        {
            //create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of onjects
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            //create the item of test data
            clsAppointments TestItem = new clsAppointments();
            //set its properties
            TestItem.AppointmentNo = 1;
            TestItem.AppointmentTitle = "Website";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.ClientNo = 1;
            TestItem.Location = "Birmingham";
            TestItem.StaffNo = 1;
            TestItem.Status = "Pending";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentList = TestList;
            //test to see that the twqo value are the same
            Assert.AreEqual(AllAppointments.AppointmentList, TestList);
        }


        //create a test for the ThisAppointment property
        [TestMethod]
        public void ThisAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property
            clsAppointments TestAppointment = new clsAppointments();
            //set the properties of the test object
            TestAppointment.AppointmentNo = 1;
            TestAppointment.AppointmentTitle = "Website;";
            TestAppointment.BookingDate = DateTime.Now.Date;
            TestAppointment.ClientNo = 1;
            TestAppointment.Location = "Birmingham";
            TestAppointment.StaffNo = 1;
            TestAppointment.Status = "Pending";
            //assign the data to the property
            AllAppointments.ThisAppointment = TestAppointment;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestAppointment);
        }

        //this tests if records can be added to the lists and the count property
        //correctly reports how many items are in the list
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of onjects
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            //create the item of test data
            clsAppointments TestItem = new clsAppointments();
            //set its properties
            TestItem.AppointmentNo = 1;
            TestItem.AppointmentTitle = "Website";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.ClientNo = 1;
            TestItem.Location = "Birmingham";
            TestItem.StaffNo = 1;
            TestItem.Status = "Pending";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentList = TestList;
            //test to see that the twqo value are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }

        [TestMethod]
        public void AppointmentAddMethodOK()
        {
            //create an instance of the class we wantto create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create an item for tests data
            clsAppointments TestItem = new clsAppointments();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its props
            //TestItem.AppointmentNo = 0;
            TestItem.AppointmentTitle = "TestAddMethodAppointmentTitle";
            TestItem.ClientNo = 5;
            TestItem.StaffNo = 7;
            TestItem.Location = "TestAddBirminghamOffice";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.Status = "Pending"; 
            //Set this appointment to the test data
            AllAppointments.ThisAppointment = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentNo = PrimaryKey;
            //find the recird
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }


        [TestMethod]
        public void AppointmentDeleteMethodOK()
        {
            //create an instance of the class we wantto create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create an item for tests data
            clsAppointments TestItem = new clsAppointments();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its props
            //TestItem.StaffNo = 0;
            TestItem.AppointmentTitle = "TestAddMethodAppointmentTitle";
            TestItem.ClientNo = 5;
            TestItem.StaffNo = 7;
            TestItem.Location = "TestAddBirminghamOffice";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.Status = "Pending";
            //Set this staff to the test data
            AllAppointments.ThisAppointment = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentNo = PrimaryKey;
            //find the recird
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //delete the record
            AllAppointments.Delete();
            //now find the record
            Boolean Found = AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
    }
}
