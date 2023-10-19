//declarations
string repeatprogram = "r";
string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

Console.WriteLine("> hello. this is a binary translator. input plain text or binary to start.");
do
{

    /* string value = "9quali52ty3";

    // Convert the string into a byte[].
    byte[] asciiBytes = Encoding.ASCII.GetBytes(value); */

    Console.Write("Enter the Decimal Number : ");
    int number = int.Parse(Console.ReadLine());
    int i;
    int[] numberArray = new int[10];
    for (i = 0; number > 0; i++)
    {
        numberArray[i] = number % 2;
        number = number / 2;
    }

    Console.Write("Binary Represenation of the given Number : ");
    for (i = i - 1; i >= 0; i--)
    {
        Console.Write(numberArray[i]);
    }
    Console.WriteLine();
    /* 

    //from binary
    hello world - 01101000 01100101 01101100 01101100 01101111 00100000 01110111 01101111 01110010 01101100 01100100
    to lower!







     */

    /* do
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
        Console.WriteLine("> " + n1 + " is bigger than " + n2);
    }

    else if (n1 < n2)
    {
        Console.WriteLine("> " + n1 + " is smaller than " + n2);
    }

    else if (n1 == n2)
    {
        Console.WriteLine("> " + n1 + " equals " + n2);
    } */

    Console.WriteLine("> do you want to repeat the program? (\"r\" to repeat, \"enter\" to exit)");
    repeatprogram = Console.ReadLine();
    if (repeatprogram == "r") { Console.WriteLine("> repeating program...\n> please enter a number:"); }
} while (repeatprogram == "r");

Console.WriteLine("> thank you for using our services. goodbye!");
Environment.Exit(0);