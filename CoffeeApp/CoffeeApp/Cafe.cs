using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace CoffeeApp
{
    internal class Cafe
    {
        public Cafe() 
        {
            var Espresso = new Drink("Espresso", 2.50m);
            var Latte = new Drink("Latte", 3.50m);
            var Cappuccino = new Drink("Cappuccino", 3.00m);
            var Mocha = new Drink("Mocha", 4.00m);

            Menu.Add(Espresso);
            Menu.Add(Latte);
            Menu.Add(Cappuccino);
            Menu.Add(Mocha);
        }

        public List<Drink> Menu = new List<Drink>();

        public void ShowMenu()
        {
            Console.WriteLine("Cafe Menu:");
            foreach (var drink in Menu)
            {
                Console.WriteLine($"- {drink.Name}: ${drink.Price}");
            }
        }

        public Drink GetDrinkByName(string name)
        {
            foreach (var drink in Menu)
            {
                if (drink.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return drink;
                }
            }
            return null;
        }
    }
}
