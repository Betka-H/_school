// ivt ***
int rows, columns;

int getInt()
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
System.ConsoleColor col1()
{
    return ConsoleColor.DarkYellow;
}
System.ConsoleColor col2()
{
    return ConsoleColor.Black;
}

Console.Title = "starry night (or anything else)";
for (; ; )
{
    Console.WriteLine(DateTime.Now);
    Console.Write("input the amount of rows: ");
    rows = getInt();
    Console.Write("input the amount of columns: ");
    columns = getInt();
    Console.WriteLine($"{rows} rows, {columns} columns");

    for (int i = 1; i <= rows; i++)
    {
        Console.ForegroundColor = col1();
        if (i % 2 == 0)
        {
            Console.ForegroundColor = col2();
        }
        for (int y = 1; y <= columns; y++)
        {
            Console.Write("* ");
            if (Console.ForegroundColor == col2())
            {
                Console.ForegroundColor = col1();
            }
            else
            {
                Console.ForegroundColor = col2(); ;
            }
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}