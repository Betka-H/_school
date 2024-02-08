namespace game2
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
                "bingus, emperor of death"
            };
            name = aiNames[utilities.rnd.Next(aiNames.Length)];
        }

        public override string action()
        {
            Console.WriteLine($"it is {name}'s turn!");
            return utilities.options[utilities.rnd.Next(utilities.options.Length)].ToString();
        }
    }
}
