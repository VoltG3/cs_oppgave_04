using cs_oppgave_04.Helpers;

namespace cs_oppgave_04;

public static class MenuService
{
    public static string ShowSelectionMenu(string[] options, string title, ref int selectedIndex)
    {
        while (!Globals.originatorMenuExitRequest)
        {
            Console.Clear();
            if (Globals.originatorActive)
            {
                var targetIndex = Globals.selectedOriginatorIndex;
                ShowFakeMenu(Globals.uniqueOriginators, "t", targetIndex);
            }
            
            //Console.WriteLine(title);
            Console.WriteLine();

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{(char)160}{options[i]}{(char)160}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write($"{(char)160}{options[i]}{(char)160}");
                }
            }

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                    break;
                
                case ConsoleKey.RightArrow:
                    selectedIndex = (selectedIndex + 1) % options.Length;
                    break;
                
                case ConsoleKey.Enter:
                    return options[selectedIndex];
                
                case ConsoleKey.Q:
                    return null;
            }
        }

        return null;
    }
    
    public static void ShowFakeMenu(string[] foptions, string title, int fselectedIndex)
    {
       
        //Console.WriteLine(title); 
        Console.WriteLine();

        for (int i = 0; i < foptions.Length; i++)
        { 
            if (i == fselectedIndex)
            { 
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.BackgroundColor = ConsoleColor.DarkBlue; 
                Console.Write($"{(char)160}{foptions[i]}{(char)160}"); 
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{(char)160}{foptions[i]}{(char)160}");
            }
        }
    }
}