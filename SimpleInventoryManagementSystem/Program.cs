using System;
using SimpleInventoryManagementSystem;

namespace SimpleInventoryManagementSystem;

public class Program
{
    enum Services
    {
        Exit = 0,
        AddProduct = 1,
        ViewProducts = 2
    }

    public static void PrintServices()
    {
        Console.WriteLine("Choose The number of service you want from our menu bellow");
        foreach (var service in Enum.GetValues(typeof(Services)))
        {
            Console.WriteLine($"{service} is {(int)service}");
        }
    }

    public static void Main(string[] args)
    {
        var inventory = new Inventory(new List<Product>());

        while (true)
        {
            PrintServices();

            var input = Console.ReadLine();
            if (!Enum.TryParse<Services>(input, out var option))
            {
                Console.WriteLine("Invalid input. Please try again");
                continue;
            }

            switch (option)
            {
                case Services.Exit:
                    Console.WriteLine("Goodbye, have a nice day!");
                    return;

                case Services.AddProduct:
                    inventory.AddProduct();
                    break;

                case Services.ViewProducts:
                    inventory.ViewProducts();
                    break;

                default:
                    Console.WriteLine("Unfound service, try again");
                    break;
            }
        }
    }
}

