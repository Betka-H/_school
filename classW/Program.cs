// 0 to not run, 1 to run

using System.Runtime.CompilerServices;

Random rnd = new Random(); // rnd.Next(min, max);
static double getDouble() // get [double] from user
{
    for (; ; )
    {
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            return x;
        }
        Console.Write("not a number! please enter a number: ");
    }
}
static int getInt() // get [integer] from user
{
    for (; ; )
    {
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            return x;
        }
        Console.Write("not an integer! please enter a number: ");
    }
}
static void printIntArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
        // if (i < a.Length - 1)
        { }
        Console.Write(" ");
    }
}
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

/* static void color(string t, string c)
{
    switch (c)
    {
        case "red":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case "darkred":
            Console.ForegroundColor = ConsoleColor.DarkRed;
            break;
        case "orange":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            break;
        case "yellow":
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case "gold":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            break;
        case "green":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case "darkgreen":
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            break;
        case "cyan":
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        case "darkcyan":
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            break;
        case "blue":
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case "darkblue":
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            break;
        case "pink":
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case "purple":
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            break;
        case "black":
            Console.ForegroundColor = ConsoleColor.Black;
            break;
    }
    Console.Write(t);
    Console.ForegroundColor = ConsoleColor.Gray;
}
 */

static void starryNight(int run) // star field
{
    if (run == 1)
    {
        int rows,
            columns;

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
                        Console.ForegroundColor = col2();
                        ;
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
starryNight(0);
static void printCards(int run) // print card deck (inscryption-like in shape)
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
printCards(0);
static void vectors1(int run) // multiply and add vectors idkk
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
vectors1(0);
static void fucktorial(int run) // input and factor a number
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
fucktorial(0);
static void hadanka(int run) // guess a random number (limited attempts)
{
    if (run == 1)
    {
        int nMin = 1,
            nMax = 100;
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
            int n = rnd.Next(nMin, nMax),
                attN = 5;
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
hadanka(0);
static void traits(int run)
{
    if (run != 0)
    {
        string[] traits =
        {
            "perseverance",
            "kindness",
            "bravery",
            "loyalty",
            "love",
            "patience",
            "togetherness",
            "truthfulness",
            "wisdom",
            "Resilient",
            "Empathetic",
            "Composed",
            "Creative",
            "Open-minded",
            "Positive",
            "Humorous",
            "Ambitious",
            "Kind-hearted",
            "Communicative",
            "Loyal",
            "Analytical",
            "Adventurous",
            "Patient",
            "Empowering",
            "Authentic",
            "Collaborative",
            "Adaptable",
            "Passionate",
            "Mindful",
            "Genuine",
            "Attentive",
            "Honest",
            "Assertive",
            "Diligent",
            "Non-judgmental",
            "Optimistic",
            "Grateful",
            "Self-aware",
            "Meticulous",
            "Generous",
            "Multitasker",
            "Innovative",
            "Balanced",
            "Consistent",
            "Respectful",
            "Fearless",
            "Tech-savvy",
            "Humble",
            "Reliable",
            "Easygoing",
            "Compassionate"
        };

        static string getString()
        {
            for (; ; )
            {
                string? s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    return s;
                }
            }
        }
        for (int i = 0; i < 21; i++)
        {
            Console.Write("state your name: ");
            Console.WriteLine(
                $"{getString()} gets {traits[new Random().Next(0, traits.Length)]}\n"
            );
        }
    }
}
traits(0);
static void fibonacci(int run)
{
    if (run != 0)
    {
        static int thing(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            if (i == 0)
            {
                return 0;
            }

            int x = thing(i - 1);
            int y = thing(i - 2);

            return x + y;
        }
        Console.WriteLine(thing(17));
    }
}
fibonacci(0);
static void fucktorial2electricboogaloo(int run)
{
    if (run != 0)
    {
        static double factorize(double n)
        {
            double previous = factorize(n - 1);
            if (n == 1)
            {
                return 1;
            }
            return n * previous;
        }
        Console.WriteLine(factorize(21));
    }
}
fucktorial2electricboogaloo(0);
void sort(int run) // sorting algorithms my beloved
{
    if (run != 0)
    {
        // random array creation
        int[] rndArray = { };
        int rndArraySize = 42;
        for (int i = 0; i < rndArraySize; i++)
        {
            Array.Resize(ref rndArray, rndArray.Length + 1);
            rndArray[rndArray.Length - 1] = rnd.Next(420);
        }
        printIntArray(rndArray);
        Console.WriteLine();

        static int[] sortIntArray(int[] a)
        {
            /* static bool isSorted(int[] a) // check if every number in the array is larger than the one before
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            } */
            // while (!isSorted(a))
            for (int j = 0; j < a.Length - 1; j++)
            {
                for (int i = 0; i < a.Length - j - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int tmp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = tmp;
                    }
                }
            }
            return a;
        }
        printIntArray(sortIntArray(rndArray));
    }
}
sort(0);
void power1(int run)
{
    if (run != 0)
    {
        for (; ; )
        {
            Console.Write("input number a (base): ");
            double a = getDouble();
            Console.Write("input number b (power): ");
            double b = getInt();
            Console.WriteLine($"{a}^({b}) = " + Math.Round(Math.Pow(a, b), 2));
        }
        /* for (; ; )
        {
            Console.Write("input number a: ");
            double a = getDouble();
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(a + "^" + i + " === " + Math.Pow(a, i) + "\n");
            }
        } */
    }
}
power1(0);
void applez(int run) // reseni ulohy ("bossfight")
{
    if (run != 0)
    {
        Console.Write("how many apples do you have in stock? > ");
        int stock = getPosInt();
        int purchases = 0;
        for (int i = 1; ; i++)
        {
            Console.Write($"customer {i} wants to buy how many apples? > ");
            int purchase = getPosInt();
            if (purchase <= stock)
            {
                purchases++;
                stock -= purchase;
                Console.WriteLine($"you now have {stock} apples remaining in stock.");
                if (stock == 0)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("you dont have enough apples in stock!");
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
        Console.WriteLine($"you cant sell any more apples! you made {purchases} sales in total.");
    }
}
applez(0);
void logik(int run) // logik
{
    if (run != 0)
    {
        static void color(string t, string c)
        {
            switch (c)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "purple":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write(t);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void printStringArray(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                color("@", a[i]);
                if (i < a.Length - 1)
                {
                    Console.Write(" ");
                }
            }
        }

        string[] colors =  { "red", "yellow", "green", "blue", "purple", "cyan", "black", "white" },
            code1 =  { };
        int columns = 6,
            rows = 12;

        // array creation
        for (int i = 0; i < columns; i++)
        {
            Array.Resize(ref code1, code1.Length + 1);
            code1[code1.Length - 1] = colors[rnd.Next(colors.Length)];
        }

        // debug print solution
        Console.Write("solution (debug): ");
        printStringArray(code1);
        Console.WriteLine();

        void printColNumber()
        {
            for (int h = 0; h <= $"row {rows}:".Length; h++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= columns; i++)
            {
                Console.Write(i + " ");
            }
        }
        printColNumber();
        Console.WriteLine();

        for (int y = 1; y <= rows; y++) // for each row
        {
            Console.Write($"row {y}:");
            for (int h = $"row {y}:".Length; h <= $"row {rows}:".Length; h++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < columns; i++)
            {
                Console.Write("@ ");
            }
            Console.WriteLine();
        }

        printColNumber();

        Console.WriteLine();
        for (int r = 1; r <= rows; r++)
        {
            string[] guess = { };
            for (int c = 1; c <= columns; c++)
            {
                Console.Write($"guess color {r};{c}: ");
                string g = Console.ReadLine();
                if (colors.Contains(g))
                {
                    Array.Resize(ref guess, guess.Length + 1);
                    guess[guess.Length - 1] = g;
                }
                else
                {
                    Console.WriteLine("invalid guess!");
                    c--;
                }
            }
            Console.WriteLine($"row {r} done");
        }
    }
}
logik(0);
