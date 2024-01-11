// ok how about i try to remake that old twine thing with the alarm clock
// yeah i could do that

// line 102 last edited come back later

#pragma warning disable CS8602 // Dereference of a possibly null reference.

Console.Clear();

static void delay(string s, int ms)
{
    Thread.Sleep(ms);
    Console.Write(s);
}
static void delayLine(string s, int ms)
{
    delay(s + "\n", ms);
}
static void title(string title)
{
    hr();
    delayLine(title, 500);
    hr();
}
static void hr()
{
    Thread.Sleep(250);
    for (int y = 0; y < Console.WindowWidth; y++)
        Console.Write("-");
    Console.WriteLine();
}

static void inputPrompt()
{
    delay("> ", 100);
}
static string userInput() // trim to lower
{
    return Console.ReadLine().Trim().ToLower();
}
static void returnToMain()
{
    hr();
    delayLine("press anything to return to the main menu", 100);
    inputPrompt();
    Console.ReadKey();
    loadPage("main menu");
}

static bool checkDupe(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        for (int y = i; y < a.Length - 1; y++)
        {
            if (a[i] == a[y + 1])
            {
                return true;
            }
        }
    }
    return false;
}

static void printContent(string[] a)
{
    for (int i = 0; i < a.Length; i += 2)
        delayLine($"{a[i]}: {a[i + 1]}", 100);
}
static void printOptions(string[] a, string[] b)
{
    for (int i = 0; i < a.Length; i++)
        delayLine($"{b[i]}: {a[i]}", 100);
}
static void checkOptions(string[] a, string[] b)
{ // exceptions
    if (checkDupe(a))
        throw new Exception("duplicate option detected!");
    if (checkDupe(b))
        throw new Exception("duplicate option letter detected!");
    if (a.Length < b.Length)
        throw new Exception("there are less options than option letters!");
    if (a.Length > b.Length)
        throw new Exception("there are more options than option letters!");
}

// pages
static void loadPage(string page)
{
    Console.Clear();
    // read menu info file
    string[] menuInfos = File.ReadAllLines("menuInfos.txt");
    string pageName,
        pageTitle;
    switch (page)
    {
        case "main menu":
            //
            pageName = "main menu";
            pageTitle = menuInfos[Array.IndexOf(menuInfos, pageName) + 1];

            static void split(string s) { }

            string[] options = { "start game", "stats", "credits", "quit game" };
            string[] optionLetters = { "s", "st", "c", "q" };
            checkOptions(options, optionLetters);

            title(pageTitle);
            printOptions(options, optionLetters);
            hr();

            // user selection
            inputPrompt();
            for (; ; )
                switch (userInput())
                {
                    case "s":
                        loadPage("game");
                        break;
                    case "st":
                        loadPage("stats");
                        break;
                    case "c":
                        loadPage("credits");
                        break;
                    case "q":
                        Console.WriteLine("goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("invalid input! try something else: ");
                        break;
                }
        // end case main menu

        case "game":
            Console.WriteLine("game here");
            break;

        case "stats":
            string[] stats = { "stat 1", "stat 1", "stat 2", "stat 2", "stat 3", "stat 3" };

            title("STATS");
            printContent(stats);
            returnToMain();

            break;

        case "credits":
            string[] credits = { "made by", "dex:)", "coded in", "c#", "made for", "fun" };

            title("CREDITS");
            printContent(credits);
            returnToMain();

            break;
        // end case credits
    }
}

loadPage("main menu");
