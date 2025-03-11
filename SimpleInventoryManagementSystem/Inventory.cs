using SimpleInventoryManagementSystem;

public class Inventory
{
    private List<Product> products;
    private const string Currency = "$";
    private readonly InputLogger input = new InputLogger();

    public Inventory(ICollection<Product> products)
    {
        this.products = products.ToList();
    }

    public void AddProduct()
    {
        Product product = input.ProductInput();
        products.Add(product);
    }

    public void ViewProducts()
    {
        Console.WriteLine("The menu of products:");
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price} {Currency}, Quantity: {product.Quantity}");
        }
        Console.WriteLine("==========================");
    }
}
