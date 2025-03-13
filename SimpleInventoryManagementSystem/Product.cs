using System;
namespace SimpleInventoryManagementSystem;

public class Product
{
    public required string Name { get; set; }
    public required float Price { get; set; }
    public required int Quantity { get; set; }

    public Product(string name, float price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
