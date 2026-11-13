using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp
{
    internal class Order
    {
        public List<Drink> Drinks { get; set; } = new List<Drink>();

        public void AddDrink(Drink drink)
        {
            Drinks.Add(drink);
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var drink in Drinks)
            {
                // Assuming Drink has a Price property
                total += drink.Price;
            }
            return total;
        }

        public void ShowOrder()
        {
            Console.WriteLine("Order Details:");
            foreach (var drink in Drinks)
            {
                Console.WriteLine($"- {drink.Name}: ${drink.Price}");
            }
            Console.WriteLine($"Total: ${GetTotal()}");
        }
    }
}
