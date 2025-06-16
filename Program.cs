namespace cs_oppgave_04;

class Program
{
    static void Main(string[] args)
    {
        string path = "Data/camera_dataset.csv";
        var list = FileReader.ReadFile(path);

        if (list != null)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}