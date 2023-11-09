int[] coeficients = { 6, 4, 48, -4, 4, -1, 9, -21 };

/*
int[] numberArray2 = { };

void printArray(int[] y)
{
    for (int i = 0; i < y.Length; i++)
    {
        Console.Write(y[i]);
        if (i != y.Length - 1)
        {
            Console.Write(", ");
        }
        // y[i] = 42;
    }
    Console.WriteLine();
} 
Console.WriteLine("array 1:");
printArray(numberArray);
Console.WriteLine("array 2:");
printArray(numberArray2);
*/

void printPoly(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}x^{a.Length - (i + 1)} ");
        if (i != a.Length - 1)
        {
            Console.Write("+ ");
        }
    }
}

printPoly(coeficients);