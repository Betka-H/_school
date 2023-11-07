//begin intro
Console.ForegroundColor = ConsoleColor.Gray;

Random rnd = new Random();



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

int loadMs = rnd.Next(100, 500);
Console.WriteLine("> got it. let's begin.\n\n> loading resources...\n> booting up...\n> done! 42 resources loaded. time taken: " + loadMs + "ms\n");



//end intro
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//begin day



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
        //4 - kostky??
        //5 -
        //random number for each work
        //workx - work index
        Console.WriteLine("> module \"work\" loaded\n> press enter to begin working phase");
        Console.ReadLine();
        //global variables
        bool intParse;
        int workNumber = rnd.Next(1, 1);//how many works to choose from

        int w12CountMin = 5;
        int w12CountMax = 32;
        int w12RndMsgChance = 52; // 0-64, the higher, the more messages
        //w1 variables
        int w1Goal, w1UserInt;
        string w1UserString;
        w1Goal = rnd.Next(w12CountMin, w12CountMax);
        int w1Track = 0;
        int w1Remaining;
        int w1MsgChance;
        //w2 variables
        int w2Goal, w2UserInt;
        string w2UserString;
        w2Goal = rnd.Next(w12CountMin, w12CountMax);
        int w2Track = w2Goal + 1;
        int w2Remaining;
        int w2MsgChance;

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
                        Console.WriteLine("> failed: that's not a number. enter a number:");

                    }
                    else if (w1UserInt != w1Track)
                    {
                        Console.WriteLine("> failed: that's the wrong number.\n> tip : start with \"1\"");
                        w1Track = 0;
                    }
                    w1Remaining = w1Goal - w1Track;
                    w1MsgChance = rnd.Next(64);
                    if (w1MsgChance > w12RndMsgChance && w1Track > 5 && w1Track != w1Goal)
                    {
                        Console.WriteLine("you're doing great! only " + w1Remaining + " more until " + w1Goal + "!");
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
                        Console.WriteLine("> failed: that's not a number. enter a number:");

                    }
                    else if (w2UserInt != w2Track)
                    {
                        Console.WriteLine("> failed: that's the wrong number.\n> tip : start with " + w2Goal);
                        w2Track = w2Goal + 1;
                    }
                    w2Remaining = w2Track - 1;
                    w2MsgChance = rnd.Next(64);
                    if (w2MsgChance > 52 && w2Track < w2Goal - 4 && w2Track != 1)
                    {
                        Console.WriteLine("you're doing great! only " + w2Remaining + " remaining until 0!");
                    }
                } while (w2UserInt != 1);
                Console.WriteLine("> press enter to exit");
                Console.ReadLine();
                break;
            //sort///////////////////////////////////////////////////////////////////////////////////
            //NOT DONE!!!
            case 2:
                Console.WriteLine("]] work 3 [[");

                {
                    int w3CatNumber = 5; //how many categories to draw from
                    string[] w3Categories = { "animal", "food", "drink", "plant", "country", "weather", "body part", "clothes", "color", "name", "game" };
                    string[] w3CategoriesChosen = { "", "", "", "", "" };
                    //all the items
                    {
                        string[] w3CAnimal = { "cat", "dog", "fish", "fox", "raccoon", "rat", "guinea pig", "bunny", "bear", "goose", "frog", "mole", "bee" };
                        string[] w3CFood = { "burger", "carrot", "cucumber", "bread", "rice", "potatoes", "sandwich", "yoghurt", "cheese", "apple", "pear", "grape", "eggplant", "egg" };
                        string[] w3CDrink = { "water", "orange juice", "apple juice", "vodka", "beer", "wine", "jagermilker", "grimace shake", "lean", "milk", "tea", "coffee" };
                        string[] w3CPlant = { "grass", "dandelion", "rose", "sunflower", "tree", "bush", "seaweed", "oxeye daisy", "peony", "forget me not", "lily", "orchid", "cactus", "bamboo", "sugar cane", "wheat", "allium", "cornflower", "tulip" };
                        string[] w3CCountry = { "america", "china", "great britain", "ukraine", "czech republic", "deutschland", "poland", "netherlands", "slovakia", "slovenia", "india", "taiwan", "korea" };
                        string[] w3CWeather = { "rain", "wind", "sun", "breeze", "heat", "cold", "freezing", "clouds" };
                        string[] w3CBodyPart = { "arm", "hand", "leg", "foot", "head", "neck", "ear", "nose", "eyes", "finger", "wrist" };
                        string[] w3CClothes = { "hat", "scarf", "gloves", "t-shirt", "shirt", "jacket", "blouse", "pants", "jeans", "shoes", "coat" };
                        string[] w3CColor = { "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "gray", "black", "white", "lime green", "cyan", "ultramarine", "magenta", "blurple" };
                        string[] w3CName = { "alexa", "alex", "steve", "karen", "joe", "john", "mary", "susie", "henry", "jack", "george", "elisabeth", "lucy", "emma", "catherine", "jane", "anna", "carl" };
                        string[] w3CGame = { "settlers of catan", "carcassonne", "karnoffel", "uno", "monopoly", "minecraft", "ori and the blind forest", "poker", "canasta", "domino", "magic the gathering", "inscryption", "five nights at freddys", "geometry dash", "hill climb racing" };
                    }

                    //sort stuff///////////////////////////////////////////////////////////////////////////////////
                    Console.WriteLine("> sort the words into their correct categories:");

                    for (int i = 1; i <= w3CatNumber; i++)
                    {
                        //choose a random category index and print it's name
                        int w3CategoryIndex = rnd.Next(10);
                        Console.WriteLine(i + ": " + w3Categories[w3CategoryIndex]);
                        //write the chosen category into the chosen categories array
                        int w3CategoriesChosenIndex = i - 1;
                        w3CategoriesChosen[w3CategoriesChosenIndex] = w3Categories[w3CategoryIndex];
                    }
                }

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