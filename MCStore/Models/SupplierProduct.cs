using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
    public enum TypesOfSupplierProducts
    {
        Drinks,
        Food,
        Toys
    }
    public class SupplierProduct : Supplier
    {
        public TypesOfSupplierProducts TypeofSupplierProducts{ get; set; }
        public SupplierProduct()
        {

        }
        public SupplierProduct(string name, double sellingprice, int quantity, DateTime dateTime, TypesOfSupplierProducts typesofsupplierproducts) 
        {
            TypeofSupplierProducts = typesofsupplierproducts;
        }
    }
}
