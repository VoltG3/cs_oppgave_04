using cs_oppgave_04.Helpers;
using Controllers;
using Repository;
using Services;

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
            controller.ShowByOriginator(targetOriginator);
            
            Console.WriteLine("Press any key to continue..."); Console.ReadKey(true);
            Globals.originatorMenuExitRequest = false;
           
            // Other menu
            // Other menu
        }
        
        
    }
}