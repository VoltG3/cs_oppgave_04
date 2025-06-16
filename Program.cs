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
        Globals.SetUniqueOriginators(allProducts);
        
        while (!Globals.exitProgram)
        {
            Globals.originatorActive = false;
            
            // --------------------
            //  Chapter Originator
            // --------------------

            var selectedOriginator = MenuService.ShowSelectionMenu(
                Globals.uniqueOriginators, 
                "Select a camera manufacturer:", 
                ref Globals.selectedOriginatorIndex);
                
                Console.WriteLine("\n");
                var filteredList = controller.GetByOriginator(selectedOriginator);
            Globals.originatorActive = true;
            
            // --------------
            //  Chapter Year
            // --------------
            
            Globals.SetUniqueYears(filteredList);
            
            var selectedUniqueYear = MenuService.ShowSelectionMenu(Globals.uniqueYears, "Select production year:", ref Globals.selectedYearIndex);
            
            Console.WriteLine("\n");
            var filteredProducts = controller.GetByYear(selectedOriginator, selectedUniqueYear);
            Globals.yearActive = true;
            
            // Table
            Print.ProductTable(filteredProducts);
            
            // Repeat
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue..."); Console.ReadKey(true);
            Globals.originatorMenuExitRequest = false;
        }
    }
}