// kvadraticka rovnice
// ax^2 + bx + c = 0
// x1,2 = +-Vb^2-4ac / 2a
// b^2-4ac >= 0
// uzivatel zada a, b, c
// pouzit funkci!
// na odmocninu V knihovna Math.Sqrt(69); MathF for floats
// poslat odkaz na github

string userString;
bool success;
float a, b, c, x, D;

// gets user input, specifically a number
float userNumber()
{
    float userNumber;
    do
    {
        userString = Console.ReadLine().ToLower();
        if (userString == "exit")
        {
            terminate();
        }
        success = float.TryParse(userString, out userNumber);
        if (!success)
        {
            Console.Write("that's not a number. please input a number: ");
        }
    } while (!success);
    return userNumber;
}
// terminates the program
void terminate()
{
    Console.WriteLine("terminating program...");
    Environment.Exit(0);
}

//// main
start:
Console.WriteLine("enter parameters for ax^2 + bx + c = 0. input \"exit\" at any time to terminate the program");
// inputs
Console.Write("enter parameter a: ");
a:
a = userNumber();
if (a == 0)
{
    Console.Write("\"a\" cannot equal zero! please input a different number: ");
    goto a;
}
Console.Write("enter parameter b: ");
b = userNumber();
Console.Write("enter parameter c: ");
c = userNumber();
if (b == 0 && c == 0)
{
    Console.WriteLine("there is an infinite amount of answers for \"x\"");
    goto exit;
}
// =0 calculations
D = MathF.Pow(b, 2) - 4 * a * c;
switch (D)
{
    case < 0:
        Console.WriteLine("there is no answer for x");
        goto exit;
    case 0:
        Console.WriteLine("there is one answer for x: ");
        Console.WriteLine("x = " + Math.Round(x = -b + MathF.Sqrt(D), 2));
        break;
    case > 0:
        Console.WriteLine("there are two answers for x: ");
        Console.WriteLine("x1 = " + Math.Round(x = (-b + MathF.Sqrt(D)) / 2 * a, 2));
        Console.WriteLine("x2 = " + Math.Round(x = (-b - MathF.Sqrt(D)) / 2 * a, 2));
        break;
}
// x evaluation
do
{
    Console.Write("enter parameter x for evaluation (enter \"stop\" to stop): ");
enterX:
    userString = Console.ReadLine().ToLower();
    if (userString == "stop")
    {
        goto exit;
    }
    if (userString == "exit")
    {
        terminate();
    }
    success = float.TryParse(userString, out x);
    if (!success)
    {
        Console.Write("that's not a number. please input a number: ");
        goto enterX;
    }
    Console.WriteLine($"the equation is {a}*{x}^2 + {b}*{x} + {c} = {Math.Round(a * MathF.Pow(x, 2) + b * x + c, 2)}");
} while (true);

// exit
exit:
Console.Write("do you want to repeat the program? y/n: ");
exitQ:
userString = Console.ReadLine().ToLower();
if (userString == "exit" || userString == "n")
{
    terminate();
}
else if (userString == "y")
{
    goto start;
}
else
{
    Console.WriteLine("invalid input : (y/n) expected.");
    goto exitQ;
}

// finished