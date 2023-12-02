// 0 to not run, 1 to run part 1, 2 to run part 2
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
        case "red":
            Console.ForegroundColor = ConsoleColor.Red;
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

static void trebuchet(int run) // day 1
{
    if (run != 0)
    {
        string[] lines = File.ReadAllLines("C:\\Users\\eliza\\.vscode\\_school\\adventOfCode\\inputs\\D1.txt");

        int[] addedInts = { };
        for (int i = 0; i < lines.Length; i++) // for each line (string)
        {
            color($"1: {lines[i]}", "yellow");
            if (run == 2)
            {
                lines[i] = lines[i].Replace("one", "onee");
                lines[i] = lines[i].Replace("two", "twoo");
                lines[i] = lines[i].Replace("three", "threee");
                lines[i] = lines[i].Replace("four", "fourr");
                lines[i] = lines[i].Replace("five", "fivee");
                lines[i] = lines[i].Replace("six", "sixx");
                lines[i] = lines[i].Replace("seven", "sevenn");
                lines[i] = lines[i].Replace("eight", "eightt");
                lines[i] = lines[i].Replace("nine", "ninee");

                color($"2: {lines[i]}", "yellow");

                lines[i] = lines[i].Replace("one", "1");
                lines[i] = lines[i].Replace("two", "2");
                lines[i] = lines[i].Replace("three", "3");
                lines[i] = lines[i].Replace("four", "4");
                lines[i] = lines[i].Replace("five", "5");
                lines[i] = lines[i].Replace("six", "6");
                lines[i] = lines[i].Replace("seven", "7");
                lines[i] = lines[i].Replace("eight", "8");
                lines[i] = lines[i].Replace("nine", "9");

                color($"3: {lines[i]}", "yellow");
            }
            int[] foundInts = { };
            char[] chars = lines[i].ToCharArray(); // separates the string into a char array

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
        Console.WriteLine($"the part 1 result is: {r}");
    }
}
trebuchet(0); // 55712 - 55413

static void cubes1(int run) // day 2
{
    if (run != 0)
    {
        string[] lines = File.ReadAllLines("C:\\Users\\eliza\\.vscode\\_school\\adventOfCode\\inputs\\D2.txt");
        bool suces = false;
        int[] results = { };
        int result = 0;
        for (int i = 0; i < lines.Length; i++) // for each line (string)
        {
            string currentLine = lines[i].Replace(" ", "");
            color(currentLine, "yellow"); // writes the current line
            int[] red = { }, green = { }, blue = { };
            for (int y = currentLine.IndexOf(":") + 1; y < currentLine.Length; y++) // for every character after ":"
            {
                int[] numbers = { };
                if (char.IsDigit(currentLine[y])) // if the current char is a digit
                {
                    if (char.IsDigit(currentLine[y - 1])) // if the previous char is also a digit
                    {
                        Array.Resize(ref numbers, numbers.Length + 1);
                        numbers[numbers.Length - 1] = int.Parse($"{currentLine[y - 1]}" + $"{currentLine[y]}");
                        color($"int found!: {numbers[numbers.Length - 1]}", "green");
                    }
                    else if (!char.IsDigit(currentLine[y + 1])) // if the following char isnt a digit
                    {
                        Array.Resize(ref numbers, numbers.Length + 1);
                        color($"int found!: {currentLine[y]}", "green");
                        numbers[numbers.Length - 1] = int.Parse(currentLine[y].ToString());
                    }

                    if (run == 1)
                    {
                        int maxRed = 12, maxGreen = 13, maxBlue = 14;
                        if (currentLine[y + 1].ToString() == "r" && numbers[numbers.Length - 1] > maxRed)
                        {
                            color("illegal red", "red");
                            suces = false;
                            break;
                        }
                        else if (currentLine[y + 1].ToString() == "g" && numbers[numbers.Length - 1] > maxGreen)
                        {
                            suces = false;
                            color("illegal green", "red");
                            break;
                        }
                        else if (currentLine[y + 1].ToString() == "b" && numbers[numbers.Length - 1] > maxBlue)
                        {
                            suces = false;
                            color("illegal blue", "red");
                            break;
                        }
                        else
                        {
                            suces = true;
                        }
                    }
                    if (run == 2)
                    {
                        switch (currentLine[y + 1].ToString())
                        {
                            case "r":
                                Array.Resize(ref red, red.Length + 1);
                                red[red.Length - 1] = numbers[numbers.Length - 1];
                                break;
                            case "g":
                                Array.Resize(ref green, green.Length + 1);
                                green[green.Length - 1] = numbers[numbers.Length - 1];
                                break;
                            case "b":
                                Array.Resize(ref blue, blue.Length + 1);
                                blue[blue.Length - 1] = numbers[numbers.Length - 1];
                                break;
                        }
                    }
                }
            }
            Console.WriteLine();
            switch (run)
            {
                case 1:
                    if (suces)
                    {
                        result += i + 1; // it litrally just adds all of them lmao}
                        Console.WriteLine(result);
                    }
                    break;
                case 2:
                    Array.Resize(ref results, results.Length + 1);
                    results[results.Length - 1] = red.Max() * green.Max() * blue.Max();
                    break;
            }
        }
        switch (run)
        {
            case 1:
                Console.WriteLine(result);
                break;
            case 2:
                foreach (int r in results)
                {
                    result += r;
                }
                Console.WriteLine("\n" + result);
                break;
        }
    }
}
cubes1(2); // 2283 - 78669

