using cs_oppgave_04;
using Services;
using Spectre.Console;

namespace Controllers;

public class ProductController
{
    private readonly ProductService _service;
    
    public ProductController(ProductService service)
    {
        this._service = service;
    }

    public void ShowByOriginator(string targetOriginator)
    {
        var products = _service.GetAllProducts();
        var filters = new Filters();
        var filteredProducts = filters.GetProductByOriginator(products, targetOriginator);

        if (!filteredProducts.Any())
        {
            Console.WriteLine($"No products found for originator: { targetOriginator }");
            return;       
        }
        
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Model");
        table.AddColumn("Release Year");
        table.AddColumn("Max Resolution");
        table.AddColumn("Low Resolution");
        table.AddColumn("Effective Pixels");
        table.AddColumn("Zoom Wide");
        table.AddColumn("Zoom Tele");
        table.AddColumn("Normal Focus Range");
        table.AddColumn("Macro Focus Range");
        table.AddColumn("Storage Included");
        table.AddColumn("Weight");
        table.AddColumn("Dimensions");
        table.AddColumn("Price");
        
        foreach (var item in filteredProducts)
        {
            table.AddRow( 
                item.Id.ToString(), 
                item.Model, 
                item.ReleaseYear.ToString(),
                item.MaxResolution.ToString(),
                item.LowResolution.ToString(),
                item.EffectivePixels.ToString(),
                item.ZoomWide.ToString(),
                item.ZoomTele.ToString(),
                item.NormalFocusRange.ToString(),
                item.MacroFocusRange.ToString(),
                item.StorageIncluded.ToString(),
                item.Weight.ToString(),
                item.Dimensions.ToString(),
                item.Price.ToString()
                );
        }
        
        AnsiConsole.Write(table);
    }
}