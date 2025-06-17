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
        //Globals.SetUniqueOriginators(allProducts);
        MenuState.SetUniqueOriginators(allProducts);
        
        while (!MenuState.ExitProgramState())
        {
            //Globals.originatorActive = false;
            MenuState.SetOriginatorMenuActiveState(false);
            //Globals.yearActive = false;
            MenuState.SetYearMenuActiveState(false);
            
            // --------------------
            //  Chapter Originator
            // --------------------

            var selectedOriginator = MenuService.ShowSelectionMenu(
                //Globals.uniqueOriginators, 
                MenuState.GetUniqueOriginators(),
                ref Globals.selectedOriginatorIndex);
                
                Console.WriteLine("\n");
                var filteredList = controller.GetByOriginator(selectedOriginator);
            MenuState.SetOriginatorMenuActiveState(true);
            //Globals.originatorActive = true;
            
            // --------------
            //  Chapter Year
            // --------------
            
            //Globals.SetUniqueYears(filteredList);
            MenuState.SetUniqueYears(filteredList);
            var selectedUniqueYear = MenuService.ShowSelectionMenu(
                //Globals.uniqueYears, 
                MenuState.GetUniqueYears(),
                ref Globals.selectedYearIndex);
            
                Console.WriteLine("\n");
                var filteredProducts = controller.GetByYear(selectedOriginator, selectedUniqueYear);
            //Globals.yearActive = true;
            MenuState.SetYearMenuActiveState(true);
            
            // ---------------
            //  Chapter Price
            // ---------------

            var selectedPrice = MenuService.ShowSelectionMenu(
                //Globals.uniquePrice, 
                MenuState.UniquePrice,
                ref Globals.selectedPriceIndex);;
            
                Console.WriteLine("\n");
                switch (selectedPrice)
                {
                    case "Low to High": filteredProducts = controller.GetByPriceAscending(selectedOriginator, selectedUniqueYear); break;
                    case "High to Low": filteredProducts = controller.GetByPriceDecending(selectedOriginator, selectedUniqueYear); break;
                }
                
            // Print Table
            Print.ProductTable(filteredProducts);
            
            Console.WriteLine("\n");
            Console.WriteLine("Press 'space' to continue or 'q' to exit.");
            
            var keyInfo = Console.ReadKey(true);
            
            // Exit
            if (keyInfo.Key == ConsoleKey.Q)
            {
                //Globals.originatorMenuExitRequest = true;
                MenuState.SetExitProgramState(true);
                break;
            }
            
            // Repeat
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                MenuState.SetExitProgramState(false);
                //Globals.originatorMenuExitRequest = false;
            }
        }
    }
}