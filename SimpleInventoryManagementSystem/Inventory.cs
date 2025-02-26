
using System;
using SimpleInventoryManagementSystem;


namespace SimpleInventoryManagementSystem;
public class Inventory
{
    private List<Product> _products;
    private const string _currency="$";
    private InputLogger _input;

    public Inventory(ICollection<Product> products)
    {
        _products = (List<Product>) products;
        _input = new InputLogger();
    }

    public  void AddProduct()
    {
        Product product=_input.ProductInput();
        _products.Add(product);
    }

    public void ViewProducts()
    {
        Console.WriteLine("The menu of products : ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Name is : {product._name}, Price is: {product._price} {_currency}, Quantity is: {product._quantity}");
        }

        Console.WriteLine("==========================");

    }

}
