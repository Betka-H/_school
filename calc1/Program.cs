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


//choose operation
Console.WriteLine("> add, subtract, multiply, divide, % or ^? (a/s/m/d/%/^):");
string ad;
bool adreal = false;
do
{
    ad = Console.ReadLine();
    if (ad == "a" || ad == "d" || ad == "s" || ad == "m" || ad == "%" || ad == "^")
    {
        adreal = true;
    }
    if (!adreal)
    {
        Console.WriteLine("> invalid input. \"a\", \"s\", \"m\", \"d\", \"%\" or \"^\" expected:");
    }
} while (!adreal);

//add
if (ad == "a")
{

    Console.Write("> " + n1 + "+" + n2 + " = ");
    Console.WriteLine(n1 + n2);

}
//subtract
else if (ad == "s")
{

    Console.Write("> " + n1 + "-" + n2 + " = ");
    Console.WriteLine(n1 - n2);

}

//multiply
else if (ad == "s")
{

    Console.Write("> " + n1 + "*" + n2 + " = ");
    Console.WriteLine(n1 * n2);

}

//divide
else if (ad == "d")
{

    if (n2 == 0)
    {
        Console.WriteLine("> critical error: cannot divide by 0. terminating program...");
        Environment.Exit(0);
    }
    else
    {
        Console.Write("> " + n1 + "/" + n2 + " = ");
        Console.WriteLine(n1 / n2);
    }
}

//this %
else if (ad == "%")
{

    if (n2 == 0)
    {
        Console.WriteLine("> critical error: cannot divide by 0. terminating program...");
        Environment.Exit(0);
    }
    else
    {
        Console.Write("> " + n1 + "%" + n2 + " = ");
        Console.WriteLine(n1 % n2);
    }
}

//this ^
if (ad == "%")
{

    Console.Write("> " + n1 + "^" + n2 + " = ");
    Console.WriteLine(n1 ^ n2);
}


Console.WriteLine("> thank you for using our services. goodbye!");