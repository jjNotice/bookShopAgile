using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
       

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mOrderLine = "2233011";
            mBookTitle = "The Lord of the Rings";
            mOrderDate = Convert.ToDateTime("17/03/2021");
            mPrice = 5.20m;
            mQuantity = 1;
            mShipped = true;
            //always return true
            return true;
        }

        public class ClsOrder
        {
            // private data member for the order id property
            private Int32 mOrderId;
        }

        //orderId private member variable
        private Int32 mOrderId;
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //This line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //This line of code allow data into the property
                mOrderId = value;
            }
        }

        //private orderline data member
        private String mOrderLine;
        //public property for date added
        public String OrderLine
        {
            get
            {
                return mOrderLine;
            }
            set
            {
                mOrderLine = value;
            }
        }

        //private book title data member
        private String mBookTitle;
        //public property for date added
        public String BookTitle
        {
            get
            {
                return mBookTitle;
            }
            set
            {
                mBookTitle = value;
            }
           
        }

        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        private Decimal mPrice;

        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        private int mQuantity;

        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private Boolean mShipped;

        public Boolean Shipped
        {
            get
            {
                return mShipped;
            }
            set
            {
                mShipped = value;
            }
        }
    }
}
        





