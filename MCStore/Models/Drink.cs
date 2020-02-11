using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
    public enum TypesOfDrinks
    {
        Alcholic,
        NonAlcoholic
    }
    public class Drink:Product
    {
        public TypesOfDrinks TypeofDrinks { get; set; }
        public Drink()
        {

        }
        public Drink(string name, double sellingprice, int quantity, DateTime dateTime, TypesOfDrinks typesOfDrinks):base(name, sellingprice,quantity,dateTime)
        {
            TypeofDrinks = typesOfDrinks;
        }
    }
}
