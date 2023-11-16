// TO RUN: > dotnet run --project [project name] < in the terminal
// ctrl+shit+p for cmd palete -> .NET -> new project -> core web api idk
// ctrl + c to cancel program in terminal
// right-click program folder -> open in external terminal for... external terminal

/* OLD
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
Console.WriteLine("> splendid, hi " + uname + "!\n> how old are you?");





// login
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
    Console.WriteLine("> login successful!");





// x in Ax+B=0
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
//probably dont need this??
*/

// useful
Console.WriteLine(DateTime.Now); // time
Console.ForegroundColor = ConsoleColor.Gray; // color
Console.Title = "the what now"; // external terminal (ET) window title
Console.WindowHeight = 42;
Console.WindowWidth = 64;

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
