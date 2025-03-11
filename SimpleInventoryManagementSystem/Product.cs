using System;

namespace SimpleInventoryManagementSystem;

public class Product
{
    public string Name { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, float price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
