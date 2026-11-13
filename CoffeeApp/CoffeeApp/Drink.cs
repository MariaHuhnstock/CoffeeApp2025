using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp
{
    public class Drink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Drink(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
