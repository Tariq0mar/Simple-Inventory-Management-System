using System;
using SimpleInventoryManagementSystem;


namespace SimpleInventoryManagementSystem;

public class InputLogger
{
    ProductFactory _productFactory;

    public InputLogger()
    {
        _productFactory = new ProductFactory();
    }

    public Product ProductInput()
    {
        var input = string.Empty;

        Console.WriteLine("Adding new product to the inventory");

        Console.WriteLine("Enter name of the product");
        input = Console.ReadLine();
        if(input is null)
        {
            throw new ArgumentException("invalid input");
        }
        var name = input;

        Console.WriteLine("Enter price of the product");
        input = Console.ReadLine();
        if(!float.TryParse(input, out float price))
        {
            throw new ArgumentException("invalid input");
        }

        Console.WriteLine("Enter quantity of the product");
        input = Console.ReadLine();
        if(!int.TryParse(input, out int quantity))
        {
            throw new ArgumentException("invalid input");
        }


        return _productFactory.CreateProduct(name, price, quantity);
    }
}
