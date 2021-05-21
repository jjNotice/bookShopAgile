using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountCollection;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Testing4

{

    [TestClass]

    public class tstAccountCollection

    {

        [TestMethod]

        public void InstanceOK()

        {
            clsAccountCollection allAccount = new clsAccountCollection();

            Assert.IsNotNull(allAccount);
        }

        [TestMethod]
        public void AccountListOK()

        {
            clsAccountCollection allAccount = new clsAccountCollection();

            List<clsAccount> TestList = new List<clsAccount>();

            clsAccount TestItem = new clsAccount();

            TestItem.NewsLetterSub = true;
            TestItem.JoinDate = Convert.ToDateTime("2011-01-01");
            TestItem.CustFName = "Jim";
            TestItem.CustSName = "Johnson";
            TestItem.CustAddress = "NN3 9GA";
            TestItem.CustPhone = 0791231231;
            TestItem.CustID = 2;

            TestList.Add(TestItem);

            allAccount.AccountList = TestList;

            Assert.AreEqual(allAccount.AccountList, TestList);

        }

        [TestMethod]

        public void ThisAccountPropertyOK()

        {

            clsAccountCollection allAccount = new clsAccountCollection();

            clsAccount TestAccount = new clsAccount();

            TestAccount.NewsLetterSub = true;
            TestAccount.JoinDate = Convert.ToDateTime("2011-01-01");
            TestAccount.CustFName = "Jim";
            TestAccount.CustSName = "Johnson";
            TestAccount.CustAddress = "NN3 9GA";
            TestAccount.CustPhone = 0791231231;
            TestAccount.CustID = 2;

            allAccount.ThisAccount = TestAccount;

            Assert.AreEqual(allAccount.ThisAccount, TestAccount);
        }

        [TestMethod]

        public void ListAndCountOK()

        {

            clsAccountCollection allAccount = new clsAccountCollection();

            List<clsAccount> TestList = new List<clsAccount>();

            clsAccount TestItem = new clsAccount();

            TestItem.NewsLetterSub = true;
            TestItem.JoinDate = Convert.ToDateTime("2011-01-01");
            TestItem.CustFName = "Jim";
            TestItem.CustSName = "Johnson";
            TestItem.CustAddress = "NN3 9GA";
            TestItem.CustPhone = 0791231231;
            TestItem.CustID = 2;

            TestList.Add(TestItem);

            allAccount.AccountList = TestList;

            Assert.AreEqual(allAccount.count, TestList.Count);

        }

        [TestMethod]

        public void AddMethodOK()

        {

            clsAccountCollection allAccount = new clsAccountCollection();

            clsAccount TestItem = new clsAccount();

            Int32 PrimaryKey = 0;

            TestItem.NewsLetterSub = true;
            TestItem.JoinDate = Convert.ToDateTime("2011-01-01");
            TestItem.CustFName = "Jim";
            TestItem.CustSName = "Johnson";
            TestItem.CustAddress = "NN3 9GA";
            TestItem.CustPhone = 0791231231;
            TestItem.CustID = 2;

            allAccount.ThisAccount = TestItem;

            PrimaryKey = allAccount.Add();

            TestItem.CustID = PrimaryKey;

            allAccount.ThisAccount.Find(PrimaryKey);

            Assert.AreEqual(allAccount.ThisAccount, TestItem);

        }


        [TestMethod]

        public void UpdateMethodOK()

        {

            clsAccountCollection allAccount = new clsAccountCollection();

            clsAccount TestItem = new clsAccount();

            int PrimaryKey = 80;
            TestItem.NewsLetterSub = true;
            TestItem.JoinDate = Convert.ToDateTime("2011-01-01");
            TestItem.CustFName = "Jim";
            TestItem.CustSName = "Johnson";
            TestItem.CustAddress = "NN3 9GA";
            TestItem.CustPhone = 0791231231;
            TestItem.CustID = 2;

            allAccount.ThisAccount = TestItem;

            PrimaryKey = allAccount.Add();

            TestItem.CustID = PrimaryKey;

            TestItem.NewsLetterSub = true;
            TestItem.JoinDate = Convert.ToDateTime("2011-01-01");
            TestItem.CustFName = "Jennifer";
            TestItem.CustSName = "Carnel";
            TestItem.CustAddress = "LE30DS";
            TestItem.CustPhone = 0793213212;
            TestItem.CustID = 3;

            allAccount.ThisAccount = TestItem;

            allAccount.Update();

            allAccount.ThisAccount.Find(PrimaryKey);

            Assert.AreEqual(allAccount.ThisAccount, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()

        {

            clsAccountCollection allAccount = new clsAccountCollection();

            clsAccount TestItem = new clsAccount();

            Int32 PrimaryKey = 0;

            TestItem.NewsLetterSub = true;
            TestItem.JoinDate = Convert.ToDateTime("2011-01-01");
            TestItem.CustFName = "Jim";
            TestItem.CustSName = "Johnson";
            TestItem.CustAddress = "NN39GA";
            TestItem.CustPhone = 0791231231;
            TestItem.CustID = 2;

            allAccount.ThisAccount = TestItem;

            PrimaryKey = allAccount.Add();

            TestItem.CustID = PrimaryKey;

            allAccount.ThisAccount.Find(PrimaryKey);

            allAccount.Delete();

            Boolean Found = allAccount.ThisAccount.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }


        [TestMethod]

        public void ReportByCustAddressMethodOK()

        {

            clsAccountCollection allAccount = new clsAccountCollection();

            clsAccountCollection filteredAccount = new clsAccountCollection();

            filteredAccount.ReportByCustAddress("");

            Assert.AreEqual(allAccount.count, filteredAccount.count);
        }

        [TestMethod]

        public void ReportByCustAddressNoneFound()

        {

            clsAccountCollection filteredAccount = new clsAccountCollection();

            filteredAccount.ReportByCustAddress("yyy yyy");

            Assert.AreEqual(0, filteredAccount.count);
        }

        [TestMethod]

        public void ReportByCustAddressTestDataFound()

        {

            clsAccountCollection FilteredAccount = new clsAccountCollection();
            Boolean OK = true;
            FilteredAccount.ReportByCustAddress("LE30DS");
            if (FilteredAccount.count == 2)
            {
                if (FilteredAccount.AccountList[0].CustID != 3)
                {
                    OK = false;
                }
                if (FilteredAccount.AccountList[1].CustID != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}