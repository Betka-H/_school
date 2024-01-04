/*
smycka dokud si uzivatel nepreje skoncit nebo dokud nedojdou otazky
umet zamichat poradi otazek
bonus: zamichani poradi odpovedi, moznost zadani poctu otazek
bonus 2: znovu se zepta na otazky, co byly spatne
*/
/* first
static void color(string t, string c)
{
    switch (c)
    {
        case "red":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case "green":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case "cyan":
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        case "magenta":
            Console.ForegroundColor = ConsoleColor.Magenta;
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
float score = 0;

for (int i = 0; i < lines.Length; i++)
{
    string[] line = lines[i].Split("|");
    string ans = line[1].ToLower();
    string ansA = line[2];
    string ansB = line[3];
    string ansC = line[4];
    color($"otazka {i + 1}: {line[0]}", "cyan"); // otazka
    Console.WriteLine($"A) {ansA}"); // otazka 1
    Console.WriteLine($"B) {ansB}"); // otazka 2
    Console.WriteLine($"C) {ansC}"); // otazka 3
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
    {
        color("spatne :((", "red");
        Console.Write($"spravna odpoved je {ans}: ");
        switch (ans)
        {
            case "a":
                Console.WriteLine(ansA);
                break;
            case "b":
                Console.WriteLine(ansB);
                break;
            case "c":
                Console.WriteLine(ansC);
                break;
        }
    }
}

// results
Console.WriteLine("tvuj vysledek:");
if (score == lines.Length) // 10/10
{
    color($"skvele! vsechno mas spravne :)", "magenta");
}
else if (score == 0) // 0/10
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

color($"skore: {score}/{lines.Length} ({MathF.Round(score / lines.Length * 100)}%)", "magenta");
 */

Console.OutputEncoding = System.Text.Encoding.UTF8; //
Random rnd = new Random(); //

static void color(string t, string c)
{
    switch (c)
    {
        case "red":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case "green":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case "cyan":
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        case "magenta":
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case "black":
            Console.ForegroundColor = ConsoleColor.Black;
            break;
    }
    Console.WriteLine(t);
    Console.ForegroundColor = ConsoleColor.Gray;
}

string[] shuffle(string[] a)
{
    string[] b = new string[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        int r = rnd.Next(a.Length);
        if (!b.Contains(a[r]))
            b[i] = a[r];
        else
            i--;
    }
    return b;
}
color("test autoskoly. ", "magenta");
string[] allQ = File.ReadAllLines("questions.data");
allQ = shuffle(allQ);

int QAmount = 12;
Console.Write($"pocet otazek: {QAmount} (zadej \"z\" pro zmenu): ");
switch (Console.ReadLine().ToLower())
{
    case "z":
        int getPosInt() // get [positive int] from user
        {
            Console.Write(
                $"prosim zadej cele cislo vetsi nez nula a mensi nebo rovno {allQ.Length}: "
            );
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    if (x > 0 && x <= allQ.Length)
                    {
                        return x;
                    }
                }
            }
        }
        QAmount = getPosInt();
        break;
}

for (int i = 0; i < QAmount; i++)
{
    string[] line = allQ[i].Split("|"); // splits the line into the separate components

    // specifies which option is correct
    string correctAnswer = "";
    switch (line[1].ToLower())
    {
        case "a":
            correctAnswer = line[2];
            break;
        case "b":
            correctAnswer = line[3];
            break;
        case "c":
            correctAnswer = line[4];
            break;
    }

    // option array
    string[] options = new string[line.Length - 2];
    for (int y = 0; y < options.Length; y++)
    {
        options[y] = line[y + 2];
    }
    options = shuffle(options);

    color($"otazka {i + 1}: {line[0]}", "cyan"); // prints the question
    color($"ans: {correctAnswer}", "black");
    // write out the options
    for (int y = 0; y < options.Length; y++)
    {
        switch (y)
        {
            case 0:
                Console.Write("A) ");
                break;
            case 1:
                Console.Write("B) ");
                break;
            case 2:
                Console.Write("C) ");
                break;
        }
        Console.WriteLine(options[y]);
    }
}
