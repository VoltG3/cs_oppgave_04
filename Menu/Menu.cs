using cs_oppgave_04.Helpers;

namespace cs_oppgave_04;

public class Menu
{
    public static string Originator()
    {
        while (!Globals.originatorMenuExitRequest)
        {
            Console.Clear();
            Console.WriteLine("Select release year:");

            for (int i = 0; i < Globals.uniqueOriginators.Length; i++)
            {
                if (i == Globals.selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{(char)160}{Globals.uniqueOriginators[i]}{(char)160}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write($"{(char)160}{Globals.uniqueOriginators[i]}{(char)160}");
                }
            }

            ConsoleKeyInfo key = Console.ReadKey(true);

            // Left Arrow
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Globals.selectedIndex = (Globals.selectedIndex - 1 + Globals.uniqueOriginators.Length) % Globals.uniqueOriginators.Length;
            }
            // Right Arrow
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Globals.selectedIndex = (Globals.selectedIndex + 1) % Globals.uniqueOriginators.Length;
            }
            // Enter
            else if (key.Key == ConsoleKey.Enter)
            {
                return Globals.uniqueOriginators[Globals.selectedIndex];
            }
            // Q to exit
            else if (key.Key == ConsoleKey.Q)
            {
                break;
            }
        }

        return null;
    }
    
    public static string SelectYear()
    {
        while (!Globals.originatorMenuExitRequest)
        {
            Console.Clear();
            Console.WriteLine("Select release year:");

            for (int i = 0; i < Globals.uniqueYears.Length; i++)
            {
                if (i == Globals.selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{(char)160}{Globals.uniqueYears[i]}{(char)160}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write($"{(char)160}{Globals.uniqueYears[i]}{(char)160}");
                }
            }

            ConsoleKeyInfo key = Console.ReadKey(true);

            // Left Arrow
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Globals.selectedIndex = (Globals.selectedIndex - 1 + Globals.uniqueYears.Length) % Globals.uniqueYears.Length;
            }
            // Right Arrow
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Globals.selectedIndex = (Globals.selectedIndex + 1) % Globals.uniqueYears.Length;
            }
            // Enter
            else if (key.Key == ConsoleKey.Enter)
            {
                return Globals.uniqueYears[Globals.selectedIndex];
            }
            // Q to exit
            else if (key.Key == ConsoleKey.Q)
            {
                break;
            }
        }

        return null;
    }

}