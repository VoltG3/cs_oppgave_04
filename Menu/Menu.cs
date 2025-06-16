using cs_oppgave_04.Helpers;

namespace cs_oppgave_04;

public class Menu
{
    public static void Originator()
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
                    case "Agfa": 
                        Console.WriteLine("\n");
                        Console.WriteLine("Agfa");
                        Console.ReadKey(true);
                        Globals.originatorMenuExitRequest = true;
                        break;
                    case "Cannon": 
                        Console.WriteLine("Cannon");
                        break;
                    case "Casio": 
                        Console.WriteLine("Casio");
                        break;
                    case "Contax": 
                        Console.WriteLine("Contax");
                        break;
                    case "Epson": 
                        Console.WriteLine("Epson");
                        break;
                    case "Fujifilm": 
                        Console.WriteLine("Fujifilm");
                        break;
                    case "HP": 
                        Console.WriteLine("HP");
                        break;
                    case "JVC": 
                        Console.WriteLine("JVC");
                        break;
                    case "Kodak": 
                        Console.WriteLine("Kodak"); 
                        break;
                    case "Kyocera": 
                        Console.WriteLine("Kyocera");
                        break;
                    case "Leica": 
                        Console.WriteLine("Leica");
                        break;
                    case "Nikon": 
                        Console.WriteLine("Nikon");
                        break;
                    case "Olympus": 
                        Console.WriteLine("Olympus");
                        break;
                    
                }
            }
            
           
            // BTN - Q
            else if (key.Key == ConsoleKey.Q)
            {
                break;
            } 
        }
    }
}