using System;

namespace MyFirstProjectC.Entities
{
    public class Product
    {

        public int ProductId { get; set; }

        public Int32 CategoryId { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }

        public string QuantityPerUnit { get; set; }


    }
}
