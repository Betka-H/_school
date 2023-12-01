/* // fucktorial
static double getDbl()
{
    for (; ; )
    {
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            return x;
        }
        Console.Write("not an integer! please enter an integer: ");
    }
}
static double factorise(double n)
{
    double x = 1;
    for (int i = 1; i <= n; i++)
    {
        x = x * i;
    }
    return x;
}
for (; ; )
{
    Console.Write("please input an integer: ");
    double n = getDbl();
    Console.WriteLine($"{n}! = {factorise(n)}");
} */

// hadanka
int nMin = 1, nMax = 100;
Random rnd = new Random();
static int getInt()
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            return x;
        }
        Console.Write("not an integer! please enter an integer: ");
    }
}

for (; ; )
{
    int n = rnd.Next(nMin, nMax), attN = 5;
    Console.WriteLine($"(debug) the number is {n}");
    Console.Write($"guess a number from {nMin} to {nMax}: ");
    for (int a = 1; a <= attN; a++)
    {
        int userN = getInt();
        if (userN == n)
        {
            Console.WriteLine("suces! you guessed right");
            break;
        }
        else if (a >= attN)
        {
            Console.WriteLine("you ran out of attempts!");
            break;
        }
        else if (userN > n)
        {
            Console.Write("guess lower!: ");
        }
        else if (userN < n)
        {
            Console.Write("guess higher!: ");
        }
    }
}
