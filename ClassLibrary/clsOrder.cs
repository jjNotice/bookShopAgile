using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Shipped { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string BookTitle { get; set; }
        public int OrderLine { get; set; }
        public int OrderID { get; set; }
    }
}