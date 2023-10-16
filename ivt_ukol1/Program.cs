//declarations
string unum;
double n1, n2;
bool ps;


Console.WriteLine("> hello. please enter a number:");

do
{
    unum = Console.ReadLine();
    ps = double.TryParse(unum, out n1);
    if (!ps)
    {
        Console.WriteLine("> that's not a number. enter a number:");
    }
} while (!ps);

Console.WriteLine("> enter a second number:");

do
{
    unum = Console.ReadLine();
    ps = double.TryParse(unum, out n2);
    if (!ps)
    {
        Console.WriteLine("> that's not a number. enter a number:");
    }
} while (!ps);

if (n1 > n2)
{
    Console.WriteLine(n1 + " is bigger than " + n2);
}

else if (n1 < n2)
{
    Console.WriteLine(n1 + " is smaller than " + n2);
}

else if (n1 == n2)
{
    Console.WriteLine(n1 + " equals " + n2);
}

Console.WriteLine("> thank you for using our services. goodbye!");