// TO RUN: > dotnet run --project [project name (WebApplication1)] < in the terminal
// ctrl+shit+p for cmd palete -> .NET -> new project -> core web api idk
// ctrl + c to cancel program in terminal



// OLD
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
// OLD



switch (foo) // switch
{
    case x:
        // output 1
        break;
    case y:
        // output 2
        break;
    case default:
        // output when every other check fails
        break;
}

Console.WriteLine(DateTime.Now); // time

Console.ForegroundColor = ConsoleColor.Gray; // color



// functions
Console.WriteLine(maximum(16, 42));
float maximum(float x, float y) // needs at least 1 return value
{
    if (x > y)
    {
        return x;
    }
    else if (x < y)
    {
        return y;
    }
    else
    {
        Console.WriteLine("the values are equal");
        return 0;
    }
}



void userNumber() // void needs no return value
{
    int userNumber;
    bool inputParse;
    {
        Console.Write("please input your number: ");
        inputParse = Int32.TryParse(Console.ReadLine(), out userNumber);
    } while (!inputParse) ;
    Console.WriteLine("your number is: " + userNumber);
}

Console.WriteLine($"text, but with {variables}! how {cool} is that??");//interpolated or whatnot