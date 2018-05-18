using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace AppointmentTestFramework
{
    [TestClass]
    public class tstCompanyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCompanies);
        }

        [TestMethod]
        public void CompanyListOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCompany> TestList = new List<clsCompany>();
            //add an item to the list
            //create the item of test data 
            clsCompany TestData = new clsCompany();
            //set it's properties 
            TestData.CompanyID = 1;
            TestData.CompanyName = "Some Company";
            TestData.Address = "Some Address";
            TestData.PostCode = "LE2 7PT";
            TestData.TeleNum = "1234567890";
            TestData.Email = "SomeEmail@Email.com";
            TestData.Description = "This is an example";
            //add the item to the list
            TestList.Add(TestData);
            //assign the data to the property 
            AllCompanies.CompanyList = TestList;
            //test to see that it exists 
            Assert.AreEqual(AllCompanies.CompanyList, TestList);
        }

        [TestMethod]
        public void ThisCompanyPropertyOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create some test data to assign to the property
            clsCompany TestCompany = new clsCompany();
            //set it's properties of the test object
            TestCompany.CompanyID = 1;
            TestCompany.CompanyName = "Some Company";
            TestCompany.Address = "Some Address";
            TestCompany.PostCode = "LE2 7PT";
            TestCompany.TeleNum = "1234567890";
            TestCompany.Email = "SomeEmail@Email.com";
            TestCompany.Description = "This is an example";
            //assign the data to the property 
            AllCompanies.ThisCompany = TestCompany;
            //test to see that it exists 
            Assert.AreEqual(AllCompanies.ThisCompany, TestCompany);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCompany> TestList = new List<clsCompany>();
            //add an item to the list
            //create the item of test data 
            clsCompany TestItem = new clsCompany();
            //set it's properties 
            TestItem.CompanyID = 1;
            TestItem.CompanyName = "Some Company";
            TestItem.Address = "Some Address";
            TestItem.PostCode = "LE2 7PT";
            TestItem.TeleNum = "1234567890";
            TestItem.Email = "SomeEmail@Email.com";
            TestItem.Description = "This is an example";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCompanies.CompanyList = TestList;
            //test to see that it exists 
            Assert.AreEqual(AllCompanies.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create an item of test data
            clsCompany TestItem = new clsCompany();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set it's properties 
            TestItem.CompanyID = 1;
            TestItem.CompanyName = "some company";
            TestItem.Address = "some address";
            TestItem.PostCode = "le2 7pt";
            TestItem.TeleNum = "12345678910";
            TestItem.Email = "someEmail@com";
            TestItem.Description = "this is an example";
            //set ThisCompany to the test data
            AllCompanies.ThisCompany = TestItem;
            //add the record
            PrimaryKey = AllCompanies.Add();
            //set the primary key of the test data 
            TestItem.CompanyID = PrimaryKey;
            //find the record 
            AllCompanies.ThisCompany.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCompanies.ThisCompany, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create an item of test data
            clsCompany TestItem = new clsCompany();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set it's properties 
            TestItem.CompanyID = 1;
            TestItem.CompanyName = "some company";
            TestItem.Address = "some address";
            TestItem.PostCode = "le2 7pt";
            TestItem.TeleNum = "12345678910";
            TestItem.Email = "someEmail@com";
            TestItem.Description = "this is an example";
            //set ThisCompany to the test data
            AllCompanies.ThisCompany = TestItem;
            //add the record
            PrimaryKey = AllCompanies.Add();
            //set the primary key of the test data 
            TestItem.CompanyID = PrimaryKey;
            //find the record 
            AllCompanies.ThisCompany.Find(PrimaryKey);
            //delete the record
            AllCompanies.Delete();
            //now find the record
            Boolean Found = AllCompanies.ThisCompany.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create an item of test data
            clsCompany TestItem = new clsCompany();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set it's properties 
            TestItem.CompanyID = 1;
            TestItem.CompanyName = "some company";
            TestItem.Address = "some address";
            TestItem.PostCode = "le2 7pt";
            TestItem.TeleNum = "12345678910";
            TestItem.Email = "someEmail@com";
            TestItem.Description = "this is an example";
            //set ThisCompany to the test data
            AllCompanies.ThisCompany = TestItem;
            //add the record
            PrimaryKey = AllCompanies.Add();
            //set the primary key of the test data 
            TestItem.CompanyID = PrimaryKey;
            //modify the test data 
            TestItem.CompanyID = 2;
            TestItem.CompanyName = "another company";
            TestItem.Address = "another address";
            TestItem.PostCode = "sy3 4et";
            TestItem.TeleNum = "0987654321";
            TestItem.Email = "someEmail@com";
            TestItem.Description = "this is another example";
            //set the record based on the new test data
            AllCompanies.ThisCompany = TestItem;
            //update the record
            AllCompanies.Update();
            //find the record 
            AllCompanies.ThisCompany.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCompanies.ThisCompany, TestItem);
        }
    }
}

/*
        //No longer guaranteed two records
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assing the data to the property
            AllCompanies.Count = SomeCount;
            //test to see that it exists 
            Assert.AreEqual(AllCompanies.Count, SomeCount);
        }

        //cannot predict how many records will be present in clsCompanyCollection 
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsCompanyCollection AllCompanies = new clsCompanyCollection();
            //test to see that the two record values exist
            Assert.AreEqual(AllCompanies.Count, 2);
        }
*/
