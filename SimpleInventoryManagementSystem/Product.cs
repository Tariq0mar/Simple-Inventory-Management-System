
using System;

namespace SimpleInventoryManagementSystem;

public class Product
{
    public string _name { get; set; }
    public float _price { get; set; }
    public int _quantity { get; set; }

    public Product(string name, float price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
    }
}
