using System.ComponentModel.DataAnnotations.Schema;
using Services;
using Spectre.Console;

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
        
        foreach (var item in products)
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

            /*
            Console.WriteLine($"" +
                              $"{ item.Id }: " +
                              $"{ item.Model }: " +
                              $"{ item.ReleaseYear }: " +
                              $"{ item.MaxResolution }: " +
                              $"{ item.LowResolution }: " +
                              $"{ item.EffectivePixels }: " +
                              $"{ item.ZoomWide }: " +
                              $"{ item.ZoomTele }: " +
                              $"{ item.NormalFocusRange }: " +
                              $"{ item.MacroFocusRange }: " +
                              $"{ item.StorageIncluded }: " +
                              $"{ item.Weight }: " +
                              $"{ item.Dimensions }: " +
                              $"{ item.Price }: ");
          */
        }
        
        AnsiConsole.Write(table);
    }
}
