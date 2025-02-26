
using SimpleInventoryManagementSystem;
using System;

namespace SimpleInventoryManagementSystem;

public class Program
{
    enum Services{
        Exit,
        AddProduct,
        ViewProducts
    }

    public static void PrintServices()
    {
        Console.WriteLine("Choose The number of service you want from our menu bellow");
        foreach (Services service in Enum.GetValues(typeof(Services)))
        {
            Console.WriteLine($"{service} is {(int)service}");
        }
    }
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory(new List<Product>());

        while (true)
        {
            PrintServices();

            var input = Console.ReadLine();
            if (!int.TryParse(input,out int number))
            {
                throw new ArgumentException("invalid input");
            }

            switch (number)
            {
                case 0:
                    Console.WriteLine("Goodbye, have a nice day!");
                    break;

                case 1:
                    inventory.AddProduct();
                    break;

                case 2:
                    inventory.ViewProducts();
                    break;

                default:
                    Console.WriteLine("Unfound service, try again");
                    break;
            }

            if (number == 0)
            {
                break;
            }
        }
    }
}

