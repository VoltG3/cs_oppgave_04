namespace Helper;

public class Convert
{
    public static float ParseFloat(string value)
    {
        return float.TryParse(value, out var result) ? result : 0f;
    }
    
    public static int ParseInt(string value)
    {
        return int.TryParse(value, out var result) ? result : 0;
    }
    
    public static decimal ParseDecimal(string value)
    {
        return decimal.TryParse(value, out var result) ? result : 0m;
    }
}