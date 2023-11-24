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

