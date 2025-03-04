using System;
using SimpleInventoryManagementSystem;

namespace SimpleInventoryManagementSystem;

class ProductFactory
{
    public Product CreateProduct(string name, float price, int quantity)
    {
        return new Product(name, price, quantity);
    }
}
