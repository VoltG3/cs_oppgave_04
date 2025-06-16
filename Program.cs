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
            
            var targetOriginator = Menu.Originator();
            Console.WriteLine("\n");
            var filtered = controller.GetByOriginator(targetOriginator);
            Print.ProductTable(filtered);
            
            
            var uniqueYears = filtered
                .Select(p => p.ReleaseYear)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
            
            Console.WriteLine("\n");
            foreach (var year in uniqueYears)
            {
                Console.WriteLine($"Year: {year}");
            }
            
            Console.WriteLine("Press any key to continue..."); Console.ReadKey(true);
            Globals.originatorMenuExitRequest = false;
           
            // Other menu
            // Other menu
        }
        
        
    }
}