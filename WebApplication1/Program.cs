//dotnet run --project WebApplication1

string[] users = {"joe","john","stacy","karen"};
string usercurrent;

Console.WriteLine("> hello! enter your username:");
usercurrent = Console.ReadLine();
do{
    Console.WriteLine("> that username is not in the database. please try again.");
    usercurrent = Console.ReadLine();
}
while (!users.Contains(usercurrent));
Console.WriteLine("> hello, " + usercurrent + "!\n> please enter your password:");
string userpw = Console.ReadLine();


/*

ask for username
if the username is on the users list (static),
ask the password


*/


/* 
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




string uinputage = Console.ReadLine();
int uage = 0;
bool agevalid = int.TryParse(uinputage, out uage);

for (int lowage = 18; uage > lowage; lowage = lowage+1){
    Console.WriteLine(lowage);
}

//the holy grail vvvvv

bool parse;
do{
    Console.WriteLine("> give me a number");
    string unumber = Console.ReadLine();
    int parsednumber = 0;
    parse = int.TryParse(unumber, out parsednumber);
}
while (!parse); */