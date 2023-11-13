// variables
float a, b, c, D, userNumber;
string userString;

// functions
void detectAndTerminate()
{
    if (userString == "e")
    {
        Console.WriteLine("terminating program...");
        Environment.Exit(0);
    }
}
float getNumber()
{
    for (; ; )
    {
        userString = Console.ReadLine().ToLower();
        detectAndTerminate();
        if (float.TryParse(userString, out userNumber))
        {
            return userNumber;
        }
        Console.Write("that's not a number. please input a number: ");
    }
}
float x1()
{
    return MathF.Round((-b + MathF.Sqrt(D)) / (2 * a), 2);
}
float x2()
{
    return MathF.Round((-b - MathF.Sqrt(D)) / (2 * a), 2);
}

// main
for (; ; ) // more readable than while(true)??
{
    // number input
    Console.WriteLine("this program will solve ax^2 + bx + c = 0. input \"e\" at any time to exit");
    Console.Write("enter number a: ");
    a = getNumber();
    Console.Write("enter number b: ");
    b = getNumber();
    Console.Write("enter number c: ");
    c = getNumber();
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");

    // results
    if (a == 0 && b == 0 && c == 0)
    {
        Console.WriteLine($"there is an infinite amount of x values for {a} * x^2 + {b} * x + {c} = 0");
    }
    else
    {
        while (a == 0)
        {
            Console.Write("\"a\" cannot equal zero! please input a different number: ");
            a = getNumber();
        }

        D = MathF.Pow(b, 2) - 4 * a * c;
        switch (D)
        {
            case < 0:
                Console.WriteLine($"there is no answer for x in {a} * x^2 + {b} * x + {c} = 0");
                break;
            case 0:
                Console.WriteLine($"there is one answer for x in {a} * x^2 + {b} * x + {c} = 0: ");
                Console.WriteLine($"x = {x1()}");
                break;
            case > 0:
                Console.WriteLine($"there are two answers for x in {a} * x^2 + {b} * x + {c} = 0: ");
                Console.WriteLine($"x1 = {x1()}, x2 = {x2()}");
                break;
        }

        // x evaluation
        for (; ; )
        {
            Console.Write("enter parameter x for evaluation (or enter \"s\" to stop evaluating): ");
            userString = Console.ReadLine().ToLower();
            detectAndTerminate(); // detects "exit" keyword
            if (userString == "s")
            {
                break;
            }
            if (float.TryParse(userString, out userNumber))
            {
                Console.WriteLine($"the equation is {a} * {userNumber}^2 + {b} * {userNumber} + {c} = {MathF.Round(a * MathF.Pow(userNumber, 2) + b * userNumber + c, 2)}");
            }
            else
            {
                Console.Write("invalid input. please ");
            }
        }
    }

    // end
    for (; ; )
    {
        Console.Write("do you want to repeat the program? \"r\" to repeat, \"e\" to exit: ");
        userString = Console.ReadLine().ToLower();
        detectAndTerminate();
        if (userString == "r")
        {
            break;
        }
        Console.Write("invalid input; ");
    }
}