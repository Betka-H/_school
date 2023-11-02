Console.WriteLine(maximum(16, 42));
float maximum(float x, float y)
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



void userNumber()
{
    int userNumber;
    bool inputParse;
    {
        Console.Write("please input your number: ");
        inputParse = Int32.TryParse(Console.ReadLine(), out userNumber);
    } while (!inputParse) ;

    Console.WriteLine("your number is: " + userNumber);

}

userNumber();