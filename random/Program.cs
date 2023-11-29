Console.ForegroundColor = ConsoleColor.Gray;
/* // multiplies input number to 10
void colWrong() // wrong color
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void colNormal() // normal color
{
    Console.ForegroundColor = ConsoleColor.Gray;
}

float getFloat() // outputs a float, from user
{
    for (; ; )
    {
        if (float.TryParse(Console.ReadLine(), out float x))
        {
            return x;
        }
        colWrong();
        Console.Write("please enter a number: ");
        colNormal();
    }
}

Console.Write("enter a number: ");
float n = getFloat();
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{n} * {i} = {n * i}");
} */
/* // print card deck (inscryption-like in shape)
static int getPosInt() // positive int from user
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            if (x > 0)
            {
                return x;
            }
        }
        Console.Write("please enter an integer (> 0): ");
    }
}
static void printC()
{
    Console.Write("[]");
}

for (; ; )
{
    Console.Write("please enter the amount of cards: ");
    int cardN = getPosInt(); // number of cards to draw
    if (cardN <= 10) // change card limit for one row here!!
    {
        for (int i = 1; i <= cardN; i++) // only 1 line if less/equal than/to 8
        {
            printC();
        }
    }
    else
    {
        for (int i = 1; i <= cardN / 2; i++) // 1st line
        {
            printC();
        }
        Console.WriteLine();
        for (int y = cardN / 2 + 1; y <= cardN; y++) // 2nd line
        {
            printC();
        }
    }
    Console.WriteLine();
} */
