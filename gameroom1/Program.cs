using System.ComponentModel;
using Microsoft.Extensions.Logging.Console;
//dec
bool alive = true;
string yn;

//intro
Console.WriteLine("> welcome! are you a person?\n>> (y/n)");
do
{
    yn = Console.ReadLine();
    if (yn == "y")
    {
        Console.WriteLine("> great!");
    }
    else if (yn == "n")
    {
        Console.WriteLine("> err 503: user not a person...\n> terminating program...");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("> invalid input :(\n> are you a person?\n>> (y/n)");
    }
}
while (yn != "y");

Console.WriteLine("> hello person! ready to enter the game?\n>> (y/n)");
do
{
    yn = Console.ReadLine();
    if (yn == "n")
    {
        Console.WriteLine("> alright\n> ...\n> ...\n> ...\n> ready now?\n>> (y/n)");
    }
    else if (yn != "y" && yn != "n")
    {
        Console.WriteLine("> invalid input :(\n> start the game?\n>> (y/n)");
    }
}
while (yn != "y");
Console.WriteLine("> got it.\n> let's begin.");





//day
do
{
    string time = "morn";

    do
    {
        //morning stuff///////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("morning stuff\n> press enter to continue:");
        Console.ReadLine();
        time = "work";

    } while (time == "morn");

    do
    {
        //work stuff///////////////////////////////////////////////////////////////////////////////////////
        //several types of work
        //1 - count up/down to 8-32 numbers
        //2 - sort stuff from categories - animals, clothes, seasons, sports, foods...
        //3 - write a letter - same mechanics as numbers ig??
        //4 - 
        //5 -
        //random number for each work
        //workx - work index
        Random rnd = new Random();
        int workx  = rnd.Next(4);
        if (workx==0)
        {
            Console.WriteLine("work 0");
        }
        else if (workx==1)
        {
            Console.WriteLine("work 1");
        }
        else if (workx==2)
        {
            Console.WriteLine("work 2");
        }
        else if (workx==3)
        {
            Console.WriteLine("work 3");
        }
        else if (workx==4)
        {
            Console.WriteLine("work 4");
        }
        



        Console.WriteLine("work stuff\n> press enter to continue:");
        Console.ReadLine();

        //end of work stuff///////////////////////////////////////////////////////////////////////////////////////
        time = "eve";
    } while (time == "work");

    do
    {
        //evening stuff///////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("evening stuff\n> press enter to continue:");
        Console.ReadLine();
        time = "morning";

    } while (time == "eve");

    //exit confirmation///////////////////////////////////////////////////////////////////////////////////////    
    Console.WriteLine("> do you want to go on? \n>> (y/n)");
    do
    {
        yn = Console.ReadLine();
        if (yn == "n")
        {
            Console.WriteLine("> terminating program...\n> goodbye, person.");
            Environment.Exit(0);
        }
        else if (yn != "y" && yn != "n")
        {
            Console.WriteLine("> stop fooling around.");
        }
    }
    while (yn != "y");

} while (alive);