using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{ 
    public class Logic
    {
        public List<Product> ProductsInStock { get; set; }
        public static SupplierLogic supplierLogic;
        private static double tax = 0.15;
        public Logic()
        {
            ProductsInStock = new List<Product>()
            {
                 new Drink("RedWine",30,2,new DateTime(2013,01,01),TypesOfDrinks.Alcholic),
                 new Drink("RedWine",30,2,new DateTime(2013,01,01),TypesOfDrinks.Alcholic),
                 new Drink("RedWine",30,2,new DateTime(2013,01,01),TypesOfDrinks.Alcholic)

            };
            supplierLogic = new SupplierLogic();
        }

        public double DeterminSellingPrice(Product product, Supplier supplier) 
        {
            foreach (var products in ProductsInStock)
            {
               return (product.SellingPrice + supplierLogic.getSellingPrice(supplier))*product.Quantity;
            }
            return 0;
        }

        public double DeterminTax()
        {
            foreach (var product in ProductsInStock)
            {
                if (TypesOfDrinks.Alcholic==0)
                {
                    return product.SellingPrice * tax;
                }
            }
            return 0;
        }
        public double DeterminMarkUp()
        {
            foreach (var product in ProductsInStock)
            {
                if (TypesOfCustomers.BulkCustomer.Equals(0))
                {
                    return (product.SellingPrice + (int)TypesOfCustomers.BulkCustomer) * product.Quantity;
                }
                else if (TypesOfCustomers.CasualCustomer.Equals(0)) 
                {
                
                    return (product.SellingPrice + (int)TypesOfCustomers.CasualCustomer) * product.Quantity;

                }
            }
            return 0;
        }


        public bool CheckExpiry(Food food)
        {
            int PurchasedDay = food.PurchaseDate.Day;
            int DayNow = DateTime.Now.Day;
            int checkDate = DayNow - PurchasedDay;
            if (TypesOfFood.Perishable==0 && DayNow>7) 
            {

                return true;
            }
        else return false;
                     
        
        }

    }
}
