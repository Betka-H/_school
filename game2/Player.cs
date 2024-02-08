namespace game2
{
    public class Player : Fighter
    {
        public Player()
        {
            Console.Write("name your fighter: ");
            name = utilities.userInput();
        }

        public override string action()
        {
            dodge = true;
            Console.WriteLine($"it is {name}'s turn!");
            Console.WriteLine("[a]ttack/[d]odge/[h]eal/[r]age/[s]pell");
            for (; ; )
            {
                string s = utilities.userInput();
                if (utilities.options.Contains(s))
                {
                    return s;
                }
                utilities.invalidInput();
            }
        }
    }
}
