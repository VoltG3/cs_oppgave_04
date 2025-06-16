using Models;
using Repository;

namespace Services;

public class ProductService
{
    private readonly ProductRepository repository;

    public ProductService(ProductRepository repository)
    {
        this.repository = repository;
    }
    
    public List<ProductModel> GetAllProducts() => repository.GetAllProducts();
}