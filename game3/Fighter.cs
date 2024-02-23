namespace game3
{
    public class Fighter
    {
        protected string name;
        public int hpMax;
        public int hp;
        private int dmg;
        public string action;
        public bool dodge;
        public bool rage;
        public int wins = 0;

        public Fighter() // gets called right away
        {
            hpMax = Utilities.rnd.Next(12, 21);
            hp = hpMax;
            dmg = Utilities.rnd.Next(3, 7);
        }

        public string getName()
        {
            return name;
        }

        public string getAction()
        {
            return action;
        }

        public void gainHp(int gain)
        {
            // use negative numbers for loss
            hp += gain;
        }

        public void attack(Fighter target)
        {
            Console.WriteLine($"attacks with {dmg} damage!");
            if (target.dodge)
            {
                Console.WriteLine(target.getName() + " dodges the attack!");
                target.dodge = false;
            }
            else
            {
                target.gainHp(-dmg);
                Console.WriteLine($"{target.getName()} loses {dmg} hp!");
            }
        }

        public void cast(Fighter target)
        {
            target.gainHp(-dmg / 2);
            Console.WriteLine($"{target.getName()} loses {dmg / 2} hp!");
        }

        public void printStats()
        {
            Console.WriteLine($"{name}: hp: {hp}/{hpMax}, dmg: {dmg}");
        }

        public void reset()
        {
            hp = hpMax;
            rage = false;
        }

        public virtual void takeAction()
        {
            //
        }
    }
}
