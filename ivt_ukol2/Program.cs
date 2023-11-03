//declarations
string unum;
string cont = "r";
double A, B;
bool ps;

Console.WriteLine("> hello. this is a program for solving x in Ax+B=0.\n> please enter the number \"A\":");
do
{

    //get first number/////////////////////////////////////////////////////////////////////////////////////////////////////
    do
    {
        unum = Console.ReadLine();
        ps = double.TryParse(unum, out A);
        if (!ps)
        {
            Console.WriteLine("> that's not a number. enter a number:");
        }
    } while (!ps);

    //get second number/////////////////////////////////////////////////////////////////////////////////////////////////////
    Console.WriteLine("> enter the number \"B\":");
    do
    {
        unum = Console.ReadLine();
        ps = double.TryParse(unum, out B);
        if (!ps)
        {
            Console.WriteLine("> that's not a number. enter a number:");
        }
    } while (!ps);


    switch (A)
    {
        case 0:
            switch (B)
            {
                case 0:
                    Console.WriteLine("> the equation has infinite answers");
                    break;
                default:
                    Console.WriteLine("> the equation has no answer");
                    break;
            }
            break;
        default:
            Console.Write("x = ");
            Console.WriteLine((-B) / A);
            break;
    }


    //repeat/////////////////////////////////////////////////////////////////////////////////////////////////////
    Console.WriteLine("> do you want to repeat the program? (\"r\" to repeat, enter to exit)");
    cont = Console.ReadLine();
    if (cont == "r") { Console.WriteLine("> repeating program...\n> please enter a number:"); }
} while (cont == "r");

Console.WriteLine("> thank you for using our services. goodbye!");
Environment.Exit(0);

//probably dont need this??