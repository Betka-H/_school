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
            Console.WriteLine("> err 401: user is not a person\n> terminating program...");
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
            Console.WriteLine("> err 204: user backed out...\n> terminating program...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("> invalid input : (y/n) expected.");
            Console.WriteLine("> are you ready to enter the game?");
            break;
    }
} while (userInput != "y");

Console.WriteLine("> got it. let's begin.\n\n> loading resources...\n> booting up...\n> done! 42 resources loaded. time taken: 152ms\n");



//end intro
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//begin day



Random rnd = new Random();
bool alive = true;
string time;
int dayCount = 0;

//day loop
do
{
    dayCount += 1;
    time = "morning";

    //morning
    do
    {
        Console.WriteLine("> day " + dayCount);

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
        Console.WriteLine("> module \"work\" loaded\n> press enter to begin working phase");
        Console.ReadLine();
        //global variables
        bool intParse;
        int workNumber = rnd.Next(1);//how many works to choose from

        int w12CountMin = 5;
        int w12CountMax = 32;
        //w1 variables
        int w1Goal, w1UserInt;
        string w1UserString;
        w1Goal = rnd.Next(w12CountMin, w12CountMax);
        int w1Track = 0;
        //w2 variables
        int w2Goal, w2UserInt;
        string w2UserString;
        w2Goal = rnd.Next(w12CountMin, w12CountMax);
        int w2Track = w2Goal + 1;

        switch (workNumber)
        {
            //counting up///////////////////////////////////////////////////////////////////////////////////
            case 0:
                Console.WriteLine("> count up to " + w1Goal + ":");
                //counting up
                do
                {
                    w1Track++;
                    w1UserString = Console.ReadLine();
                    intParse = int.TryParse(w1UserString, out w1UserInt);
                    if (!intParse)
                    {
                        Console.WriteLine("> that's not a number. enter a number:");

                    }
                    else if (w1UserInt != w1Track)
                    {
                        Console.WriteLine("> that's the wrong number.\n> tip : start with \"1\"");
                        w1Track = 0;
                    }
                } while (w1UserInt != w1Goal);
                Console.WriteLine("> press enter to exit");
                Console.ReadLine();
                break;
            //counting down///////////////////////////////////////////////////////////////////////////////////
            case 1:
                Console.WriteLine("> count down from " + w2Goal + ":");
                //counting down
                do
                {
                    w2Track--;
                    w2UserString = Console.ReadLine();
                    intParse = int.TryParse(w2UserString, out w2UserInt);
                    if (!intParse)
                    {
                        Console.WriteLine("> that's not a number. enter a number:");

                    }
                    else if (w2UserInt != w2Track)
                    {
                        Console.WriteLine("> that's the wrong number.\n> tip : start with " + w2Goal);
                        w2Track = w2Goal + 1;
                    }
                } while (w2UserInt != 1);
                Console.WriteLine("> press enter to exit");
                Console.ReadLine();
                break;
            //a///////////////////////////////////////////////////////////////////////////////////
            case 2:
                Console.WriteLine("]] work 3 [[");
                break;
            //a///////////////////////////////////////////////////////////////////////////////////
            case 3:
                Console.WriteLine("]] work 4 [[");
                break;
            //a///////////////////////////////////////////////////////////////////////////////////
            case 4:
                Console.WriteLine("]] work 5 [[");
                break;
        }






        time = "evening";
    } while (time == "work");

    //evening
    do
    {
        Console.WriteLine("evening stuff");
        time = "to die";
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
                Console.WriteLine("> terminating program...\n\ngoodbye, person.");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("> stop fooling around. (y/n). answer.");
                Console.WriteLine("> do you want to go on?");
                break;
        }
    } while (userInput != "y");

} while (alive);