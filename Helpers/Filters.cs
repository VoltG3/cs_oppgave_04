using Models;

namespace cs_oppgave_04;

public class Filters
{
    public List<ProductModel> GetProductByOriginator(List<ProductModel> products, string originator)
    {
        if (originator == "All") return products;
        
        return products
            .Where(p => p.Model.StartsWith(originator + " "))
            .ToList();
    }
    
    public List<ProductModel> GetProductByYear(List<ProductModel> products, string originator, string year)
    {
        if (year == "All") return products;

        return products
            .Where(p => p.Model.StartsWith(originator + " "))
            .Where(p => p.ReleaseYear.ToString() == year)
            .ToList();
    }
    
}