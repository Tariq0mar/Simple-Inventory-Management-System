using System;
using SimpleInventoryManagementSystem;

public class Inventory
{
    private List<Product> _products;
    private const string Currency = "$";
    private readonly InputLogger _inputLogger = new InputLogger();

    public Inventory(ICollection<Product> products)
    {
        this._products = products.ToList();
    }

    public void AddProduct()
    {
        Product product = _inputLogger.ProductInput();
        _products.Add(product);
    }

    public void ViewProducts()
    {
        Console.WriteLine("The menu of products:");
        foreach (var product in _products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price} {Currency}, Quantity: {product.Quantity}");
        }
        Console.WriteLine("==========================");
    }
}
