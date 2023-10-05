//dec
bool startgame = false;
bool alive = true;

Console.WriteLine("> hello person! ready to enter the game?\n>> (y/n)");
do
{
    string yn = Console.ReadLine();
    if (yn == "y")
    {
        Console.WriteLine("> got it.");
        startgame = true;
    }
    else if (yn == "n")
    {
        Console.WriteLine("> alright... ready now?\n>> (y/n)");
    }
    else if (yn != "y" || yn != "n")
    {
        Console.WriteLine("> invalid input :(\n>> (y/n)");
    }
}
while (!startgame);
Console.WriteLine("> let's begin.");

do
{

}
while (alive);