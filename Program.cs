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
        
        while (!Globals.exitProgram)
        {
            
            var allProducts = controller.GetAllProducts();
            Globals.SetUniqueOriginators(allProducts);
            var selectedOriginator = Menu.Originator();
            Console.WriteLine("\n");
            var filteredList = controller.GetByOriginator(selectedOriginator);
            
            Globals.SetUniqueYears(filteredList);
            var selectedUniqueYear = Menu.SelectYear();
            Console.WriteLine("\n");
            var filteredProducts = controller.GetByYear(selectedOriginator, selectedUniqueYear);
            
            Print.ProductTable(filteredProducts);
            
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue..."); Console.ReadKey(true);
            Globals.originatorMenuExitRequest = false;
        }
    }
}