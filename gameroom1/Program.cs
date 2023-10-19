//begin intro



string userInput;

Console.WriteLine("> welcome! are you a person? (y/n)");
//yn
do
{
    userInput = Console.ReadLine().ToLower();
    switch (userInput)
    {
        case "y":
            break;
        case "n":
            Console.WriteLine("> err 503: user not a person...\n> terminating program...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("> invalid input : (y/n) expected.");
            Console.WriteLine("> are you a person?");
            break;
    }
} while (userInput != "y");



Console.WriteLine("> splendid! person, are you ready to enter the game?");
//yn
do
{
    userInput = Console.ReadLine().ToLower();
    switch (userInput)
    {
        case "y":
            break;
        case "n":
            Console.WriteLine("> alright\n> ...\n> ...\n> ...\n> ready now? (y/n)");
            break;
        default:
            Console.WriteLine("> invalid input : (y/n) expected.");
            Console.WriteLine("> are you ready to enter the game?");
            break;
    }
} while (userInput != "y");



Console.WriteLine("> got it. let's begin.\n");



//end intro
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//begin day



bool alive = true;
string time;

do
{
    time = "morning";

    //morning
    do
    {
        Console.WriteLine("morning stuff");

        time = "work";
    } while (time == "morning");

    //work
    do
    {
        //several types of work
        //1 - count up/down to 8-32 numbers
        //2 - sort stuff from categories - animals, clothes, seasons, sports, foods...
        //3 - write a letter - same mechanics as numbers ig??
        //4 - 
        //5 -
        //random number for each work
        //workx - work index
        Random rnd = new Random();
        int workx = rnd.Next(4);
        if (workx == 0)
        {
            Console.WriteLine("work 0");
        }
        else if (workx == 1)
        {
            Console.WriteLine("work 1");
        }
        else if (workx == 2)
        {
            Console.WriteLine("work 2");
        }
        else if (workx == 3)
        {
            Console.WriteLine("work 3");
        }
        else if (workx == 4)
        {
            Console.WriteLine("work 4");
        }




        Console.WriteLine("work stuff");

        time = "evening";
    } while (time == "work");

    //evening
    do
    {
        Console.WriteLine("evening stuff");

        time = "morning";
    } while (time == "evening");

    //exit confirmation///////////////////////////////////////////////////////////////////////////////////////
    Console.WriteLine("> do you want to go on? (y/n)");
    do
    {
        userInput = Console.ReadLine().ToLower();
        switch (userInput)
        {
            case "y":
                break;
            case "n":
                Console.WriteLine("> terminating program...\n> ...\n> ...\n> ...\n\ngoodbye, person.");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("> stop fooling around. (y/n). answer.");
                Console.WriteLine("do you want to go on?");
                break;
        }
    } while (userInput != "y");

} while (alive);