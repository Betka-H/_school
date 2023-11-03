// kvadraticka rovnice
// ax^2 + bx + c = 0
// x1,2 = +-Vb^2-4ac / 2a
// b^2-4ac >= 0
// uzivatel zada a, b, c
// pouzit funkci!
// na odmocninu V knihovna Math.Sqrt(69); MathF for floats
// poslat odkaz na github
/*
Po zadání program vypíše rovnici, počet řešení a jaká jsou.
Program musí fungovat pro jakékoli koeficienty a, b, c (i necelé).
Následně program dovolí uživateli dosazovat do funkce hodnotu x, dokud uživatel nezadá ukončující vstup.
 */

bool repeat, yes = false, success;
string userString;
double a, b, c, x, D, result;

// gets user input, specifically a number
double userNumber()
{
    double userNumber;
    do
    {
        userString = Console.ReadLine().ToLower();
        terminate();
        success = double.TryParse(userString, out userNumber);
        if (!success)
        {
            Console.Write("that's not a number. please input a number: ");
        }
    } while (!success);
    return userNumber;
}
// terminate the program
void terminate()
{
    if (userString == "exit")
    {
        Console.WriteLine("terminating program...");
        Environment.Exit(0);
    }
}
// true/false depending on the user input (y/n)
bool yn()
{
    do
    {
        userString = Console.ReadLine().ToLower();
        terminate();
        switch (userString)
        {
            case "y":
                yes = true;
                success = true;
                break;
            case "n":
                yes = false;
                success = true;
                break;
            default:
                Console.WriteLine("invalid input : (y/n) expected.");
                success = false;
                break;
        }
    } while (!success);
    return yes;
}

Console.WriteLine("this program will solve ax^2 + bx + c = 0. input \"exit\" at any time to terminate the program");
do
{
    Console.Write("enter number a: ");
    a = userNumber();
    if (a == 0)
    {
        Console.Write("\"a\" cannot equal zero! please input a different number: ");
        a = userNumber();
    }
    Console.Write("enter number b: ");
    b = userNumber();
    Console.Write("enter number c: ");
    c = userNumber();
    D = Math.Pow(b, 2) - 4 * a * c;

    Console.WriteLine($"the equation is: {a}x^2 + {b}x + {c} = 0");

    if (b == 0 && c == 0)
    {
        Console.WriteLine("there is an infinite amount of answers for \"x\"");
    }

    switch (D)
    {
        case < 0:
            Console.WriteLine("there is no answer for \"x\"");
            break;
        case 0:
            Console.WriteLine("there is one answer for \"x\": ");

            break;
        case > 0:
            Console.WriteLine("there are two answers for \"x\": ");

            break;
    }


    Console.Write("do you want to repeat the program? y/n: ");
    repeat = yn();
} while (repeat);