using Services;

namespace Controllers;

public class ProductController
{
    private readonly ProductService service;
    
    public ProductController(ProductService service)
    {
        this.service = service;
    }

    public void ShowAll()
    {
        var products = service.GetAllProducts();
        Console.WriteLine($"List of products:");

        if (!products.Any())
        {
            Console.WriteLine($"No products found.");
            return;       
        }
        
        foreach (var item in products)
        {
            Console.WriteLine($"{item.Id}: {item.Name} - {item.Price}");
        }
    }
}
