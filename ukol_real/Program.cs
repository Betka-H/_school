static void color(string t, string c)
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
        case "magenta":
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case "purple":
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            break;
        case "black":
            Console.ForegroundColor = ConsoleColor.Black;
            break;
    }
    Console.WriteLine(t);
    Console.ForegroundColor = ConsoleColor.Gray;
}

color("test autoskoly. dostanes otazky a odpovis na ne:", "magenta");

string[] lines = File.ReadAllLines("autoskolaQ.data");
int score = 0;

for (int i = 0; i < lines.Length; i++)
{
    string[] line = lines[i].Split("|");
    color($"otazka {i + 1}: {line[0]}", "cyan"); // otazka
    string ans = line[1].ToLower();
    // color($"((odpoved: {ans}))", "black"); // spravna odpoved
    Console.WriteLine($"A) {line[2]}"); // otazka 1
    Console.WriteLine($"B) {line[3]}"); // otazka 2
    Console.WriteLine($"C) {line[4]}"); // otazka 3
    string guess;
    for (; ; )
    {
        Console.Write("vyber odpoved (a/b/c): ");
        guess = Console.ReadLine().ToLower();
        if (guess != "a" && guess != "b" && guess != "c")
        {
            color("neplatný vstup!", "red");
        }
        else
            break;
    }

    if (guess == ans)
    {
        color("spravne!", "green");
        score++;
    }
    else
        color("spatne :((", "red");
}

// results
Console.WriteLine("tvuj vysledek:");
if (score == lines.Length) // 10/10
{
    color($"skvele! vsechno mas spravne :)", "magenta");
}
else
{
    if (score == 0) // 0/10
    {
        color($"prosim, nikdy nesedej za volant...", "red");
    }
    else if (score == lines.Length - 1) // 9/10
    {
        color($"jen o kousek!", "magenta");
    }
    else if (score >= lines.Length / 2) // over half
    {
        color($"slo by to lepe...", "magenta");
    }
    else // else - under half
    {
        color($"nic moc :(", "magenta");
    }
    color($" (celkove skore: {score}/{lines.Length})", "magenta");
}
