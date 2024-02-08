namespace game1
{
    public class functions
    {
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
    }
}
