// kvadraticka rovnice
// ax^2 + bx + c = 0
// x1,2 = +-Vb^2-4ac / 2a
// uzivatel zada a, b, c
// pouzit funkci!
// na odmocninu V knihovna Math.Sqrt(69); MathF for floats
// poslat odkaz na github

int userNumber()
{
    int userNumber;
    bool inputParse;
    do
    {
        inputParse = Int32.TryParse(Console.ReadLine(), out userNumber);
        if (!inputParse)
        {
            Console.Write("thats not a number. please input a number: ");
        }
    } while (!inputParse);
    return userNumber;
}

Console.Write("enter integer a: ");
int a = userNumber();
Console.WriteLine("a = " + userNumber());
Console.Write("enter integer b: ");
int a = userNumber();

Console.WriteLine("b = " + userNumber());
Console.Write("enter integer c: ");
int a = userNumber();

Console.WriteLine("c = " + userNumber());
Console.Write("enter integer x: ");
int x = userNumber();
Console.WriteLine("x = " + userNumber());