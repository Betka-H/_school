// 2p game
// each p has hp, dmg, actions - attack, wait

// add: p name, dodge instead of wait, heal, random range damage
// random damage: from range dmg +- like 25% of dmg

using game1;

Console.WriteLine(
    "hello. please select game mode:\n> pvp (player vs player)\n> pvAI (player vs AI)\n> AIvAI (AI vs AI)"
);

for (; ; )
{
    switch (functions.userInput())
    {
        case "pvp":
            playGame(2);
            break;
        case "pvai":
            playGame(1);
            break;
        case "aivai":
            playGame(0);
            break;
        default:
            functions.invalidInput();
            break;
    }
}

static void playGame(int players)
{
    Random rnd = new Random();
    string[] aiNames = { "cheese", "wrench", "bob", "lord yoghurt the great", "lettuce" };

    switch (players)
    {
        case 2:
        { // put in {} to make it a scope - otherwise p1 etc exists in the whole switch
            Console.WriteLine("player vs player");

            Fighter p1 = new Fighter(3, 5);
            Console.WriteLine("player 1, name your fighter!");
            p1.nameFighter(functions.userInput());

            Fighter p2 = new Fighter(5, 3);
            Console.WriteLine("player 2, name your fighter!");
            p2.nameFighter(functions.userInput());

            for (; ; )
            {
                Console.WriteLine("player 1, take your turn!");
                Console.WriteLine("[a]ttack/[d]odge/[h]eal/[r]age/[s]pell");
                p1.TakeTurn(functions.userInput());

                Console.WriteLine("player 2, take your turn!");
                Console.WriteLine("[a]ttack/[d]odge/[h]eal/[r]age/[s]pell");
                p2.TakeTurn(functions.userInput());
            }
        }

        case 1:
        {
            Console.WriteLine("player vs ai");

            Fighter p1 = new Fighter(3, 5);
            Console.WriteLine("player 1, name your fighter!");
            p1.nameFighter(functions.userInput());

            Fighter p2 = new Fighter(6, 2);
            p2.nameFighter(aiNames[rnd.Next(aiNames.Length)]);

            for (; ; )
            {
                Console.WriteLine("player, take your turn!");
                Console.WriteLine("[a]ttack/[d]odge/[h]eal/[r]age/[s]pell");
                p1.TakeTurn(functions.userInput());

                Console.WriteLine("the ai takes its turn!");
                p2.TakeTurn("adhrs"[rnd.Next(4)].ToString());
            }
        }
        case 0:
        {
            Console.WriteLine("ai vs ai");
            break;
        }
    }
}
