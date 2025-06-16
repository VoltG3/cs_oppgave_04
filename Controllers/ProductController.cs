using cs_oppgave_04;
using Models;
using Services;

namespace Controllers;

public class ProductController
{
    private readonly ProductService _service;
    
    public ProductController(ProductService service)
    {
        _service = service;
    }

    public List<ProductModel> GetByOriginator(string targetOriginator)
    {
        var products = _service.GetAllProducts();
        var filters = new Filters();
        var filteredProducts = filters.GetProductByOriginator(products, targetOriginator);
        return filteredProducts;
    }
}