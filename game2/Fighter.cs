namespace game2
{
    public class Fighter
    {
        protected string name;
        private int maxhp; // max hp
        private int hp;
        private int dmg; // damage
        private bool rage;
        protected bool dodge;

        public Fighter() // gets called right away
        {
            maxhp = utilities.rnd.Next(12, 21);
            hp = maxhp;
            dmg = utilities.rnd.Next(3, 7);
        }

        public virtual string takeTurn()
        {
            return "";
        }

        public void gainHp(int gain)
        {
            if (!dodge)
                // use negative numbers for loss
                hp += gain;
        }

        public void printStats()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(
                $"name: {name}\nmax health: {maxhp}\ncurrent health: {hp}\ndamage: {dmg}\nenraged? {rage}"
            );
            Console.WriteLine("-------------------------------");
        }

        public virtual string action()
        {
            return "";
        }

        public void TakeTurn(string action)
        {
            Console.Write(name + " ");
            switch (action)
            {
                case "a":
                    Console.WriteLine($"attacks with {dmg} damage!");
                    // cause actual damage
                    if (rage)
                    {
                        utilities.queueDmg = dmg * 2;
                        rage = false;
                    }
                    utilities.queueDmg = dmg;
                    break;
                case "d":
                    dodge = true;
                    Console.WriteLine("dodges, evading all incoming melee damage!");
                    break;
                case "h":
                    int heal = 0;
                    for (int i = 0; i < 3 && hp + heal < maxhp; i++)
                        heal++;
                    gainHp(heal);
                    Console.WriteLine($"heals, regaining {heal} hp!"); // tmp value
                    break;
                case "r":
                    rage = true;
                    Console.WriteLine(
                        "rages, automatically melee attacking twice on their next turn!"
                    );
                    break;
                case "s":
                    Console.WriteLine("casts a spell for half damage, ignoring any dodges!");
                    utilities.queueDmg = dmg / 2;
                    break;
            }
        }
    }
}
