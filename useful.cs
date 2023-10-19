//TO RUN: > dotnet run --project [project name (WebApplication1)] < in the terminal
//ctrl+shit+p for cmd palete -> .NET -> new project -> core web api idk





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