//declarations
int n1 = 0;
int n2 = 0;

Console.WriteLine("> counting up...");

do
{
    if (n1 % 3 == 0 && n1 % 5 == 0)
    {
        Console.Write("fizzbuzz");
    }
    else if (n1 % 3 == 0)
    {
        Console.Write("fizz");
    }
    else if (n1 % 5 == 0)
    {
        Console.Write("buzz");
    }
    else
    {
        Console.Write(n1);
    }
    Console.WriteLine(" " + n2);


    n1 += 1;
    if (n2 != 2) n2++;
    else n2 = 0;

} while (n1 <= 50);


int sum;
for (int i = 0; i <= 20; i++)
{

    sum += i;
    Console.WriteLine(sum);

}