
using ISimpleInventoryManagementSystem;
using System;

namespace SimpleInventoryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            string input="";



            // 1) Adding new product into the inventory
            Console.WriteLine("Adding new product to the inventory");

            Console.WriteLine("Enter name of the product");
            input = Console.ReadLine();
            string name = input;

            Console.WriteLine("Enter name of the product");
            input = Console.ReadLine();
            float.TryParse(input, out float price);

            Console.WriteLine("Enter name of the product");
            input = Console.ReadLine();
            int.TryParse(input, out int quantity);

            inventory.AddProduct(name, price, quantity);


            // 2)

        }
    }
}
