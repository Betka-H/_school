using System.Text.RegularExpressions;

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
        case "blue":
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case "magenta":
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case "darkred":
            Console.ForegroundColor = ConsoleColor.DarkRed;
            break;
        case "orange":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            break;
    }
    Console.Write(s);
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
        string[] lines = File.ReadAllLines("inputs\\D1.txt");

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
        Console.WriteLine("\a");
    }
}
trebuchet(0); // 55712 - 55413

static void cubes1(int run) // day 2
{
    if (run != 0)
    {
        string[] lines = File.ReadAllLines("inputs\\D2.txt");
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
        Console.WriteLine("\a");
    }
}
cubes1(0); // 2283 - 78669

static void liftEngine(int run)
{
    if (run != 0)
    {
        if (run == 1)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\eliza\\.vscode\\_school\\adventOfCode\\inputs\\D3.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                color("=", "green");
            }
            Console.WriteLine();
            /* foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
             */

            string key = "x";
            for (int i = 0; i < lines.Length; i++) // for each line
            {
                lines[i] = "  " + lines[i].Replace(".", " ").Replace("*", key).Replace("#", key).Replace("&", key).Replace("$", key).Replace("%", key).Replace("-", key).Replace("/", key).Replace("+", key).Replace("=", key).Replace("@", key) + "     "; // adds padding on both sides and replaces "." with whitespace
            }
            int result = 0;
            for (int i = 0; i < lines.Length; i++) // for each line
            {
                for (int y = 0; y < lines[i].Length; y++) // for every character
                {
                    if (char.IsDigit(lines[i][y])) // if the character is a digit
                    {
                        int digit;
                        if (char.IsDigit(lines[i][y + 1]) && char.IsDigit(lines[i][y + 2])) // next two chars are digits
                        {
                            if (lines[i - 1][y - 1].ToString() != " " && !char.IsDigit(lines[i - 1][y - 1]) || lines[i - 1][y].ToString() != " " && !char.IsDigit(lines[i - 1][y]) || lines[i - 1][y + 1].ToString() != " " && !char.IsDigit(lines[i - 1][y + 1]) || lines[i - 1][y + 2].ToString() != " " && !char.IsDigit(lines[i - 1][y + 2]) || lines[i - 1][y + 3].ToString() != " " && !char.IsDigit(lines[i - 1][y + 3]) || lines[i][y - 1].ToString() != " " && !char.IsDigit(lines[i][y - 1]) || lines[i][y + 3].ToString() != " " && !char.IsDigit(lines[i][y + 3]) || lines[i + 1][y - 1].ToString() != " " && !char.IsDigit(lines[i + 1][y - 1]) || lines[i + 1][y].ToString() != " " && !char.IsDigit(lines[i + 1][y]) || lines[i + 1][y + 1].ToString() != " " && !char.IsDigit(lines[i + 1][y + 1]) || lines[i + 1][y + 2].ToString() != " " && !char.IsDigit(lines[i + 1][y + 2]) || lines[i + 1][y + 3].ToString() != " " && !char.IsDigit(lines[i + 1][y + 3]))
                            {

                               
                                    digit = int.Parse($"{lines[i][y]}" + $"{lines[i][y + 1]}" + $"{lines[i][y + 2]}");
                                    color(digit.ToString(), "green");
                                    result += digit;
                                

                                /* if (run == 2)
                                {
                                    if (lines[i - 1][y - 1].ToString() == "*" || lines[i - 1][y].ToString() == "*" || lines[i - 1][y + 1].ToString() == "*" || lines[i - 1][y + 2].ToString() == "*" || lines[i - 1][y + 3].ToString() == "*" || lines[i][y - 1].ToString() == "*" || lines[i][y + 3].ToString() == "*" || lines[i + 1][y - 1].ToString() == "*" || lines[i + 1][y].ToString() == "*" || lines[i + 1][y + 1].ToString() == "*" || lines[i + 1][y + 2].ToString() == "*" || lines[i + 1][y + 3].ToString() == "*")
                                    {
                                        digit = int.Parse($"{lines[i][y]}" + $"{lines[i][y + 1]}" + $"{lines[i][y + 2]}");
                                        color(digit.ToString(), "green");
                                        result += digit;
                                    }
                                } */
                            }
                            else // if there is no symbol
                            {
                                color(lines[i][y].ToString(), "blue");
                                color(lines[i][y + 1].ToString(), "blue");
                            }
                            y++;
                        }
                        else /* if (!char.IsDigit(lines[i][y + 1]) && !char.IsDigit(lines[i][y - 1]))// only this char is a digit */
                        {
                            if (lines[i - 1][y - 1].ToString() == key || lines[i - 1][y].ToString() == key || lines[i - 1][y + 1].ToString() == key || lines[i][y - 1].ToString() == key || lines[i][y + 1].ToString() == key || lines[i + 1][y - 1].ToString() == key || lines[i + 1][y].ToString() == key || lines[i + 1][y + 1].ToString() == key)
                            {
                                /* color(lines[i][y].ToString(), "magenta");
                                color(lines[i][y + 1].ToString(), "magenta"); */
                                digit = int.Parse($"{lines[i][y]}");
                                color(digit.ToString(), "green");
                                result += digit;
                            }
                            else // if there is no symbol
                            {
                                color(lines[i][y].ToString(), "magenta");
                            }
                        }

                    }
                    else
                    {
                        Console.Write(lines[i][y]);
                    }
                }
                color("X", "magenta");
                Console.WriteLine();
            }
            Console.WriteLine(result);
        }

        if (run == 2)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\eliza\\.vscode\\_school\\adventOfCode\\inputs\\D3.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                color("=", "green");
            }
            Console.WriteLine();

            string key = " ";
            for (int i = 0; i < lines.Length; i++) // for each line
            {
                lines[i] = "  " + lines[i].Replace(".", " ").Replace("#", key).Replace("&", key).Replace("$", key).Replace("%", key).Replace("-", key).Replace("/", key).Replace("+", key).Replace("=", key).Replace("@", key) + "     "; // adds padding on both sides and replaces "." with whitespace
            }
            int result = 0;
            for (int i = 0; i < lines.Length; i++) // for every line
            {

                for (int y = 0; y < lines[i].Length; y++) // for every char
                {

                    if (lines[i][y].ToString() == "*")
                    {
                        color(lines[i][y].ToString(), "green");

                        for (int n = 0; n <= 2; n++)
                        {


                            /* if (lines[i - 1][y - 1].ToString() == "*" || lines[i - 1][y].ToString() == "*" || lines[i - 1][y + 1].ToString() == "*" || lines[i - 1][y + 2].ToString() == "*" || lines[i - 1][y + 3].ToString() == "*" || lines[i][y - 1].ToString() == "*" || lines[i][y + 3].ToString() == "*" || lines[i + 1][y - 1].ToString() == "*" || lines[i + 1][y].ToString() == "*" || lines[i + 1][y + 1].ToString() == "*" || lines[i + 1][y + 2].ToString() == "*" || lines[i + 1][y + 3].ToString() == "*")
                                {
                                    digit = int.Parse($"{lines[i][y]}" + $"{lines[i][y + 1]}" + $"{lines[i][y + 2]}");
                                    color(digit.ToString(), "green");
                                    result += digit;
                                } */

                            /* 
                            if (char.IsDigit(lines[i - 1][y - 1])) // top left
                            {
                                if (char.IsDigit(lines[i - 1][y - 2]))
                                {

                                }
                                n++;
                            }
                            if (char.IsDigit(lines[i - 1][y])) // top center
                            {



                                n++;
                            }
                            if (char.IsDigit(lines[i - 1][y + 1])) // top right
                            {



                                n++;
                            }
                            if (char.IsDigit(lines[i][y - 1])) // middle left
                            {



                                n++;
                            }
                            if (char.IsDigit(lines[i - 1][y + 1])) // middle right
                            {



                                n++;
                            }
                            if (char.IsDigit(lines[i + 1][y - 1])) // bottom left
                            {



                                n++;
                            }
                            if (char.IsDigit(lines[i + 1][y])) // bottom center
                            {



                                n++;
                            }
                            if (char.IsDigit(lines[i + 1][y + 1])) // bottom right
                            {



                                n++;
                            } */
                        }



                        /*  if (char.IsDigit(lines[i - 1][y - 1]) || char.IsDigit(lines[i - 1][y]) || char.IsDigit(lines[i - 1][y + 1]) ||
             char.IsDigit(lines[i][y - 1]) || char.IsDigit(lines[i][y]) || char.IsDigit(lines[i][y + 1]) ||
             char.IsDigit(lines[i + 1][y - 1]) || char.IsDigit(lines[i + 1][y]) || char.IsDigit(lines[i + 1][y + 1]))
                         {
                             color(lines[i][y].ToString(), "green");
                         }
                         else
                         {
                             color(lines[i][y].ToString(), "red");
                         } */

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                color("X", "magenta");
            }
        }

    }
}
liftEngine(1); // 522726 - 










Console.WriteLine("\a");

