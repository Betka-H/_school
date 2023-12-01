// 1 to run (getting annoying warnings otherwise)
static void trebuchet1(int run) // day 1, part 1
{
    if (run == 1)
    {
        static void color(string s, string c)
        {
            switch (c)
            {
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void printIntArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }

        string[] lines = File.ReadAllLines("C:\\Users\\eliza\\Downloads\\inputFile.txt");

        int[] addedInts = { };
        for (int i = 0; i < 3 /* lines.Length */; i++) // for each line (string)
        {
            int[] foundInts = { };
            char[] chars = lines[i].ToCharArray(); // separates the string into a char array
            color(lines[i], "yellow");

            for (int y = 0; y < chars.Length; y++) // for each char in the array
            {
                // Console.WriteLine($"loop: {y}, char: {chars[y]}");

                if (int.TryParse(chars[y].ToString(), out int x)) // check if it is a number
                {
                    Array.Resize(ref foundInts, foundInts.Length + 1); // resize "numbers found in string" array
                    color($"int found!: {x}", "green");
                    foundInts[foundInts.Length - 1] = x; // write number into the resized array
                }
            }
            printIntArray(foundInts);
            Array.Resize(ref addedInts, addedInts.Length + 1);
            addedInts[addedInts.Length - 1] = int.Parse(foundInts[0].ToString() + foundInts[foundInts.Length - 1].ToString());

            Console.WriteLine($" > {foundInts[0]}{foundInts[foundInts.Length - 1]}\n"); // 2 digit number

            // color($"string {i + 1} done!\n", "yellow");
        }
        int r = 0;
        foreach (int i in addedInts)
        {
            r += i;
        }
        Console.Write($"the part 1 result is: {r}");
    }
}
trebuchet1(0);


