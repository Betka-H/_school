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
Console.WriteLine("a = " + userNumber());
Console.Write("enter integer b: ");
Console.WriteLine("b = " + userNumber());
Console.Write("enter integer c: ");
Console.WriteLine("c = " + userNumber());