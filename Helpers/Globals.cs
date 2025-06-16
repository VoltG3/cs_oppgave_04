using Models;

namespace cs_oppgave_04.Helpers;

public static class Globals
{
    public static bool exitProgram = false;
    public static int selectedIndex = 0; 
    public static bool originatorMenuExitRequest = false;
    //
    public static string[]? uniqueOriginators = [];
    public static string[]? uniqueYears = [];

    public static void SetUniqueOriginators(List<ProductModel> filteredList)
    {
        uniqueOriginators = filteredList
            .Select(p => p.Model.Split(" ")[0])
            .Distinct()
            .OrderBy(o => o)
            .Prepend("All")
            .ToArray();
    }
    
    public static void SetUniqueYears(List<ProductModel> filteredList)
    {
        uniqueYears = filteredList
            .Select(p => p.ReleaseYear)
            .Distinct()
            .OrderBy(y => y)
            .Select(y => y.ToString())
            .Prepend("All")
            .ToArray();
    }
}