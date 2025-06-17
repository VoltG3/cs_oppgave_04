using Models;

namespace cs_oppgave_04.Helpers;

public static class Globals
{
    //public static bool exitProgram = false;
    //public static bool originatorMenuExitRequest = false;
    //
    public static int selectedOriginatorIndex = 0;
    public static int selectedYearIndex = 0;
    public static int selectedPriceIndex = 0;
    //
    //public static bool originatorActive = false;
    //public static bool yearActive = false;
    //
    //public static string[]? uniqueOriginators = [];
    //public static string[]? uniqueYears = [];
    //public static string[]? uniquePrice = ["Unsorted", "Low to High", "High to Low"];

    /*
    public static void SetUniqueOriginators(List<ProductModel> filteredList)
    {
        uniqueOriginators = filteredList
            .Select(p => p.Model.Split(" ")[0])
            .Distinct()
            .OrderBy(o => o)
            .Prepend("All")
            .ToArray();
    }
    */
    
    /*
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
    
    */
}