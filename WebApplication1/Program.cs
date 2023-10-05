//dotnet run --project WebApplication1

Console.WriteLine("> hello, user. please state your name.");
string uname = Console.ReadLine().ToLower();
Console.WriteLine("> welcome, " + uname + "\non a scale of \"good\" to \"potatoes\", how are you doing today?");
string umood = Console.ReadLine().ToLower();
if (umood == "potatoes"){
    Console.WriteLine("> sorry to hear that");
}
else if (umood == "good"){
    Console.WriteLine("> good!");
}
else {
    Console.WriteLine("> okay...");
}


string yn;


do
        {
            Console.WriteLine("> ready to begin?\ny/n");
            yn = Console.ReadLine();

            if (yn == "n"){
                Console.WriteLine("> alright...");
            }

            if ( ( yn != "y" ) && ( yn != "n" )){
                Console.WriteLine("> invalid input!");
            }
            

        } while (yn != "y");

        Console.WriteLine("alright!");










