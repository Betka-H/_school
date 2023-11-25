// TO RUN: > dotnet run --project [project name] < in the terminal
// ctrl+shit+p for cmd palete -> .NET -> new project -> core web api idk
// ctrl + c to cancel program in terminal
// right-click program folder -> open in external terminal for... external terminal
// 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 idgaf

// OLD
/* mushrooms
Console.WriteLine(">>> tell me the name of god you fungal piece fo shit");
string askm = Console.ReadLine().ToLower();
if (askm == "you cannot kill me in a way that matters")
{
    Console.WriteLine(">>> decay exists as an extant form of life");
}
else
{
    Console.WriteLine(">>> wrong answer bozo");
}

Console.WriteLine("> enter pw:");
string pw = Console.ReadLine();
if (pw == "mypassword")
{
    Console.WriteLine("> fine");
}
else
{
    Console.WriteLine("> you suck\n> anyway");
}
Console.WriteLine("> what's your name?");
string uname = Console.ReadLine();
Console.WriteLine("> splendid, hi " + uname + "!\n> how old are you?"); */
/* login
//declarations
string[] users = { "joe", "john", "stacy", "karen", "may" };
string[] pws = { "joesawesomepassword", "imjohn42", "3141592653", "password123", "junejuly" };
string usercurrent;
string userpw;
int pwatt = 3;

//asks for username
Console.WriteLine("> hello! enter your username:");

//asks for username again until it is found in the database
do
{
    usercurrent = Console.ReadLine();
    if (!users.Contains(usercurrent))
    {
        Console.WriteLine("> that username is not in the database. please try again.");
    }
}
while (!users.Contains(usercurrent));

int userindex = Array.IndexOf(users, usercurrent);
string correctpw = pws[userindex];
Console.WriteLine("[debug] " + correctpw);
//asks for pw until ???
Console.WriteLine("> hello, " + usercurrent + "!\n> please enter your password:");

do
{
    userpw = Console.ReadLine();
    if (!string.IsNullOrEmpty(userpw))
    {
        pwatt -= 1;
    }
    if (userpw != correctpw && pwatt > 0)
    {
        if (pwatt == 1)
        {
            Console.WriteLine("> incorrect password. please try again. you have " + pwatt + " try left.");
        }
        else
        {
            Console.WriteLine("> incorrect password. please try again. you have " + pwatt + " tries left.");
        }
    }
}
while (userpw != correctpw && pwatt > 0);
if (pwatt == 0 && userpw != correctpw)
{
    Console.WriteLine("> too many wrong passwords. please try again later.");
    Environment.Exit(0);
}
else
    Console.WriteLine("> login successful!"); */
