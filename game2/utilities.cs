namespace game2
{
    public class utilities : Fighter
    {
        public static Random rnd = new Random();
        public static string options = "adhrs";
        public static int activePlayer;
        public static int queueDmg;

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
