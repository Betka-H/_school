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