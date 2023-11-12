string[] cards = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack (value 10)", "queen (value 10)", "king (value 10)", "ace (value 1 or 10)" },
drawnP = { },
drawnD = { };
int drawNr = 0;
int[] cardValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 0 };
Random rnd = new Random();

void drawP()
{
    Array.Resize(ref drawnP, drawNr + 1); // resize drawn cards array
    drawnP[drawNr] = cards[rnd.Next(cards.Length)]; // draw a random card
    Console.WriteLine($"you draw a card: {drawnP[drawNr]}");
    drawNr++;
}
void drawD()
{
    Array.Resize(ref drawnD, drawNr + 1); // resize drawn cards array
    drawnP[drawNr] = cards[rnd.Next(cards.Length)]; // draw a random card
    Console.WriteLine($"you draw a card: {drawnD[drawNr]}");
    drawNr++;
}

Console.WriteLine("you will now draw 2 cards");
drawP();
drawP();