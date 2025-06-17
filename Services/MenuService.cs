using cs_oppgave_04.Helpers;

namespace cs_oppgave_04;

public static class MenuService
{
    public static string ShowSelectionMenu(string[] options, ref int selectedIndex, string menuLabel)
    {
        while (!MenuState.ExitProgramState())
        {
            Console.Clear();
            if (MenuState.OriginatorMenuActiveState())
            {
                var targetIndex = MenuState.selectedOriginatorIndex;
                ShowFakeMenu(
                    MenuState.GetUniqueOriginators(), 
                    targetIndex, 
                    Dictionary.GetMenuLabel("originator"));
            }

            if (MenuState.YearMenuActiveState())
            {
                var targetIndex = MenuState.selectedYearIndex;
                ShowFakeMenu(
                    MenuState.GetUniqueYears(), 
                    targetIndex, 
                    Dictionary.GetMenuLabel("year"));
            }
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(menuLabel);
            Console.ResetColor();
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{ (char)160 }{ options[i] }{ (char)160 }");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue; 
                    Console.Write($"{ (char)160 }{ options[i] }{ (char)160 }");
                    Console.ResetColor();
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
            }
        }

        return null;
    }
    
    public static void ShowFakeMenu(string[] optionsState, int selectedIndexState, string menuLabel)
    {
        Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(menuLabel);
        Console.ResetColor();
        for (int i = 0; i < optionsState.Length; i++)
        { 
            if (i == selectedIndexState)
            { 
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.BackgroundColor = ConsoleColor.DarkBlue; 
                Console.Write($"{ (char)160 }{ optionsState[i] }{ (char)160 }"); 
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write($"{ (char)160 }{ optionsState[i] }{ (char)160 }");
                Console.ResetColor();
            }
        }
    }
}