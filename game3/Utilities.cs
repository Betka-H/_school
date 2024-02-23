public class Utilities
{
    public static Random rnd = new Random();
    public static string options = "adhs";

    public static string userInput()
    {
        for (; ; )
        {
            string s = Console.ReadLine().ToLower().Trim();
            if (!string.IsNullOrEmpty(s))
                return s;
            invalidInput();
        }
    }

    public static void invalidInput()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("invalid input!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void patc()
    {
        Console.WriteLine("> press anything to continue");
        Console.ReadKey();
    }
}
