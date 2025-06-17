namespace cs_oppgave_04.Helpers;

public class Dictionary
{
    private static readonly Dictionary<string, string> Menu = new()
    {
        { "originator", $" Choose an manufacturer : " },
        { "year", $" Choose a year          : " },
        { "price", $" Choose a price range   : " },
        { "u", $"Unknown" }
    };

    public static string GetMenuLabel(string key)
    {
        string menuCode = key switch
        {
            "originator" => "originator",
            "year" => "year",
            "price" => "price",
            _ => "u"
        };
        
        return Menu[menuCode];
    }
}