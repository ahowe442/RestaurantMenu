using System;

namespace RestauraantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new intance of Menu
            //      In C#, you can use 'var' instead of the type name and it will guess
            //      or you can explicitly name the type, like 'Menu menu = new Menu()'
            var menu = new Menu();

            // The $"" here is called "string interpolation", as a way to format strings with variables
            Console.WriteLine($"Welcome to My Menu! It was last updated: {menu.LastUpdated}\n");

            // Loop through each item in the menu and print each property out
            foreach (MenuItem item in menu.MenuItems)
            {
                Console.WriteLine($"Item: {item.Description}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Is New: {item.IsNew}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("Thanks for visiting!");
        }
    }
}
