
using ISimpleInventoryManagementSystem;
using System;

namespace SimpleInventoryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();


            // 1) Adding new product into the inventory
            inventory.AddProduct();
            inventory.AddProduct();


            // 2) display menu of products
            inventory.Display();
        }
    }
}
