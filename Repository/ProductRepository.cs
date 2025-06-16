using Models;

namespace Repository;

public class ProductRepository
{
    private readonly List<ProductModel> products = new();

    public ProductRepository(string csvPath)
    {
        if (File.Exists(csvPath))
        {
            var lines = File.ReadAllLines(csvPath).Skip(1);
            
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    products.Add(new ProductModel
                    {
                        Id = products.Count + 1, // Generate ID
                        Name = parts[0],
                        Price = decimal.TryParse(parts[12], out var price) ? price : decimal.Parse(parts[13])
                    });
                }
            }
        }
    }
    
    public List<ProductModel> GetAllProducts() => products;
}