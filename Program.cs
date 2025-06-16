using Controllers;
using cs_oppgave_04.Helpers;
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
        
        //controller.ShowAll();
        
        while (!Globals.exitProgram)
        {

            Globals.originatorMenuExitRequest = false;
            Menu.Originator();
            // Other menu
            // Other menu
        }
        
        
    }
}