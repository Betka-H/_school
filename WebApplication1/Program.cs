//dotnet run --project WebApplication1

Console.WriteLine("> enter pw:");



string pw = Console.ReadLine();



if (pw == "mypassword"){
    Console.WriteLine("> fine");
}
else{
    Console.WriteLine("> you suck\n> anyway");
}
Console.WriteLine("> what's your name?");
string uname = Console.ReadLine();
Console.WriteLine("> splendid, hi " + uname + "!\n> how old are you?");

