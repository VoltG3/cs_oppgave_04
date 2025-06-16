using cs_oppgave_04.Helpers;

namespace cs_oppgave_04;

public class Menu
{
    public static string Originator()
    {
        while (!Globals.originatorMenuExitRequest)
        {
            Console.Clear();
            Console.WriteLine("Select originator of camera:");
            for (int i = 0; i < Globals.originators.Length; i++)
            {
                if (i == Globals.selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{ (char)160 }{ Globals.originators[i] }{ (char)160 }");
                    Console.ResetColor();
                }

                else
                {
                    Console.Write($"{ (char)160 }{ Globals.originators[i] }{ (char)160 }");
                }
            }
            
            ConsoleKeyInfo key = Console.ReadKey(true);
                
            // BTN - Left
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Globals.selectedIndex = (Globals.selectedIndex - 1 + Globals.originators.Length) % Globals.originators.Length;
            }

            // BTN - Right
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Globals.selectedIndex = (Globals.selectedIndex + 1) % Globals.originators.Length;
            }
            
            // BTN - Enter
            else if (key.Key == ConsoleKey.Enter)
            {
                switch (Globals.originators[Globals.selectedIndex])
                {
                    case "Agfa": return "Agfa";
                    case "Cannon": return "Cannon";
                    case "Casio": return "Casio";
                    case "Contax": return "Contax";
                    case "Epson": return "Epson";
                    case "Fujifilm": return "Fujifilm";
                    case "HP": return "HP";
                    case "JVC": return "JVC";
                    case "Kodak": return "Kodak";
                    case "Kyocera": return "Kyocera";
                    case "Leica": return "Leica";
                    case "Nikon": return "Nikon";
                    case "Olympus": return "Olympus";
                    case "Panasonic": return "Panasonic";
                    case "Pentax": return "Pentax";
                    case "Ricoh": return "Ricoh";
                    case "Samsung": return "Samsung";
                    case "Sanyo": return "Sanyo";
                    case "Sigma": return "Sigma";
                    case "Sony": return "Sony";
                    case "Toshiba": return "Toshiba";   
                    case "All": return "All";
                    default: return "";
                }
            }
            
            // BTN - Q
            else if (key.Key == ConsoleKey.Q)
            {
                break;
            } 
        }

        return null;
    }
}