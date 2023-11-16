Random rnd = new Random();
float questionAmount = 5, result;
int op1, op2, i;

int question()
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            return x;
        }
        Console.Write("please input a whole number: ");
    }
}
void getResult(float x, int op1, float y, int op2, float z)
{
    Console.WriteLine($"question {i}: what's {x} {if } {y} {op2.ToString()} {z}?");
    result = 5;
}

Console.WriteLine("welcome the the math quiz! you will get several questions that you will have to solve! good luck.");

for (i = 1; i <= questionAmount; i++)
{
    question(rnd.Next(50 * i), rnd.Next(1), rnd.Next(50 * i), rnd.Next(1), rnd.Next(50 * i));

    /* for (; ;;){

    if (getInt() == result)
    {

    }
} */
}

Console.Write("press anything to exit");
Console.ReadKey();