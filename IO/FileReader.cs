using System.Text;

namespace cs_oppgave_04;

public class FileReader
{
    public static List<string> ReadFile(string path)
    {
        try
        {
            var csv = File.ReadAllLines(path, Encoding.UTF8);
            return csv.ToList();
        }
        
        catch (Exception e)
        {
            Console.WriteLine($"[!] Error: { e.Message }");
            return null;
        }
    }
}