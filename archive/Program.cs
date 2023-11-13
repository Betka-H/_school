// TO RUN: > dotnet run --project [project name (WebApplication1)] < in the terminal
// ctrl+shit+p for cmd palete -> .NET -> new project -> core web api idk
// ctrl + c to cancel program in terminal



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
*/

// useful
Console.WriteLine(DateTime.Now); // time
Console.ForegroundColor = ConsoleColor.Gray; // color

// class 1
/*
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
*/
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