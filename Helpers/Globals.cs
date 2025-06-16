namespace cs_oppgave_04.Helpers;

public static class Globals
{
    public static bool exitProgram = false;
    
    public static int selectedIndex = 0; 
    public static bool originatorMenuExitRequest = false;
    public static string[] originators = [
        "Agfa", "Cannon", "Casio", "Contax", "Epson", 
        "Fujifilm", "HP", "JVC", "Kodak", "Kyocera", 
        "Leica", "Nikon", "Olympus", "Panasonic", 
        "Pentax", "Ricoh", "Samsung", "Sanyo", 
        "Sigma", "Sony", "Toshiba", "All"
    ];
}