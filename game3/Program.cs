using game3;

Console.Clear();

Fighter p1;
Fighter p2;

Console.WriteLine(
    "hello. please select game mode:\n> pvp (player vs player)\n> pvAI (player vs AI)\n> AIvAI (AI vs AI)"
);
for (; ; )
{
    string selection = Utilities.userInput();
    Console.Clear();

    switch (selection)
    {
        case "pvp":
        {
            p1 = new Player();
            p2 = new Player();
            game();
            break;
        }
        case "pvai":
        {
            p1 = new Player();
            p2 = new AI();
            game();
            break;
        }
        case "aivai":
        {
            p1 = new AI();
            p2 = new AI();
            game();
            break;
        }
        default:
            Utilities.invalidInput();
            break;
    }
}

void game()
{
    Console.Clear();
    Console.WriteLine("the fighter stats are:");
    while (p1.hp > 0 && p2.hp > 0)
    {
        p1.printStats();
        p2.printStats();
        Utilities.patc();

        static void takeTurn(Fighter p) // takes and shows action
        {
            Console.Clear();
            Console.WriteLine($"it is {p.getName()}'s turn!");
            p.takeAction();
        }

        takeTurn(p1);
        takeTurn(p2);

        Console.Clear();

        void playGame(Fighter p)
        {
            Fighter target = p;
            if (p == p1)
            {
                target = p2;
            }
            if (p == p2)
            {
                target = p1;
            }

            /* if (p.rage == true)
            {
                p.action = "a";
            } */

            void remberDodge(Fighter pp)
            /// achcually theres no need to rember it cause its already rembered
            {
                if (pp.getAction() == "d")
                    pp.dodge = true;
            }
            remberDodge(p);
            remberDodge(target);

            Console.Write(p.getName() + " ");
            switch (p.getAction())
            {
                case "a":
                    p.attack(target);

                    /* if (p.rage)
                    {
                        Console.WriteLine(
                            $"since {p.getName()} is enraged, they attack another time!"
                        );
                        if (target.dodge)
                        {
                            Console.WriteLine(target.getName() + " is taken by surprise!");
                        }
                        p.rage = false;
                        goto case "a";
                    } */

                    break;
                case "d":
                    Console.WriteLine("dodged, evading melee damage!");
                    break;
                case "h":
                    int heal = 0; // tmp value
                    for (int i = 0; i < 3 && p.hp + heal < p.hpMax; i++)
                        heal++;
                    p.gainHp(heal);
                    if (p.hp == p.hpMax)
                        Console.WriteLine("is already at max hp, thus not gaining any more hp!");
                    else
                        Console.WriteLine($"heals, regaining {heal} hp!");
                    break;
                /* case "r":
                    Console.WriteLine(
                        "rages, automatically melee attacking twice on their next turn!"
                    );
                    p.rage = true;
                break; */
                case "s":
                    Console.WriteLine("casts a spell for half damage, ignoring any dodges!");
                    p.cast(target);
                    break;
            }
        }

        playGame(p1);
        playGame(p2);
        p1.dodge = false;
        p2.dodge = false;
        for (int i = 0; i < Console.WindowWidth; i++)
            Console.Write('-');
        // Utilities.patc();
    }
    Console.WriteLine("game over!");
    if (p1.hp > p2.hp)
    {
        p1.wins++;
        Console.Write(p1.getName());
    }
    else
    {
        p2.wins++;
        Console.Write(p2.getName());
    }
    Console.WriteLine(" won!");
    Console.WriteLine($"{p1.getName()}: {p1.wins} wins");
    Console.WriteLine($"{p2.getName()}: {p2.wins} wins");
    Console.WriteLine("do you want to play another round? y/n");
    for (; ; )
    {
        switch (Utilities.userInput())
        {
            case "y":
                p1.reset();
                p2.reset();
                game();
                break;
            case "n":
                Environment.Exit(0);
                break;
            default:
                Utilities.invalidInput();
                break;
        }
    }
}
