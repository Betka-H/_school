// 1 to run (getting annoying warnings otherwise)
static void _starryNight(int run) // star field
{
    if (run == 1)
    {
        int rows, columns;

        int getPosInt()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    if (x > 0)
                    {
                        return x;
                    }
                }
                Console.Write("please input a whole positive number: ");
            }
        }
        System.ConsoleColor col1()
        {
            return ConsoleColor.DarkYellow;
        }
        System.ConsoleColor col2()
        {
            return ConsoleColor.Blue;
        }

        Console.Title = "starry night";
        for (; ; )
        {
            Console.WriteLine(DateTime.Now);
            Console.Write("input the amount of rows (height): ");
            rows = getPosInt();
            Console.Write("input the amount of columns (width): ");
            columns = getPosInt();
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
    }
}
_starryNight(0);
static void _printCards(int run) // print card deck (inscryption-like in shape)
{
    if (run == 1)
    {
        static int getPosInt() // positive int from user
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    if (x > 0)
                    {
                        return x;
                    }
                }
                Console.Write("please enter an integer (> 0): ");
            }
        }
        static void printC()
        {
            Console.Write("[]");
        }

        for (; ; )
        {
            Console.Write("please enter the amount of cards: ");
            int cardN = getPosInt(); // number of cards to draw
            if (cardN <= 10) // change card limit for one row here!!
            {
                for (int i = 1; i <= cardN; i++) // only 1 line if less/equal than/to 8
                {
                    printC();
                }
            }
            else
            {
                for (int i = 1; i <= cardN / 2; i++) // 1st line
                {
                    printC();
                }
                Console.WriteLine();
                for (int y = cardN / 2 + 1; y <= cardN; y++) // 2nd line
                {
                    printC();
                }
            }
            Console.WriteLine();
        }
    }
}
_printCards(0);
static void _vectors1(int run) // multiply and add vectors idkk
{
    if (run == 1)
    {
        static void printV(float[] vector)
        {
            foreach (float f in vector)
            {
                Console.Write($"{f}, ");
            }
            Console.WriteLine();
        }


        // multiply vector
        static float[] scaleVector(float[] vector, float scalar)
        {
            float[] vectorNew = new float[vector.Length]; // make a new array with the same length as the input one
            for (int i = 0; i < vector.Length; i++)
            {
                vectorNew[i] = vector[i] * scalar; // should multiply all the numbers (only multiplies one??)
            }
            Console.WriteLine($"> scalar = {scalar}");
            return vectorNew;
        }
        // vectors
        float[] vector11 = { 2f, 3f };
        float[] vector12 = scaleVector(vector11, 3);
        // print
        Console.Write("vector 1: ");
        printV(vector11);
        Console.Write("vector 2: ");
        printV(vector12);


        Console.WriteLine();
        // add 2 vectors
        static float[] addVectors(float[] vector1, float[] vector2)
        {
            float[] vectorNew = new float[vector1.Length]; // make a new array with the same length as the input one
            for (int i = 0; i < vector1.Length; i++)
            {
                vectorNew[i] = vector1[i] + vector2[i]; // should multiply all the numbers (only multiplies one??)
            }
            return vectorNew;
        }
        // vectors
        float[] vector21 = { 3.5f, 4.7f };
        float[] vector22 = { 5f, 6f };
        float[] vector23 = addVectors(vector21, vector22);
        // print
        Console.Write("vector 3: ");
        printV(vector23);
    }
}
_vectors1(0);
static void _fucktorial(int run) // input and factor a number
{
    if (run == 1)
    {
        static double getDbl()
        {
            for (; ; )
            {
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    return x;
                }
                Console.Write("not an integer! please enter an integer: ");
            }
        }
        static double factorise(double n)
        {
            double x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            return x;
        }
        for (; ; )
        {
            Console.Write("please input an integer: ");
            double n = getDbl();
            Console.WriteLine($"{n}! = {factorise(n)}");
        }
    }
}
_fucktorial(0);
static void _hadanka(int run) // guess a random number (limited attempts)
{
    if (run == 1)
    {
        int nMin = 1, nMax = 100;
        Random rnd = new Random();
        static int getInt()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    return x;
                }
                Console.Write("not an integer! please enter an integer: ");
            }
        }

        for (; ; )
        {
            int n = rnd.Next(nMin, nMax), attN = 5;
            Console.WriteLine($"(debug) the number is {n}");
            Console.Write($"guess a number from {nMin} to {nMax}: ");
            for (int a = 1; a <= attN; a++)
            {
                int userN = getInt();
                if (userN == n)
                {
                    Console.WriteLine("suces! you guessed right");
                    break;
                }
                else if (a >= attN)
                {
                    Console.WriteLine("you ran out of attempts!");
                    break;
                }
                else if (userN > n)
                {
                    Console.Write("guess lower!: ");
                }
                else if (userN < n)
                {
                    Console.Write("guess higher!: ");
                }
            }
        }
    }
}
_hadanka(0);