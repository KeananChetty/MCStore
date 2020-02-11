using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
   public class Supplier
    {
        
        public string SupplierProductName { get; set; }
        public double SupplierSellingPrice { get; set; }
        public double SupplierQuantity { get; set; }
        public DateTime SupplierDateOfPurchase { get; set; }
        public Supplier()
        {

        }
        public Supplier(string supplierproductname, double suppliersellingprice, double supplierquantity, DateTime supplierdateofpurchase)
        {
            SupplierProductName = supplierproductname;
            SupplierSellingPrice = suppliersellingprice;
            SupplierQuantity = supplierquantity;
            SupplierDateOfPurchase = SupplierDateOfPurchase;
        }
    }
    }