/* x in Ax+B=0
// declarations
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
//probably dont need this?? */
/* work game
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

                int w3CatAmount = 3; // how many categories to use
                int w3ItemAmount = 5; // how many items to use from each category
                string[] w3AllCategories = { "animals", "foods", "drinks", "plants", "countries", "weather", "body parts", "clothes", "colors", "names", "games" };
                int w3CatRandom; // random number that gets generated repeatedly to determine which categories to sort into
                int w3ItemRandom; // random number that gets generated repeatedly to determine which items to sort
                string[] w3CategoriesChosen = { }; // array of randomly generated categories
                string[] w3ItemsChosen = { }; // array of randomly generated items from these categories

                int w3RandomCatLoopCheck = 1; // purely for debug



                string[][] w3AllItems = new string[][]
                {
    new string[]{ // 0 animals
        "cat", "dog", "fish", "fox", "raccoon", "rat", "guinea pig", "bunny", "bear", "goose", "frog", "mole", "bee", "chicken"
        },
    new string[]{ // 1 foods
        "burger", "carrot", "cucumber", "bread", "rice", "potatoes", "sandwich", "yoghurt", "cheese", "apple", "pear", "grape", "eggplant", "egg"
        },
    new string[]{ // 2 drinks
        "water", "orange juice", "apple juice", "vodka", "beer", "wine", "jagermilker", "grimace shake", "lean", "milk", "tea", "coffee"
        },
    new string[]{ // 3 plants
        "grass", "dandelion", "rose", "sunflower", "tree", "bush", "seaweed", "oxeye daisy", "peony", "forget me not", "lily", "orchid", "cactus", "bamboo", "sugar cane", "wheat", "allium", "cornflower", "tulip"
        },
    new string[]{ // 4 countries
        "america", "china", "great britain", "ukraine", "czech republic", "deutschland", "poland", "netherlands", "slovakia", "slovenia", "india", "taiwan", "korea", "greece"
        },
    new string[]{ // 5 weather
        "rain", "wind", "sun", "breeze", "heat", "cold", "freezing", "clouds"
        },
    new string[]{ // 6 body parts
        "arm", "hand", "leg", "foot", "head", "neck", "ear", "nose", "eyes", "finger", "wrist"
        },
    new string[]{ // 7 clothes
        "hat", "scarf", "gloves", "t-shirt", "shirt", "jacket", "blouse", "pants", "jeans", "shoes", "coat"
        },
    new string[]{ // 8 colors
        "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "gray", "black", "white", "lime green", "cyan", "ultramarine", "magenta", "blurple"
        },
    new string[]{ // 9 names
        "alexa", "alex", "steve", "karen", "joe", "john", "mary", "susie", "henry", "jack", "george", "elisabeth", "lucy", "emma", "catherine", "jane", "anna", "carl"
        },
    new string[]{ // 10 games
        "settlers of catan", "carcassonne", "karnoffel", "uno", "monopoly", "minecraft", "ori and the blind forest", "poker", "canasta", "domino", "magic the gathering", "inscryption", "five nights at freddys", "geometry dash", "hill climb racing"
        }
                };





                //// terminate the program...
                // if the requested category amount exceeds the existing amount
                if (w3CatAmount > w3AllCategories.Count())
                {
                    Console.WriteLine("> error: w3CatAmount exceeds the amount of elements in w3AllCategories\n> terminating program...");
                    Environment.Exit(0);
                }
                // if the requested amount of categories is 1 or less
                if (w3CatAmount <= 1)
                {
                    Console.WriteLine("> error: requested category draw amount is less than 2\n> terminating program...");
                    Environment.Exit(0);
                }
                // if the requested amount of items is 0 or less
                if (w3ItemAmount <= 0)
                {
                    Console.WriteLine("> error: requested item draw amount is less than 0\n> terminating program...");
                    Environment.Exit(0);
                }

                Console.WriteLine("> sort the words into their correct categories:");

                ///////////xxxxxxxxxxxxxxxxxxxxxxxxx
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(">>>>> | start | <<<<<");
                Console.WriteLine(DateTime.Now);
                Console.ForegroundColor = ConsoleColor.Gray;
                // for the requested amount of categories
                for (int i = 1; i <= w3CatAmount; i++)
                {
                    Console.WriteLine("loop " + w3RandomCatLoopCheck + " (category " + i + "/" + w3CatAmount + ")");
                    w3CatRandom = rnd.Next(w3AllCategories.Count()); // chooses a random index from all the existing categories

                    Console.WriteLine("the category name is: " + w3AllCategories[w3CatRandom]);

                    if (!w3CategoriesChosen.Contains(w3AllCategories[w3CatRandom])) // only runs if the category isnt already in the list
                    {
                        Array.Resize(ref w3CategoriesChosen, i); // resizes chosen category array  to i
                        w3CategoriesChosen[i - 1] = w3AllCategories[w3CatRandom]; // writes the category name into the chosen categories array
                    }
                    else // skip
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("the category is in the array already. skipping");  // debug
                        Console.ForegroundColor = ConsoleColor.Gray;
                        i--;
                    }


                    w3RandomCatLoopCheck++;
                    Console.WriteLine();
                }


                for (int i = 1; i <= w3ItemAmount; i++)
                {

                    w3ItemRandom = rnd.Next(w3AllItems[Array.IndexOf(w3AllCategories, w3CategoriesChosen[69])].Count()); // chooses a random index from all the existing items in the category
                    Console.Write(w3ItemRandom);
                    Console.Write(": ");
                    Console.Write(w3AllItems[i - 1][w3ItemRandom]);

                    if (!w3ItemsChosen.Contains(w3AllItems[i - 1][w3ItemRandom])) // only runs if the category isnt already in the list
                    {
                        Console.WriteLine();
                        Array.Resize(ref w3ItemsChosen, i);
                        w3ItemsChosen[i - 1] = w3AllItems[i - 1][w3ItemRandom];
                    }
                    else // skip
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" > the item is in the array already. skipping");  // debug
                        Console.ForegroundColor = ConsoleColor.Gray;
                        i--;
                    }



                }


                ///////////xxxxxxxxxxxxxxxxxxxxxxxxx
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("the selected categories are: "); // list categories
                for (int i = 1; i <= w3CatAmount; i++)
                {
                    Console.Write(w3CategoriesChosen[i - 1] + " " + (i - 1));
                    if (i < w3CatAmount)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();

                Console.Write("the selected items are: "); // list items
                for (int i = 1; i <= w3ItemAmount; i++)
                {
                    Console.Write(w3ItemsChosen[i - 1] + " " + (i - 1));
                    if (i < w3ItemAmount)
                    {
                        Console.Write(", ");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine();

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

} while (alive); */
/* blackjack 1 ((overly complicated xdd))
"jdu hrat jackblack" - 23/11/7

ACEs are worth 1 or 11 (player's choice), FACEs 10 and other CARDs normal

1-6 players
1-8 standard DECKs shuffled

all PLAYERs TAKE a CARD FACE-UP
DEALER TAKES a CARD FACE-UP
all PLAYERs TAKE a CARD FACE-UP
DEALER TAKES a CARD FACE-DOWN

if the DEALER's FACE-UP CARD is an ACE or a TEN-CARD, they CHECK their FACE-DOWN CARD if they have a BLACKJACK -> all PLAYERs LOSE, otherwise continues as normal

if the PLAYER's CARD is an ACE and a TEN-CARD, its a BLACKJACK
if any PLAYER has a BLACKJACK and the DEALER does not -> PLAYER WINs
if the DEALER has a BLACKJACK -> all PLAYERs LOSE, except for those who also had a BLACKJACK
if both the DEALER and a PLAYER have BLACKJACKs -> its a DRAW for the PLAYER

on their TURN, a PLAYER can
STAND (do not TAKE)
HIT (TAKE) >> go BUST (have over 21 POINTS) -> PLAYER LOSEs

cards (per deck): 1x4, 2x4, 3x4, 4x4, 5x4, 6x4, 7x4, 8x4, 9x4, face 10x5, ace 1 or 11x4
actors: player, dealer
actions: take, stand, hit, bust, check (only for dealer)
states: lose, win, ultrawin (with blackjack), faceup, facedown
other: points, blackjack


//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv

Random rnd = new Random();
int deckAmount = 1, playerAmount = 3; // default: 1/1. min/max decks 1/8, min/max players 1/6
string userString;
string[] player = { "player 1", "player 2", "player 3" };

void colorDefault()
{
    Console.ForegroundColor = ConsoleColor.Gray;
}
void colorWrong()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void colorTitle()
{
    Console.ForegroundColor = ConsoleColor.Green;
}
void inputInvalid()
{
    colorWrong();
    Console.WriteLine("> invalid input!");
    colorDefault();
}

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

colorTitle();
Console.WriteLine("-----=====-----=====-----\n- welcome to blackjack -\n-----=====-----=====-----");
colorDefault();

start:
Console.WriteLine($"> the current game settings are: {deckAmount} deck/s, {playerAmount} player/s.\n> if you wish to change these settings for this round, type \"change\". otherwise, type \"done\".");
switch (userString = Console.ReadLine().ToLower())
{
    case "change":
    settings:
        Console.WriteLine("> please select which parameter you want to change; type \"deck\" or \"player\". if you no longer wish to edit these values, type \"done\".");
        switch (userString = Console.ReadLine().ToLower())
        {
            case "deck":
                Console.WriteLine("> please enter the new value for the amount of decks used in the game (min 1, max 8):");
            getDeckAmount:
                if (!int.TryParse(Console.ReadLine().ToLower(), out deckAmount)) // if user entered nonsense
                {
                    inputInvalid();
                    Console.WriteLine("please input a whole number between 1 and 8:");
                    goto getDeckAmount;
                }
                if (deckAmount < 1 || deckAmount > 8) // if the requested value is out of legal bounds
                {
                    colorWrong();
                    Console.Write("> that number is too ");
                    switch (deckAmount)
                    {
                        case < 1:
                            Console.Write("small");
                            break;
                        case > 8:
                            Console.Write("large");
                            break;
                    }
                    Console.Write(". ");
                    colorDefault();
                    Console.WriteLine("please enter a whole value between 1 and 8:");
                    goto getDeckAmount;
                }
                Console.WriteLine($"> there will now be {deckAmount} deck/s and {playerAmount} player/s in the game");
                break;
            case "player":
                Console.WriteLine("> please enter the new value for the amount of players who will be playing the game (min 1, max 6) (excluding the dealer):");
            getPlayerAmount:
                if (!int.TryParse(Console.ReadLine().ToLower(), out playerAmount)) // if user entered nonsense
                {
                    inputInvalid();
                    Console.WriteLine("please input a whole number between 1 and 6:");
                    goto getPlayerAmount;
                }
                if (playerAmount < 1 || playerAmount > 6) // if the requested value is out of legal bounds
                {
                    colorWrong();
                    Console.Write("> that number is too ");
                    switch (playerAmount)
                    {
                        case < 1:
                            Console.Write("small");
                            break;
                        case > 6:
                            Console.Write("large");
                            break;
                    }
                    colorDefault();
                    Console.WriteLine(". please enter a whole value between 1 and 6:");
                    goto getPlayerAmount;
                }
                Console.WriteLine($"> there will now be {playerAmount} player/s and {deckAmount} deck/s in the game");
                break;
            case "done":
                goto namePlayers;
            default:
                inputInvalid();
                goto settings;
        }
        goto settings;
    case "done":
        break;
    default:
        inputInvalid();
        goto start;
}

namePlayers:
colorTitle();
Console.WriteLine("name the players");
colorDefault();
// get all player names
for (int i = 1; i <= playerAmount; i++)
{
namePlayer:
    Console.WriteLine($"please enter the name for player {i}/{playerAmount}:");
    Array.Resize(ref player, i);
    userString = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userString)) // name cannot be empty
    {
        inputInvalid();
        Console.WriteLine("player name cannot be empty!");
        goto namePlayer;
    }
    else if (player.Contains(userString)) // duplicate name
    {
        inputInvalid();
        Console.WriteLine($"another player is already named \"{userString}\"!");
        goto namePlayer;
    }
    player[i - 1] = userString;
}

//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv

void randomDelayMedium()
{
    Thread.Sleep(rnd.Next(0, 0));//5,250
}
void randomDelayLong()
{
    Thread.Sleep(rnd.Next(0, 0));//100,500
}
string[] randomVerbs = { "meeting", "being interested in", "sneezing at", "marrying", "debugging", "laughing at", "painting", "fighting", "kissing", "shouting at" };
string[] randomNouns = { "squirerls", "women", "men", "demons", "moles", "slugs", "shoes", "humans", "water bottles", "cheeseburgers" };

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

randomDelayMedium();
Console.WriteLine("counting players...");
randomDelayMedium();
Console.WriteLine("counting decks...");
randomDelayMedium();
Console.WriteLine("shuffling cards...");
randomDelayMedium();
Console.WriteLine($"{randomVerbs[rnd.Next(randomVerbs.Count())]} {randomNouns[rnd.Next(randomNouns.Count())]}...");
randomDelayMedium();
Console.WriteLine("calculating values...");
randomDelayLong();
colorTitle();
Console.WriteLine("done. let's begin!");
colorDefault();

//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv

// clubs, diamonds, hearts, spades
// 1,2,3,4,5,6,7,8,9,10,jack,queen,king,ace
string[] cards = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack (value 10)", "queen (value 10)", "king (value 10)", "ace (value 1 or 11)" },
drawn = { };
int drawNr = 0;
int[] cardValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 0 };

void draw()
{
    Array.Resize(ref drawn, drawNr + 1); // resize drawn cards array
    drawn[drawNr] = cards[rnd.Next(cards.Length)]; // draw a random card
    Console.WriteLine($"{player[drawNr % playerAmount]} draws a card: {drawn[drawNr]}");
    drawNr++;
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

// SP TEST

string[] cards = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack (value 10)", "queen (value 10)", "king (value 10)", "ace (value 1 or 10)" },
drawnP = { },
drawnD = { };
int drawNr = 0;
int[] cardValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 0 };
Random rnd = new Random();

void drawP()
{
    Array.Resize(ref drawnP, drawNr + 1); // resize drawn cards array
    drawnP[drawNr] = cards[rnd.Next(cards.Length)]; // draw a random card
    Console.WriteLine($"you draw a card: {drawnP[drawNr]}");
    drawNr++;
}
void drawD()
{
    Array.Resize(ref drawnD, drawNr + 1); // resize drawn cards array
    drawnP[drawNr] = cards[rnd.Next(cards.Length)]; // draw a random card
    Console.WriteLine($"you draw a card: {drawnD[drawNr]}");
    drawNr++;
}

Console.WriteLine("you will now draw 2 cards");
drawP();
drawP();

// all PLAYERs TAKE a CARD FACE-UP
// DEALER TAKES a CARD FACE-UP
// all PLAYERs TAKE a CARD FACE-UP
// DEALER TAKES a CARD FACE-DOWN
Console.WriteLine("all players will now be dealt a card face-up: it will be shown to all other players.");


draw();
draw();
draw();
draw();
draw(); */

