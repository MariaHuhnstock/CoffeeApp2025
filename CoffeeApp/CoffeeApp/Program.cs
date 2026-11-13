using System;

namespace CoffeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe();
            Order order = new Order();

            while (true)
            {
                Console.WriteLine("Welcome to the Coffee App!");
                Console.WriteLine("1. View Menu");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. Show Order");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Show Menu
                        cafe.ShowMenu();
                        break;
                    case "2":
                        // Place Order
                        Console.Write("Enter drink name: ");
                        string inputName = Console.ReadLine();

                        var foundDrink = cafe.GetDrinkByName(inputName);

                        if (foundDrink == null)
                        {
                            Console.WriteLine("Drink not found!");
                        }
                        else
                        {
                            order.AddDrink(foundDrink);
                            Console.WriteLine("Drink added to order.");
                        }
                        break;
                    case "3":
                        // Show Order
                        order.ShowOrder();
                        break;
                    case "4":
                        // Checkout
                        Console.WriteLine($"Total amount due: ${order.GetTotal()}");
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
        }
    }
}