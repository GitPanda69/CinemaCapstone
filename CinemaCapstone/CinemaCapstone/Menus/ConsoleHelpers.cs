namespace Capstone.Menus;

/// <summary>
///  This class provides helper methods for displaying menus and handling user input in the console.
/// </summary>
public static class ConsoleHelper
{
    /// <summary>
    ///  This method displays a menu with a title and a list of options, allowing the user to select an option by entering a number.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="options"></param>
    public static void RunMenu(string title, List<(string Label, Action Action)> options)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i].Label}");
            }

            Console.Write("\nSelect an option (1 - {0}): ", options.Count);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int selection) &&
                selection >= 1 && selection <= options.Count)
            {
                Console.Clear();
                options[selection - 1].Action.Invoke();
                break;
            }

            Console.WriteLine("\n❌ Invalid input. Press any key to try again...");
            Console.ReadKey();
        }
    }


    public static void Pause(string message = "Press any key to continue...")
    {
        Console.WriteLine($"\n{message}");
        Console.ReadKey();
    }
}