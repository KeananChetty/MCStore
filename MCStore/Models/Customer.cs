using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
    public enum TypesOfCustomers
    {
        BulkCustomer =20,
        CasualCustomer=100
    }
    public class Customer
    {
        public string Name { get; set; }
        public string CellNumber { get; set; }
        public TypesOfCustomers TypesofCustomer { get; set; }

        public Customer()
        {

        }
        public Customer(string name, string cellnumber, TypesOfCustomers typesOfCustomers)
        {
            Name = name;
            CellNumber = cellnumber;
            TypesofCustomer = typesOfCustomers;
        }
    }
}
