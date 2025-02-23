
using System;
using ISimpleInventoryManagementSystem;

namespace ISimpleInventoryManagementSystem
{
    public class Inventory
    {
        private List<Product> _products;
        private string _currency="$";

        public Inventory()
        {
            _products = new List<Product>();
        }

        public  void AddProduct()
        {

            string input = "";
            Console.WriteLine("Adding new product to the inventory");

            Console.WriteLine("Enter name of the product");
            input = Console.ReadLine();
            string name = input;

            Console.WriteLine("Enter price of the product");
            input = Console.ReadLine();
            float.TryParse(input, out float price);

            Console.WriteLine("Enter quantity of the product");
            input = Console.ReadLine();
            int.TryParse(input, out int quantity);

            Console.WriteLine("==========================");

            AddProduct1(name, price, quantity);
        }
        public void AddProduct1(string name, float price, int quantity)
        {
            Product newProduct = new Product(name, price, quantity);

            _products.Add(newProduct);
        }


        public void Display()
        {
            Console.WriteLine("The menu of products : ");
            foreach (Product product in _products)
            {
                Console.WriteLine($"Name is : {product.Name}, Price is: {product.Price} {_currency}, Quantity is: {product.Quantity}");
            }

            Console.WriteLine("==========================");

        }

    }
}
