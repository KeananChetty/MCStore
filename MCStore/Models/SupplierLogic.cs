using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
    public class SupplierLogic
    {
        public List<Supplier> SupplierProducts { get; set; }
        public SupplierLogic()
        {
            SupplierProducts = new List<Supplier>()
            {
                 new SupplierProduct("RedWine",30,2,new DateTime(2013,01,01),TypesOfSupplierProducts.Drinks),
                 new SupplierProduct("RedWine",30,2,new DateTime(2013,01,01),TypesOfSupplierProducts.Food),
                 new SupplierProduct("RedWine",30,2,new DateTime(2013,01,01),TypesOfSupplierProducts.Toys)
            };
        }
        public double getSellingPrice(Supplier supplier)
        {
            foreach (var supplierProucts in SupplierProducts)
            {
                return supplier.SupplierSellingPrice;
            }
            return 0;
        }
    }
}
