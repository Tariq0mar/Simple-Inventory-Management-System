
using System;
using ISimpleInventoryManagementSystem;

namespace ISimpleInventoryManagementSystem
{
    public class Inventory
    {
        private List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(string name, float price, int quantity)
        {
            Product newProduct = new Product(name, price, quantity);

            products.Add(newProduct);
        }

    }
}
