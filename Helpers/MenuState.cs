using Models;

namespace cs_oppgave_04.Helpers;

public class MenuState
{
    public static int selectedOriginatorIndex = 0;
    public static int selectedYearIndex = 0;
    public static int selectedPriceIndex = 0;
    
 
    
    public static bool ExitProgram { get; set; }
    public static bool ExitProgramState() => ExitProgram;
    public static void SetExitProgramState(bool value) => ExitProgram = value;
    
    
    
    public static bool OriginatorMenuActive { get; set; }
    public static bool OriginatorMenuActiveState() => OriginatorMenuActive;
    public static void SetOriginatorMenuActiveState(bool value) => OriginatorMenuActive = value;
    
    
    
    public static bool YearMenuActive { get; set; }
    public static bool YearMenuActiveState() => YearMenuActive;
    public static void SetYearMenuActiveState(bool value) => YearMenuActive = value;
    
    
    
    public static string[]? uniqueOriginators = Array.Empty<string>();
    public static string[]? GetUniqueOriginators() => uniqueOriginators;
    public static void SetUniqueOriginators(List<ProductModel> filteredList)
    {
        uniqueOriginators = filteredList
            .Select(p => p.Model.Split(" ")[0])
            .Distinct()
            .OrderBy(o => o)
            .Prepend("All")
            .ToArray();
    }
    
    
    
    public static string[]? uniqueYears = Array.Empty<string>();
    public static string[]? GetUniqueYears() => uniqueYears;
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
    
    public static string[]? UniquePrice = ["Unsorted", "Low to High", "High to Low"];
}