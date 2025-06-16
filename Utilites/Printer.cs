using Models;
using Spectre.Console;

namespace Utilities;

public static class Print
{
    public static void ProductTable(List<ProductModel> products, string? header = null)
    {
        if (!products.Any())
        {
            Console.WriteLine("No products to display.");
            return;
        }

        var table = new Table();

        if (!string.IsNullOrEmpty(header))
            table.Title = new TableTitle(header);

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
        }

        AnsiConsole.Write(table);
    }
}