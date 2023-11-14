// ivt ***
int rows, columns;

int getInt()
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine().ToLower(), out int x))
        {
            return x;
        }
        Console.Write("please input a whole number: ");
    }
}

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("input the amount of rows: ");
rows = getInt();
Console.Write("input the amount of columns: ");
columns = getInt();
Console.WriteLine($"{rows} rows, {columns} columns");

for (int i = 1; i <= rows; i++)
{
    for (int y = 1; y <= columns; y++)
    {
        if (Console.ForegroundColor == ConsoleColor.Green)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.Write("* ");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Gray;