// useful
// static function does not acess any outisde variable. global x local. static is recommended
Console.WriteLine(DateTime.Now); // time
Console.ForegroundColor = ConsoleColor.Gray; // color
Console.Title = "the what now"; // external terminal (ET) window title
Console.WindowHeight = 42; Console.WindowWidth = 64;
int getInt()
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            return x;
        }
        Console.Write("not a number! please enter a number: ");
    }
}

// real shit
/* print array elements in order
int[] numberArray2 = { };

void printArray(int[] y)
{
    for (int i = 0; i < y.Length; i++)
    {
        Console.Write(y[i]);
        if (i != y.Length - 1)
        {
            Console.Write(", ");
        }
        // y[i] = 42;
    }
    Console.WriteLine();
} 
Console.WriteLine("array 1:");
printArray(numberArray);
Console.WriteLine("array 2:");
printArray(numberArray2);

// real thing
int[] coeficients = { 6, 4, 48, -4, 4, -1, 9, -21 };
void printPoly(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}x^{a.Length - (i + 1)} ");
        if (i != a.Length - 1)
        {
            Console.Write("+ ");
        }
    }
}
printPoly(coeficients);
*/
/* starry night
int rows, columns;

int getPosInt()
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            if (x > 0)
            {
                return x;
            }
        }
        Console.Write("please input a whole positive number: ");
    }
}
System.ConsoleColor col1()
{
    return ConsoleColor.DarkYellow;
}
System.ConsoleColor col2()
{
    return ConsoleColor.Blue;
}

Console.Title = "starry night";
for (; ; )
{
    Console.WriteLine(DateTime.Now);
    Console.Write("input the amount of rows (height): ");
    rows = getPosInt();
    Console.Write("input the amount of columns (width): ");
    columns = getPosInt();
    Console.WriteLine($"{rows} rows, {columns} columns");

    for (int i = 1; i <= rows; i++)
    {
        Console.ForegroundColor = col1();
        if (i % 2 == 0)
        {
            Console.ForegroundColor = col2();
        }
        for (int y = 1; y <= columns; y++)
        {
            Console.Write("* ");
            if (Console.ForegroundColor == col2())
            {
                Console.ForegroundColor = col1();
            }
            else
            {
                Console.ForegroundColor = col2(); ;
            }
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Gray;
} */
/* calculate basic shape outline lengths and areas
Console.Title = "pocita tvary :))";

float a, b, c, r, pi = 22 / 7;
string unit = "cm";

void colWrong() // wrong color
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void colNormal() // normal color
{
    Console.ForegroundColor = ConsoleColor.Gray;
}

float getPosFloat() // outputs a positive float, from user
{
    for (; ; )
    {
        if (float.TryParse(Console.ReadLine(), out float x))
        {
            if (x > 0)
            {
                return x;
            }
        }
        colWrong();
        Console.Write("prosim zadej cislo vetsi nez 0: ");
        colNormal();
    }
}

void writeGet(string s) // prosim zadej delku {s} (v {unit}):
{
    Console.Write($"prosim zadej delku {s} (v {unit}): ");
}

void kruh()
{
    writeGet("polomeru r");
    r = getPosFloat();
    Console.WriteLine($"obvod kruhu je: {MathF.Round(2 * pi * r, 2)}{unit}\nobsah kruhu je: {MathF.Round(pi * MathF.Pow(r, 2), 2)}{unit}");
}
void trojuhelnik()
{
    writeGet("strany a");
    a = getPosFloat();
    writeGet("strany b");
    b = getPosFloat();
    writeGet("strany c");
    c = getPosFloat();
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        float s = (a + b + c) / 2;
        Console.WriteLine($"obvod trojuhelniku je: {MathF.Round(a + b + c, 2)}{unit}\nobsah trojuhelniku je: {MathF.Round(MathF.Sqrt(s * (s - a) * (s - b) * (s - c)), 2)}{unit}");
    }
    else
    {
        colWrong();
        Console.WriteLine("neplati trojuhelnikova nerovnost (soucet delek kazdych dvou stran ma byt vetsi nez delka strany treti)!");
        colNormal();
    }
}
void ctverec()
{
    writeGet("strany a");
    a = getPosFloat();
    Console.WriteLine($"obvod ctverce je: {MathF.Round(4 * a, 2)}{unit}\nobsah ctverce je: {MathF.Round(a * a, 2)}{unit}");
}
void obdelnik()
{
    writeGet("strany a");
    a = getPosFloat();
    writeGet("strany b");
    b = getPosFloat();
    Console.WriteLine($"obvod obdelniku je: {MathF.Round(2 * a + 2 * b, 2)}{unit}\nobsah obdelniku je: {MathF.Round(a * b, 2)}{unit}");
}

for (; ; )
{
    Console.Write("vyber utvar, ktery chces vypocitat: [k]ruh, [t]rojuhelnik, [c]tverec, [o]bdelnik nebo [s]top k ukonceni programu: ");
    switch (Console.ReadLine().ToLower())
    {
        case "k":
            kruh();
            break;
        case "t":
            trojuhelnik();
            break;
        case "c":
            ctverec();
            break;
        case "o":
            obdelnik();
            break;
        case "s":
            Environment.Exit(0);
            break;
        default:
            colWrong();
            Console.WriteLine("neplatny vyber!");
            colNormal();
            break;
    }
} */
/* find max (brocken :(( )
int[] array1 = { 432, 5, 3, 46, 43, 6, 4474, 743, 5322, 34, 5322, 4325, 532, 3, 2, 2, 5322 };

int findMax(int[] ar)
{
    int max = 0;
    if (ar.Length == 0)
    {
        Console.WriteLine("array has 0 elements");
        return 0;
    }
    else
    {
        foreach (int x in array1)
        {
            if (x > max)
            {
                max = x;
            }
        }
    }
    return max;
}

void findMaxIndex(int[] ar)
{
    if (ar.Length == 0)
    {
        Console.WriteLine("array has 0 elements");
    }
    else
    {
        Console.Write("the highest number index/es in the array is/are: ");
        for (int i = 0; i > ar.Length; i++)
        {
            if (ar[i] == findMax(ar))
            {
                Console.Write($"{i},");
            }
        }
    }
}

void col1()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
}
void col2()
{
    Console.ForegroundColor = ConsoleColor.Gray;
}


col1();
Console.WriteLine($"the highest number in the array is: {findMax(array1)}");
col2();

col1();
findMaxIndex(array1);
col2(); */
