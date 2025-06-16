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

    public List<ProductModel> GetAllProducts() => _service.GetAllProducts();
    
    public List<ProductModel> GetByOriginator(string targetOriginator)
    {
        var products = _service.GetAllProducts();
        var filters = new Filters();
        var filteredProducts = filters.GetProductByOriginator(products, targetOriginator);
        return filteredProducts;
    }
    
    public List<ProductModel> GetByYear(string targetOriginator, string targetYear)
    {
        var products = _service.GetAllProducts();
        var filters = new Filters();
        var filteredProducts = filters.GetProductByYear(products, targetOriginator, targetYear);
        return filteredProducts;
    }

    public List<ProductModel> GetByPriceAscending(string targetOriginator, string targetYear)
    {
        var products = _service.GetAllProducts();
        var filters = new Filters();
        var filteredProducts = filters.GetProductByPriceAscending(products, targetOriginator, targetYear);
        return filteredProducts;
    }

    public List<ProductModel> GetByPriceDecending(string targetOriginator, string targetYear)
    {
        var products = _service.GetAllProducts();
        var filters = new Filters();
        var filteredProducts = filters.GetProductByPriceDescending(products, targetOriginator, targetYear);
        return filteredProducts;
    }
}