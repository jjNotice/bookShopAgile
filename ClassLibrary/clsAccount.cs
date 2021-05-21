using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsAccount
    {

        private int mCustID;
        private DateTime mJoinDate;
        private Boolean mNewsLetterSub;
        private String mCustFName;
        private String mCustSName;
        private String mCustAddress;
        private Int32 mCustPhone;

        public bool NewsLetterSub
        {
            get
            {
                return mNewsLetterSub;
            }
            set
            {
                mNewsLetterSub = value;
            }
        }
        public DateTime JoinDate
        {
            get
            {
                return mJoinDate;
            }
            set
            {
                mJoinDate = value;
            }

        }
        public int CustID
        {
            get
            {
                return mCustID;
            }
            set
            {
                mCustID = value;
            }
        }

        public string CustFName
        {
            get
            {
                return mCustFName;
            }
            set
            {
                mCustFName = value;
            }
        }

        public string CustSName
        {
            get
            {
                return mCustSName;
            }
            set
            {
                mCustSName = value;
            }
        }

        public string CustAddress
        {
            get
            {
                return mCustAddress;
            }
            set
            {
                mCustAddress = value;
            }
        }

        public int CustPhone
        {
            get
            {
                return mCustPhone;
            }
            set
            {
                mCustPhone = value;
            }
        }

        public bool Find(int CustID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustID", CustID);
            DB.Execute("sproc_tblAccount_FilterByCustID");
            if (DB.Count == 1)
            {
                mCustID = Convert.ToInt32(DB.DataTable.Rows[0]["CustID"]);
                mCustFName = Convert.ToString(DB.DataTable.Rows[0]["CustFName"]);
                mCustSName = Convert.ToString(DB.DataTable.Rows[0]["CustSName"]);
                mCustAddress = Convert.ToString(DB.DataTable.Rows[0]["CustAddress"]);
                mNewsLetterSub = Convert.ToBoolean(DB.DataTable.Rows[0]["NewsLetterSub"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                mCustPhone = Convert.ToInt32(DB.DataTable.Rows[0]["CustPhone"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string CustFName, string CustSName, string CustPhone, string CustAddress, string JoinDate)
        {
            String Error = "";
            DateTime DateTemp;
            //Int32 custPhone;

          

            if (CustAddress.Length > 50)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }
            if (CustAddress.Length == 0)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }

            if (CustFName.Length > 50)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }
            if (CustFName.Length == 0)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }

            if (CustSName.Length > 50)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }
            if (CustSName.Length == 0)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }

            if (CustPhone.Length > 11)
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }

            if (CustPhone.Length == 0) 
            {
                Error = Error + "The address must be equal to or less than 21 characters";
            }

            try
            {
                DateTemp = Convert.ToDateTime(JoinDate);
                DateTime DateMinusHund;
                DateMinusHund = DateTime.Now.Date.AddYears(-100);
                if (DateTemp <= DateMinusHund)
                {
                    Error = Error + "The date cannot be 100 years or more the past : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            /*   try
               {
                   custPhone = Convert.ToInt32(CustPhone);

                   if (custPhone < 100)
                   {
                       Error = Error + "The phone number cannot be less than 100 : ";
                   }
                   if (custPhone > 100000)
                   {
                       Error = Error + "The phone number cannot be more than 100,000 : ";
                   }
               }
               catch
               {
                   Error = Error + "The phone number was not a valid number : ";
               }*/
            return Error;
        }
    }
}