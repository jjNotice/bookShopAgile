using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testingOrder
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ShippedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Shipped = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Shipped, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);

        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign to the property
            Decimal TestData = 5.20m;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);

        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);


        }

        [TestMethod]
        public void BookTitlePropertyOK()
        {
            
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "The Lord of the Rings";
            //assign the data to the property
            AnOrder.BookTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.BookTitle, TestData);

        }

        [TestMethod]
        public void OrderLinePorpertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign to the property
            String TestData = "2233011";
            //assign the data to the property
            AnOrder.OrderLine = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderLine, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

    }   


}       

