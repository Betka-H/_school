//declarations
int n1 = 0;
int n2 = 0;
string fb = "";

Console.WriteLine("> counting up...");

do
{

    if (n1 % 3 == 0 || n1 % 5 == 0)
    {



        Console.Write("fizz");
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

