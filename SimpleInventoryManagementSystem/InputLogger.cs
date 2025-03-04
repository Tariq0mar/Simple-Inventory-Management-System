using System;
using SimpleInventoryManagementSystem;

namespace SimpleInventoryManagementSystem;

public class InputLogger
{
    private readonly ProductFactory _productFactory = new ProductFactory();

    public string TryGetInput(string inputName)
    {
        string input;
        Console.WriteLine($"Please enter value of {inputName}:");
        do
        {
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"Invalid value for {inputName}, please try again.");
            }
        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }

    public T TryGetInput<T>(Func<string, T> inputParser, string inputName, Func<T, bool> check)
    {
        while (true) 
        {
            string input = TryGetInput(inputName);
            try
            {
                var value = inputParser(input);
                if (check(value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Invalid value for {inputName}, please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid {inputName}.");
            }
        }
    }

    public Product ProductInput()
    {
        Console.WriteLine("Adding new product to the inventory");

        string name = TryGetInput("name");
        float price = TryGetInput(float.Parse, "price", (float x) => x > 0);
        int quantity = TryGetInput(int.Parse, "quantity", (int x) => x >= 0);

        Product product = _productFactory.CreateProduct(name, price, quantity);
        return product;
    }
}
