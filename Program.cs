using cs_oppgave_04.Helpers;
using Controllers;
using Repository;
using Services;
using Utilities;

namespace cs_oppgave_04;

class Program
{
    static void Main(string[] args)
    {
        var repository = new ProductRepository("Data/camera_dataset.csv");
        var service = new ProductService(repository);
        var controller = new ProductController(service);
        
        var allProducts = controller.GetAllProducts();
        MenuState.SetUniqueOriginators(allProducts);
        
        while (!MenuState.ExitProgramState())
        {
            MenuState.SetOriginatorMenuActiveState(false);
            MenuState.SetYearMenuActiveState(false);
            
            
            // --------------------
            //  Chapter Originator
            // --------------------

            
            var selectedOriginator = MenuService.ShowSelectionMenu(
                MenuState.GetUniqueOriginators(),
                ref MenuState.selectedOriginatorIndex,
                Dictionary.GetMenuLabel("originator"));
                
                Console.WriteLine("\n");
                var filteredList = controller.GetByOriginator(selectedOriginator);
            MenuState.SetOriginatorMenuActiveState(true);
           
            
            // --------------
            //  Chapter Year
            // --------------
            
            
            MenuState.SetUniqueYears(filteredList);
            var selectedUniqueYear = MenuService.ShowSelectionMenu(
                MenuState.GetUniqueYears(),
                ref MenuState.selectedYearIndex,
                Dictionary.GetMenuLabel("year"));
            
                Console.WriteLine("\n");
                var filteredProducts = controller.GetByYear(selectedOriginator, selectedUniqueYear);
            MenuState.SetYearMenuActiveState(true);
            
            
            // ---------------
            //  Chapter Price
            // ---------------

            
            var selectedPrice = MenuService.ShowSelectionMenu(
                MenuState.UniquePrice,
                ref MenuState.selectedPriceIndex,
                Dictionary.GetMenuLabel("price"));
            
                Console.WriteLine("\n");
                switch (selectedPrice)
                {
                    case "Low to High": filteredProducts = controller.GetByPriceAscending(selectedOriginator, selectedUniqueYear); break;
                    case "High to Low": filteredProducts = controller.GetByPriceDecending(selectedOriginator, selectedUniqueYear); break;
                }
                
            // Print Table
            Print.ProductTable(filteredProducts);
            
            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("'space'");
            Console.ResetColor();
            Console.Write(" to continue or ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("'q'");
            Console.ResetColor();
            Console.Write(" to exit.");
            
            var keyInfo = Console.ReadKey(true);
            
            // Exit
            if (keyInfo.Key == ConsoleKey.Q)
            {
                MenuState.SetExitProgramState(true);
                break;
            }
            
            // Repeat
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                MenuState.SetExitProgramState(false);
            }
        }
    }
}