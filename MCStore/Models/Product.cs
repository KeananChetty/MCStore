using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double SellingPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Product()
        {

        }
        public Product(string name, double sellingprice, int quantity, DateTime purchasedate)
        {
            Name = name;
            SellingPrice = sellingprice;
            PurchaseDate = purchasedate;
            Quantity = quantity;
        }
    }
}
