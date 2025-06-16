using Models;
using Helper;

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
                if (parts.Length >= 13)
                {
                    products.Add(new ProductModel
                    {
                        Id = products.Count + 1, // Generate ID
                        Model = parts[0],
                        ReleaseYear = Helper.Convert.ParseInt(parts[1]),
                        MaxResolution = Helper.Convert.ParseFloat(parts[2]),
                        LowResolution = Helper.Convert.ParseFloat(parts[3]),
                        EffectivePixels = Helper.Convert.ParseFloat(parts[4]),
                        ZoomWide = Helper.Convert.ParseFloat(parts[5]),
                        ZoomTele = Helper.Convert.ParseFloat(parts[6]),
                        NormalFocusRange = Helper.Convert.ParseFloat(parts[7]),
                        MacroFocusRange = Helper.Convert.ParseFloat(parts[8]),
                        StorageIncluded = Helper.Convert.ParseFloat(parts[9]),
                        Weight = Helper.Convert.ParseFloat(parts[10]),
                        Dimensions = Helper.Convert.ParseFloat(parts[11]),
                        Price = Helper.Convert.ParseDecimal(parts[12])
                    });
                }
            }
        }
    }
    
    public List<ProductModel> GetAllProducts() => products;
}