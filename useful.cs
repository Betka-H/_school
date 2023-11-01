// TO RUN: > dotnet run --project [project name (WebApplication1)] < in the terminal
// ctrl+shit+p for cmd palete -> .NET -> new project -> core web api idk
// ctrl + c to cancel program in terminal





Console.Write("h"); //dont end with a new line
Console.WriteLine("elo worl"); //end with a new line

int num1 = 2; //integers
int num2 = 5;
double des = 2.14; //decimal
string name = "sbgjasgdsgg"; //string
bool yes = true; //boolean


Console.WriteLine("hello there, " + name); // "append" a string to wl (writeline) text

int add = num1 + num2;

Console.WriteLine(add);

double dbl = des + num1;
int dblint = (int)dbl; //convert double to int

Console.WriteLine(dblint); //prints it ig

if (yes)
{
    Console.WriteLine("bool yes is true");
}

if (!yes)
{
    Console.WriteLine("bool yes is false");
}


bool compb = num1 == 7; //compares x to 7 and outputs the bool
Console.WriteLine(compb);



//string shenanigans

Console.WriteLine(">>> tell me the name of god you fungal piece fo shit");
string askm = Console.ReadLine().ToLower(); //converts string to lower

// vvv use "==", not "="!
if (askm == "you cannot kill me in a way that matters")
{
    Console.WriteLine(">>> decay exists as an extant form of life");
}
else
{
    Console.WriteLine(">>> wrong answer bozo");
}

//
//
//OLD
//
//



//number shenanigans

Console.WriteLine("zadej cislo");
string uin = Console.ReadLine();
int uinreal;
bool uinsucess = int.TryParse(uin, out uinreal);

if (uinsucess == true)
{
    Console.WriteLine("suces");
}
else
{
    Console.WriteLine("not a number");
}



//yn shenanigans

Console.WriteLine("> hello, user. please state your name.");
string uname = Console.ReadLine().ToLower();
Console.WriteLine("> welcome, " + uname + "\non a scale of \"good\" to \"potatoes\", how are you doing today?");
string umood = Console.ReadLine().ToLower();
if (umood == "potatoes")
{
    Console.WriteLine("> sorry to hear that");
}
else if (umood == "good")
{
    Console.WriteLine("> good!");
}
else
{
    Console.WriteLine("> okay...");
}


string yn;


do
{
    Console.WriteLine("> ready to begin?\ny/n");
    yn = Console.ReadLine();

    if (yn == "n")
    {
        Console.WriteLine("> alright...");
    }

    if ((yn != "y") && (yn != "n"))
    {
        Console.WriteLine("> invalid input!");
    }


} while (yn != "y");

Console.WriteLine("alright!");



//pw/age shenanigans

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
Console.WriteLine("> splendid, hi " + uname + "!\n> how old are you?");




string uinputage = Console.ReadLine();
int uage = 0;
bool agevalid = int.TryParse(uinputage, out uage);

for (int lowage = 18; uage > lowage; lowage = lowage + 1)
{
    Console.WriteLine(lowage);
}

//the holy grail vvvvv

bool parse;
do
{
    Console.WriteLine("> give me a number");
    string unumber = Console.ReadLine();
    int parsednumber = 0;
    parse = int.TryParse(unumber, out parsednumber);
}
while (!parse);

bool isseven = x == 7; //is true depending on whether x == 7 or not


switch (foo)
{
    case "value1":
        Console.WriteLine("bjdkashfjlaksfhalksjhf");
        break;
    case "value2":
        Console.WriteLine("habdkajsbhasbgbdshdbgs");
        break;
}

//yn module
do
{
    userInput = Console.ReadLine().ToLower();
    switch (userInput)
    {
        case "y":
            break;
        case "n":
            Console.WriteLine("answered no");
            //Environment.Exit(0);
            break;
        default:
            Console.WriteLine("> invalid input : (y/n) expected.");
            Console.WriteLine("question repeat");
            break;
    }
} while (userInput != "y");

Console.WriteLine(DateTime.Now);

Console.ForegroundColor = ConsoleColor.Gray;









for (int i = 1; i <= w3CategoryAmount; i++)
{
    w3CatRandom = rnd.Next(w3Categories.Count()); // generates a random number
    if (!w3CategoriesChosenIndex.Contains(w3CatRandom)) // // only run if the random number isnt already in the array
    {
        // number part
        Array.Resize(ref w3CategoriesChosenIndex, i); // resizes repeat check array +1
        w3CategoriesChosenIndex[i - 1] = w3CatRandom; // writes the random number into the freed up space
        Console.Write(">>>>> category " + i + ": "); // prints category number
        // category part
        Array.Resize(ref w3CategoriesChosen, i); // resizes chosen category list array +1
        w3CategoriesChosen[i - 1] = w3Categories[w3CatRandom]; // writes the randomly chosen category into the freed up space
        Console.WriteLine(w3Categories[w3CatRandom] + " (" + w3CatRandom + ")"); // prints category name
        // item part
        for (int j = 1; j <= w3ItemAmount; j++)
        {
            w3ItemRandom = rnd.Next(w3AllItems[w3CatRandom].Count()); // generates random item number
            Array.Resize(ref w3ItemsChosenIndex, j); // resizes repeat check array +1
            w3ItemsChosenIndex[j - 1] = w3ItemRandom; // writes the random number into the freed up space
            Console.WriteLine(">> item index: " + w3ItemRandom); // prints item index
            //Console.WriteLine(w3AllItems[2][4]);
            if (!w3CategoriesChosenIndex.Contains(w3ItemRandom))
            {
                Array.Resize(ref w3ItemsChosenIndex, j); // resizes repeat check array +1
                w3ItemsChosenIndex[j - 1] = w3ItemRandom; // writes the random number into the freed up space
                Console.WriteLine("> item: " + w3AllItems[w3CatRandom][w3ItemRandom]); // prints item number
                Array.Resize(ref w3ItemsChosen, i); // resizes chosen item list array +1
                w3ItemsChosen[j - 1] = w3AllItems[w3CatRandom][w3ItemRandom]; // writes the randomly chosen item into the freed up space
            }
            else
            {
                Console.WriteLine("debug>> item number " + "(" + w3ItemRandom + ")" + " already in list. skipping."); // debug
                j--; // so that the loop can run again correctly
            }
        }
    }
    else // if the random number already is in the array
    {
        Console.WriteLine("debug>> category number " + "(" + w3CatRandom + ")" + " already in list. skipping."); // debug
        i--; // so that the loop can run again correctly
    }
}