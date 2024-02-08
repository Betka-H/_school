namespace game1
{
    public class Fighter
    {
        private string name;
        private int maxhp;
        private int maxdmg;
        private int hp;
        private int dmg;

        public Fighter(int hp, int dmg) // gets called right away
        {
            maxhp = hp;
            maxdmg = dmg;
            this.hp = hp;
            this.dmg = dmg;
        }

        public void nameFighter(string name)
        {
            this.name = name;
        }

        public void takeDmg(int dmgTaken)
        {
            hp -= dmgTaken;
        }

        public int TakeTurn(string action)
        {
            for (; ; )
            {
                switch (action)
                {
                    case "a":
                        Console.WriteLine($"{name} attacks with {dmg} damage!");
                        return dmg;
                    case "d":
                        Console.WriteLine($"{name} dodges, evading all incoming damage!");
                        return 0;
                    case "h":
                        Console.WriteLine($"{name} heals, regaining 5 hp!");
                        return 0;
                    case "r":
                        Console.WriteLine(
                            $"{name} rages, doubling their damage for the next turn!"
                        );
                        return 0;
                    case "s":
                        Console.WriteLine(
                            $"{name} casts a spell for half damage, ignoring any dodges!"
                        );
                        return dmg / 2;
                    default:
                        functions.invalidInput();
                        break;
                }
            }
        }

        internal void nameFighter(object aiNames)
        {
            throw new NotImplementedException();
        }
    }
}
