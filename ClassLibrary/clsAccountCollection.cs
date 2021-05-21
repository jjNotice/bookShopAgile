using System;
using ClassLibrary;
using System.Collections.Generic;

namespace AccountCollection

{

    public class clsAccountCollection

    {
        List<clsAccount> mAccountList = new List<clsAccount>();
        clsAccount mThisAccount = new clsAccount();

        public clsAccountCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAccount_SelectAll");
            PopulateArray(DB);
        }

        public List<clsAccount> AccountList
        {
            get
            {
                return mAccountList;
            }
            set
            {
                mAccountList = value;
            }
        }

        public int count
        {
            get
            {
                return mAccountList.Count;
            }
            set

            { 

            }

        }

        public clsAccount ThisAccount

        {

            get

            {

                return mThisAccount;

            }

            set

            {

                mThisAccount = value;

            }

        }



        public int Add()

        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustFName", mThisAccount.CustFName);
            DB.AddParameter("@CustSName", mThisAccount.CustSName);
            DB.AddParameter("@CustAddress", mThisAccount.CustAddress);
            DB.AddParameter("@CustPhone", mThisAccount.CustPhone);
            DB.AddParameter("@JoinDate", mThisAccount.JoinDate);
            DB.AddParameter("@NewsletterSub", mThisAccount.NewsLetterSub);
            return DB.Execute("sproc_tblAccount_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustID", mThisAccount.CustID);
            DB.AddParameter("@CustFName", mThisAccount.CustFName);
            DB.AddParameter("@CustSName", mThisAccount.CustSName);
            DB.AddParameter("@CustAddress", mThisAccount.CustAddress);
            DB.AddParameter("@CustPhone", mThisAccount.CustPhone);
            DB.AddParameter("@JoinDate", mThisAccount.JoinDate);
            DB.AddParameter("@NewsletterSub", mThisAccount.NewsLetterSub);
            DB.Execute("sproc_tblAccount_Update");
        }


        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustID", mThisAccount.CustID);
            DB.Execute("sproc_tblAccount_Delete");
        }

        public void ReportByCustAddress(string CustAddress_)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustAddress", CustAddress_);
            DB.Execute("sproc_tblAccount_FilterByCustAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)

        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mAccountList = new List<clsAccount>();
            while (Index < RecordCount)
            {
                clsAccount aAccount = new clsAccount();
                aAccount.CustID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustID"]);
                aAccount.CustFName = Convert.ToString(DB.DataTable.Rows[Index]["CustFName"]);
                aAccount.CustSName = Convert.ToString(DB.DataTable.Rows[Index]["CustSName"]);
                aAccount.CustPhone = Convert.ToInt32(DB.DataTable.Rows[Index]["CustPhone"]);
                aAccount.CustAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustAddress"]);
                aAccount.NewsLetterSub = Convert.ToBoolean(DB.DataTable.Rows[Index]["NewsLetterSub"]);
                aAccount.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
                mAccountList.Add(aAccount);
                Index++;
            }
        }
    }
}