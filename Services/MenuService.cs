using cs_oppgave_04.Helpers;

namespace cs_oppgave_04;

public static class MenuService
{
    public static string ShowSelectionMenu(string[] options, ref int selectedIndex)
    {
        while (!MenuState.ExitProgramState())
        {
            Console.Clear();
            if (MenuState.OriginatorMenuActiveState()) // Globals.originatorActive
            {
                var targetIndex = Globals.selectedOriginatorIndex;
                ShowFakeMenu(MenuState.GetUniqueOriginators(), targetIndex); //Globals.uniqueOriginators
            }

            if (MenuState.YearMenuActiveState()) // Globals.yearActive
            {
                var targetIndex = Globals.selectedYearIndex;
                ShowFakeMenu(MenuState.GetUniqueYears(), targetIndex); //Globals.uniqueYears
            }
            
            Console.WriteLine();

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
                    Console.Write($"{ (char)160 }{ options[i] }{ (char)160 }");
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
                    MenuState.SetExitProgramState(true);
                    return null;
            }
        }

        return null;
    }
    
    public static void ShowFakeMenu(string[] optionsState, int selectedIndexState)
    {
        Console.WriteLine();

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
                Console.Write($"{ (char)160 }{ optionsState[i] }{ (char)160 }");
            }
        }
    }
}