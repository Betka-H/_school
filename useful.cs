//TO RUN: > dotnet run --project WebApplication1 < in the terminal




Console.Write("h"); //dont write a new line
Console.WriteLine("elo worl"); //write on a new line

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
string askm = Console.ReadLine().ToLower();

// vvv use ==, not =!
if (askm == "you cannot kill me in a way that matters")
{
    Console.WriteLine(">>> decay exists as an extant form of life");
}
else
{
    Console.WriteLine(">>> wrong answer bozo");
}



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