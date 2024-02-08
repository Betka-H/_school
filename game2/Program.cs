// 2p game
// each p has hp, dmg, actions - attack, wait

// add: p name, dodge instead of wait, heal, random range damage
// random damage: from range dmg +- like 25% of dmg

using game2;

Console.WriteLine(
    "hello. please select game mode:\n> pvp (player vs player)\n> pvAI (player vs AI)\n> AIvAI (AI vs AI)"
);

Fighter p1;
Fighter p2;

for (; ; )
{
    switch (utilities.userInput())
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
            utilities.invalidInput();
            break;
    }
}

void game()
{
    for (; ; )
    {
        p1.printStats();
        p2.printStats();
        // [a]ttack/[d]odge/[h]eal/[r]age/[s]pell

        p1.TakeTurn(p1.action());
        p2.TakeTurn(p2.action());
    }
}
