using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstAccount
    {

        //good test data
        //create the good test data for the method valid
        private string CustFName = "Jake";
        private string CustSName = "Johnson";
        private string CustPhone = "07912345678";
        private string CustAddress = "Customer Address";
        private string JoinDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsAccount Account = new clsAccount();
            Assert.IsNotNull(Account);
        }

        [TestMethod]
        public void CustIDOK()
        {
            clsAccount ACustID = new clsAccount();
            Assert.IsNotNull(ACustID);
        }

        [TestMethod]
        public void CustFNameOK()
        {
            clsAccount aAccount = new clsAccount();
            string TestData = CustFName;
            aAccount.CustFName = TestData;
            Assert.AreEqual(aAccount.CustFName, TestData);
        }

        [TestMethod]
        public void CustFNameMin()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custFName = "aa";
            Error = aAccount.Valid(custFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustFNameMinPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custFName = "aaa";
            Error = aAccount.Valid(custFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFNameMinLessOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custFName = "";
            Error = aAccount.Valid(custFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustFNameMax()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custFName = "aaaaaa";
            Error = aAccount.Valid(custFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameOK()
        {
            clsAccount aAccount = new clsAccount();
            string TestData = CustSName;
            aAccount.CustSName = TestData;
            Assert.AreEqual(aAccount.CustSName, TestData);
        }

        [TestMethod]
        public void CustSNameMin()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custSName = "bb";
            Error = aAccount.Valid(CustFName, custSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameMinPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string CustSName = "bbb";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameMinLessOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string tstCustSName = "";
            Error = aAccount.Valid(CustFName, tstCustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameMaxLessOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string tstCustSName = "";
            tstCustSName = CustSName.PadLeft(29, '*');
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameMax()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string CustSName = "";
            CustSName = CustSName.PadLeft(30, '*');
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameMid()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string CustSName = "qwertyuiopasdfg";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameMaxPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string tstCustSName = "";
            Error = aAccount.Valid(CustFName, tstCustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustSNameExtremeMax()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string tstCustSName = "";
            tstCustSName = CustSName.PadLeft(500, '*');
            Error = aAccount.Valid(CustFName, tstCustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountJoinDate()
        {
            clsAccount Account = new clsAccount();
            DateTime TestData = DateTime.Now.Date;
            Account.JoinDate = TestData;
            Assert.AreEqual(Account.JoinDate, TestData);

        }

        [TestMethod]
        public void CustID()
        {
            clsAccount Account = new clsAccount();
            int TestData = 1;
            Account.CustID = TestData;
            Assert.AreEqual(Account.CustID, TestData);

        }

        [TestMethod]
        public void AccountCustFName()
        {
            clsAccount Account = new clsAccount();
            String TestData = "aaa";
            Account.CustFName = TestData;
            Assert.AreEqual(Account.CustFName, TestData);
        }

        [TestMethod]
        public void AccountCustSName()
        {
            clsAccount Account = new clsAccount();
            String TestData = "aaa";
            Account.CustSName = TestData;
            Assert.AreEqual(Account.CustSName, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsAccount aAccount = new clsAccount();
            Boolean Found = false;
            Int32 CustID = 1;
            Found = aAccount.Find(CustID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustIDFound()
        {
            clsAccount aAccount = new clsAccount();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustID = 1;
            Found = aAccount.Find(CustID);
            if (aAccount.CustID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDataAddedFound()
        {
            clsAccount aAccount = new clsAccount();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustID = 1;
            Found = aAccount.Find(CustID);
            if (aAccount.JoinDate != Convert.ToDateTime("1995-07-15"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AccountCustPhone()
        {
            clsAccount Account = new clsAccount();
            int TestData = 01234567899;
            Account.CustPhone = TestData;
            Assert.AreEqual(Account.CustPhone, TestData);
        }

        [TestMethod]
        public void TestAccountCustPhone()
        {
            clsAccount aAccount = new clsAccount();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustID = 1;
            Found = aAccount.Find(CustID);
            if (aAccount.CustPhone != 01234567899)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void CustFNameMid()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            String CustFName = "aaaaaaaaaa";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFNameMaxPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            String custFName = "";
            Error = aAccount.Valid(custFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustFNameMaxExtreme()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            string custFName = "";
            custFName = CustFName.PadRight(500, 'a');
            Error = aAccount.Valid(custFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }
/*
        [TestMethod]
        public void CustPhoneExtremeMin()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            String CustPhone = TestData.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }*/

        [TestMethod]
        public void CustPhoneMinLessOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            String custPhone = "";
            Error = aAccount.Valid(CustFName, CustSName, custPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneMin()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Int32 TestData;
            TestData = 100;
            String CustPhone = TestData.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneMinPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Int32 TestData;
            TestData = 101;
            String CustPhone = TestData.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneMaxLessOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Int32 TestData;
            TestData = 99999;
            String CustPhone = TestData.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneMax()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Int32 TestData;
            TestData = 100000;
            String CustPhone = TestData.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneMid()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Int32 TestData;
            TestData = 50000;
            String CustPhone = TestData.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneMaxPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            String custPhone = "";
            Error = aAccount.Valid(CustFName, CustSName, custPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneExtremeMax()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            String custPhone = "";
            custPhone = CustPhone.PadRight(500, 'a');
            Error = aAccount.Valid(CustFName, CustSName, custPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void JoinDateInvalidDate()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            string JoinDate = "this is not a valid date";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustPhoneValidInt()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            string CustPhone = "this is not a phone number";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TestCustFNameFound()
        {
            clsAccount aAccount = new clsAccount();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustID = 1;
            Found = aAccount.Find(CustID);
            if (aAccount.CustFName != "Jake")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NewsLetterSubOK()
        {
            clsAccount Account = new clsAccount();
            Boolean TestData = true;
            Account.NewsLetterSub = TestData;
            Assert.AreEqual(Account.NewsLetterSub, TestData);
        }


        [TestMethod]
        public void TestNewsLetterSub()
        {
            clsAccount aAccount = new clsAccount();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustID = 1;
            Found = aAccount.Find(CustID);
            if (aAccount.NewsLetterSub != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void JoinDateMaxLessOneYear()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            String JoinDate = TestDate.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateMaxPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            string JoinDate = TestDate.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateExtremeMax()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            string JoinDate = TestDate.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateminLessOne()
        {
            clsAccount aAccount = new clsAccount();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-15);
            string JoinDate = TestDate.ToString();
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, CustAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMinPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "aaa";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMinLessOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMaxLessOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "aaaaa";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMax()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "aaaaaa";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMid()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "qwerasdfzxxcv";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMaxPlusOne()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "";
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressExtremeMax()
        {
            clsAccount aAccount = new clsAccount();
            string Error = "";
            string custAddress = "";
            custAddress = CustAddress.PadLeft(500, 'a');
            Error = aAccount.Valid(CustFName, CustSName, CustPhone, custAddress, JoinDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}