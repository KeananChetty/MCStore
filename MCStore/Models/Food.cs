using System;
using System.Collections.Generic;
using System.Text;

namespace MCStore.Models
{
    public enum TypesOfFood
    {
        Perishable,
        NonPerishable
    }
    public class Food : Product
    {
        public TypesOfFood TypeofFoods { get; set; }
        public Food()
        {

        }
        public Food(string name, double sellingprice, int quantity, DateTime dateTime, TypesOfFood typesOfFood) :base(name,sellingprice,quantity,dateTime)
        {
            TypeofFoods = typesOfFood;
        }
    }
}
