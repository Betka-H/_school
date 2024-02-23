namespace game3
{
    public class AI : Fighter
    {
        public AI()
        {
            string[] aiNames =
            {
                "cheese",
                "wrench",
                "bob",
                "lord yoghurt the great",
                "lettuce",
                "bingus, emperor of death",
                "goober",
                "schmungus",
                "john foe"
            };
            name = aiNames[Utilities.rnd.Next(aiNames.Length)];
        }

        public override void takeAction()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("...");
                Thread.Sleep(Utilities.rnd.Next(500, 1000));
            }
            action = Utilities.options[Utilities.rnd.Next(Utilities.options.Length)].ToString();
        }
    }
}
