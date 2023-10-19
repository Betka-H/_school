//declarations
using System.Runtime.CompilerServices;

string unum;
double n1, n2;
bool ps;
string repeat;

do
{
    Console.WriteLine(">> input \"exit\" to quit the program at any time\n\n> hello. please enter a number:");

    //get number 1 ////////////////////////////////////////////////////////////////////////////////////////////////////////
    do
    {
        unum = Console.ReadLine().ToLower();

        if (unum == "exit")
        {
            Console.WriteLine("> thank you for using our services. goodbye!");
            Environment.Exit(0);
        }

        ps = double.TryParse(unum, out n1);
        if (!ps)
        {
            Console.WriteLine("> that's not a number. enter a number:");
        }
    } while (!ps);

    Console.WriteLine("> enter a second number:");
    //get number 2 ////////////////////////////////////////////////////////////////////////////////////////////////////////
    do
    {
        unum = Console.ReadLine().ToLower();

        if (unum == "exit")
        {
            Console.WriteLine("> thank you for using our services. goodbye!");
            Environment.Exit(0);
        }

        ps = double.TryParse(unum, out n2);
        if (!ps)
        {
            Console.WriteLine("> that's not a number. enter a number:");
        }
    } while (!ps);


    //choose operation ////////////////////////////////////////////////////////////////////////////////////////////////////////
    Console.WriteLine("> add, subtract, multiply, divide, % or ^? (a/s/m/d/mo/p):");
    string operation;
    string[] opList = { "a", "s", "m", "d", "mo", "p" };
    bool opExists = false;
    do
    {
        operation = Console.ReadLine().ToLower();

        if (operation == "exit")
        {
            Console.WriteLine("> thank you for using our services. goodbye!");
            Environment.Exit(0);
        }

        if (opList.Contains(operation))
        {
            opExists = true;
        }
        if (!opExists)
        {
            Console.WriteLine("> invalid input. \"a\", \"s\", \"m\", \"d\", \"mo\" or \"p\" expected:");
        }
    } while (!opExists);

    //results ////////////////////////////////////////////////////////////////////////////////////////////////////////
    switch (operation)
    {
        case "a":
            Console.Write("> " + n1 + "+" + n2 + " = ");
            Console.WriteLine(n1 + n2);
            break;
        case "s":
            Console.Write("> " + n1 + "-" + n2 + " = ");
            Console.WriteLine(n1 - n2);
            break;
        case "m":
            Console.Write("> " + n1 + "*" + n2 + " = ");
            Console.WriteLine(n1 * n2);
            break;
        case "d":
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
            break;
        case "mo":
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
            break;
        case "p":
            Console.Write("> " + n1 + "^" + n2 + " = ");
            double pRes = 1;
            for (int i = 0; i < n2; i++)
                pRes = n1 * pRes;
            Console.WriteLine(pRes);


            break;
    }


    //repeat ////////////////////////////////////////////////////////////////////////////////////////////////////////
    Console.WriteLine("> do you wish to repeat the program?\n>> y/n");
    repeat = Console.ReadLine();
    if (repeat == "exit")
    {
        Console.WriteLine("> thank you for using our services. goodbye!");
        Environment.Exit(0);
    }
} while (repeat == "y");

Console.WriteLine("> thank you for using our services. goodbye!");