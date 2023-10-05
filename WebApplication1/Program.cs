//dotnet run --project WebApplication1

//declarations
string[] users = { "joe", "john", "stacy", "karen" };
string[] pws = { "joesawesomepassword", "imjohn42", "3141592653", "password123" };
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
Console.WriteLine(">>> debug pass is: " + correctpw);
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