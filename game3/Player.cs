namespace game3
{
    public class Player : Fighter
    {
        public Player()
        {
            Console.WriteLine("name your fighter!");
            name = Utilities.userInput();
        }

        public override void takeAction()
        {
            Console.WriteLine("[a]ttack/[d]odge/[h]eal/[s]pell");
            for (; ; )
            {
                string s = Utilities.userInput();
                if (Utilities.options.Contains(s))
                {
                    action = s;
                    break;
                }

                Utilities.invalidInput();
            }
        }
    }
}
