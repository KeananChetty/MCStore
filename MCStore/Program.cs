using System;
using MCStore.Models;

namespace MCStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic();
            var product = new Product("RedWine", 30, 2, new DateTime(2013, 01, 01));
            var supplier = new Supplier("RedWine", 30, 2, new DateTime(2013, 01, 01));
            //var customer = new Customer("Chris", "0646827149", TypesOfCustomers.BulkCustomer);

            Console.WriteLine("******************* YOUR RECIEPT *******************");

            Console.WriteLine("Selling Price:"+logic.DeterminSellingPrice(product, supplier));
            Console.WriteLine("Tax Amount:" + logic.DeterminTax());
            Console.WriteLine("Markup:" + logic.DeterminMarkUp());
            //Console.WriteLine("Customer Details:"+customer);
        }
    }
}
