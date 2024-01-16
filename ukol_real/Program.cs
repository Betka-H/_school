// vvv funkcni, ale stare verze
/* first coming
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
/* second coming
Console.OutputEncoding = System.Text.Encoding.UTF8; // czech encoding
Random rnd = new Random();

static void color(string t, string c) // for colored text
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
string[] shuffle(string[] a) // to shuffle questions and answers
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
string userInput() // string from user
{
    string s = Console.ReadLine().ToLower();
    if (s == "q")
    {
        Console.WriteLine("ukoncuji test...");
        Environment.Exit(0);
    }
    return s;
}
int userPosInt() // positive int from user
{
    for (; ; )
    {
        Console.Write($"prosim zadej cele cislo vetsi nez nula: ");
        if (int.TryParse(userInput(), out int x))
        {
            if (x > 0)
            {
                return x;
            }
        }
    }
}

color("test autoskoly. zadedj \"q\" kdykoliv k ukonceni testu ", "magenta");

// zmena poctu otazek
int QAmount = 5; // default
Console.Write($"pocet otazek: {QAmount} (zadej \"z\" pro zmenu, jinak pokracuj): ");
if (userInput() == "z")
{
    QAmount = userPosInt();
}
Console.WriteLine();

// create and resize q array
string[] allQ = File.ReadAllLines("questions.data"); // read the file
allQ = shuffle(allQ); // shuffle all questions
if (QAmount < allQ.Length) // only resize if the required q amount is larger than the real question amount, do not resize at all
{
    Array.Resize(ref allQ, QAmount); // resize q array to the desired question amount
}

for (; ; ) // main loop - for every test iteration
{
    float score = 0;
    QAmount = allQ.Length; // determines the original q amount
    allQ = shuffle(allQ); // shuffle all questions
    int qn = 0;

    for (int i = 0; i < QAmount; i++) // for every question
    {
        // i forgor what this was for but it breaks without xdd
        try
        {
            allQ[i].Split("|");
        }
        catch (IndexOutOfRangeException)
        {
            break;
        }

        qn++;

        string[] line = allQ[i].Split("|");

        // specifies which option is correct
        string correctAns = "";
        switch (line[1].ToLower())
        {
            case "a":
                correctAns = line[2];
                break;
            case "b":
                correctAns = line[3];
                break;
            case "c":
                correctAns = line[4];
                break;
        }

        // defines and shuffles the options
        string[] options = new string[line.Length - 2];
        for (int y = 0; y < options.Length; y++)
        {
            options[y] = line[y + 2];
        }
        options = shuffle(options);

        // determines the correct ans letter
        string correctAnsLetter = "";
        for (int y = 0; y < options.Length; y++)
        {
            if (options[y] == correctAns)
            {
                switch (y)
                {
                    case 0:
                        correctAnsLetter = "a";
                        break;
                    case 1:
                        correctAnsLetter = "b";
                        break;
                    case 2:
                        correctAnsLetter = "c";
                        break;
                }
            }
        }

        // prints the question

        color($"otazka {qn}/{QAmount}: {line[0]}", "cyan");
        // prints the correct answer
        color($"ans: {correctAnsLetter}) {correctAns}", "black");
        // print all the options
        for (int y = 0; y < options.Length; y++)
        {
            // prints the option
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

        // get user answer and give feedback on it
        for (; ; )
        {
            string guess;
            Console.Write("vyber odpoved (a/b/c): ");
            guess = userInput().Trim();
            if (guess != "a" && guess != "b" && guess != "c") // invalid
            {
                color("neplatný vstup!", "red");
            }
            else
            {
                if (guess == correctAnsLetter) // correct
                {
                    color("spravne!", "green");
                    score++;

                    // remove the question from the array
                    string[] tempQ = { };
                    foreach (string s in allQ)
                    {
                        if (s != allQ[i])
                        {
                            Array.Resize(ref tempQ, tempQ.Length + 1);
                            tempQ[tempQ.Length - 1] = s;
                        }
                    }
                    allQ = tempQ;
                    i--;
                }
                else // wrong
                {
                    color("spatne :((", "red");
                    color(
                        $"spravna odpoved je {correctAnsLetter.ToUpper()}: {correctAns}",
                        "yellow"
                    );
                }
                break;
            }
        }
        Console.WriteLine();
        if (allQ.Length == 0)
            break;
    }

    // scores

    // if all the questions were right, end the test
    if (score == QAmount)
    {
        color($"skvele! vsechno mas spravne :)", "magenta");
        break;
    }

    // if there are still questions left, show the scores and repeat the test
    Console.WriteLine("tvuj vysledek:");
    if (score == 0) // 0/10
    {
        color($"prosim, nikdy nesedej za volant...", "red");
    }
    else if (score == QAmount - 1) // 9/10
    {
        color($"jen o kousek!", "magenta");
    }
    else if (score >= QAmount / 2) // over half
    {
        color($"slo by to lepe...", "magenta");
    }
    else // else - under half
    {
        color($"nic moc :(", "magenta");
    }

    color($"skore: {score}/{QAmount} ({MathF.Round(score / QAmount * 100)}%)", "magenta");

    color(
        "tento test bude pokracovat dokud nebudes mit vse spravne! (zadej cokoliv k pokracovani (\"q\" k ukonceni programu))",
        "yellow"
    );
    Console.ReadKey();
    Console.WriteLine();
}
*/
/* third coming?
Console.OutputEncoding = System.Text.Encoding.UTF8; // cz encoding
Random rnd = new Random();
Console.Title = "autoskolni test";

static void color(string t, string c) // for colored text
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
string[] shuffle(string[] a) // to shuffle questions and answers
{
    string[] b = { };
    while (b.Length < a.Length)
    {
        int r = rnd.Next(a.Length);
        if (!b.Contains(a[r]))
        {
            Array.Resize(ref b, b.Length + 1);
            b[b.Length - 1] = a[r];
        }
    }
    return b;
}
string userInput() // string from user
{
    string s = Console.ReadLine().ToLower();
    if (s == "q")
    {
        Console.WriteLine("ukoncuji test...");
        Environment.Exit(0);
    }
    return s;
}
int userPosInt() // positive int from user
{
    for (; ; )
    {
        Console.Write($"prosim zadej cele cislo vetsi nez nula: ");
        if (int.TryParse(userInput(), out int x))
        {
            if (x > 0)
            {
                return x;
            }
        }
    }
}

string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

// create and shuffle q array
string[] allQ = File.ReadAllLines("questions.data"); // read the file
allQ = shuffle(allQ); // shuffle all questions

color("test autoskoly. zadedj \"q\" kdykoliv k ukonceni testu ", "magenta");

// zmena poctu otazek
Console.Write(
    $"pocet otazek: {allQ.Length} (zadej \"z\" pro zadani vlastniho poctu otazek, jinak pokracuj): "
);
if (userInput() == "z")
{
    int r = userPosInt();
    if (r < allQ.Length)
        Array.Resize(ref allQ, r); // resize q array to the desired question amount
}
string[] qTemp = allQ;

Console.WriteLine();

for (; ; ) // main loop - for every test iteration
{
    float score = 0;

    // set questiosn
    allQ = qTemp;
    Array.Resize(ref qTemp, 0);
    allQ = shuffle(allQ); // shuffle all questions

    for (int i = 0; i < allQ.Length; i++) // for every question
    {
        string[] line = allQ[i].Split("|"); // splits the line

        string[] options = line.Skip(2).ToArray(); // defines the options
        string correctAns = options[Array.IndexOf(alphabet.ToCharArray(), line[1][0])]; // specifies which option is correct
        options = shuffle(options); // shuffles the options
        string correctAnsLetter = alphabet[Array.IndexOf(options, correctAns)].ToString(); // determines the correct ans letter

        color($"otazka {i + 1}/{allQ.Length}: {line[0]}", "cyan"); // prints the question
        color($"ans: {correctAnsLetter}) {correctAns}", "black"); // prints the correct answer (for testing)
        for (int y = 0; y < options.Length; y++) // print all the options
        {
            Console.WriteLine($"{alphabet[y]}) {options[y]}");
        }

        for (; ; ) // get user answer and give feedback on it
        {
            // user input
            string guess;
            for (; ; )
            {
                // print vyber odpovedi
                Console.Write("vyber odpoved (");
                for (int y = 0; y < options.Length; y++)
                {
                    Console.Write(alphabet[y].ToString().ToLower());
                    if (y < options.Length - 1)
                    {
                        Console.Write("/");
                    }
                }
                Console.Write("): ");

                // limit the guess
                guess = userInput().Trim().ToUpper();
                bool checkGuess()
                {
                    for (int y = 0; y < options.Length; y++) // goes through all the questions
                    {
                        if (alphabet[y].ToString() == guess) // if the guess is in the first options.length part of alphabet, continue
                            return true;
                    }
                    return false; // otherwise repeat, the guess is not in the valid part of the alphabet
                }
                if (checkGuess())
                    break;
                // otherwise repeat, the guess is not in the valid part of the alphabet
                color("neplatný vstup!", "red");
            }

            if (guess == correctAnsLetter) // correct
            {
                color("spravne!", "green");
                score++;
            }
            else // wrong
            {
                color("spatne :((", "red");
                color($"spravna odpoved je {correctAnsLetter}: {correctAns}", "yellow");

                // add the q to the temp array
                Array.Resize(ref qTemp, qTemp.Length + 1);
                qTemp[qTemp.Length - 1] = allQ[i];
            }
            break;
        }
        Console.WriteLine();
        if (allQ.Length == 0)
            break;
    }

    // scores

    // if all the questions were right, end the test
    if (score == allQ.Length)
    {
        color($"skvele! vsechno mas spravne :)", "magenta");
        break;
    }

    // if there are still questions left, show the scores and repeat the test
    Console.WriteLine("tvuj vysledek:");
    if (score == 0) // 0/10
    {
        color($"prosim, nikdy nesedej za volant...", "red");
    }
    else if (score == allQ.Length - 1) // 9/10
    {
        color($"jen o kousek!", "magenta");
    }
    else if (score >= allQ.Length / 2) // over half
    {
        color($"slo by to lepe...", "magenta");
    }
    else // else - under half
    {
        color($"nic moc :(", "magenta");
    }

    color($"skore: {score}/{allQ.Length} ({MathF.Round(score / allQ.Length * 100)}%)", "magenta");

    color(
        "tento test bude pokracovat dokud nebudes mit vse spravne! (zadej cokoliv k pokracovani nebo \"q\" k ukonceni programu)",
        "yellow"
    );
    Console.ReadKey();
    Console.WriteLine();
} */
/* fourth...
// final hopefully
// test postupne dava otazky v zamichanem poradi
// odpovedi jsou take v zamichanem poradi
// test je schopen brat ze souboru otazky s odpovedmi od a-z (tento test je jenom a-c, ale umi to:))
// uzivatel na zacatku testu muze zmenit pocet otazek, jinak v testu je zakladni pocet 12 (da se jednoduse zmenit v promenne QAmount)
// rekne uzivateli jestli odpovedel spravne nebo spatne, popr. jaka byla spravna odpoved
// pred ukoncenim testu vyhodnoceni kolik otazek z kolika uzivatel zodpovedel spravne (i v %)

Console.OutputEncoding = System.Text.Encoding.UTF8; // cz encoding
Console.Title = "autoskolni test";

static void color(string t, string c) // for colored text
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
static string[] shuffle(string[] a) // to shuffle questions and answers
{
    string[] b = { };
    while (b.Length < a.Length)
    {
        int r = new Random().Next(a.Length);
        if (!b.Contains(a[r]))
        {
            Array.Resize(ref b, b.Length + 1);
            b[b.Length - 1] = a[r];
        }
    }
    return b;
}
static string userInput() // string from user
{
    return Console.ReadLine().ToLower().Trim();
}
static int userPosInt() // positive int from user
{
    for (; ; )
    {
        Console.Write($"prosim zadej cele cislo vetsi nez nula: ");
        if (int.TryParse(userInput(), out int x))
        {
            if (x > 0)
            {
                return x;
            }
        }
    }
}
static void evaluation(float sco, int tot)
{
    Console.WriteLine("tvuj vysledek:");
    if (sco == 0) // 0/10
    {
        color($"prosim, nikdy nesedej za volant...", "red");
    }
    else if (sco == tot - 1) // 9/10
    {
        color($"jen o kousek!", "magenta");
    }
    else if (sco >= tot / 2) // over half
    {
        color($"slo by to lepe...", "magenta");
    }
    else // else - under half
    {
        color($"nic moc :(", "magenta");
    }

    color($"skore: {sco}/{tot} ({MathF.Round(sco / tot * 100)}%)", "magenta");
}

const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

color("test autoskoly. zadedj \"ex\" kdykoliv k ukonceni a vyhodnoceni testu ", "magenta");

// create and shuffle q array
string[] allQ = File.ReadAllLines("questions.data"); // read the file
allQ = shuffle(allQ); // shuffle all questions

// zmena poctu otazek
int QAmount = 12; // default value
Console.Write(
    $"pocet otazek: {QAmount}/{allQ.Length} (zadej \"zm\" pro zadani vlastniho poctu otazek, jinak pokracuj): "
);
if (userInput() == "zm")
{
    QAmount = userPosInt();
}
if (QAmount < allQ.Length)
    Array.Resize(ref allQ, QAmount); // resize q array to the desired question amount (but only if it is less than the total q amount)
string[] qTemp = allQ;

Console.WriteLine();

for (; ; ) // main loop - for every test iteration. breaks on "ex" input or when all questions were answered right
{
    float score = 0;

    // set questiosn
    allQ = qTemp;
    Array.Resize(ref qTemp, 0);
    allQ = shuffle(allQ); // shuffle all questions

    for (int i = 0; i < allQ.Length; i++) // for every question
    {
        string[] line = allQ[i].Split("|"); // splits the line

        string[] options = line.Skip(2).ToArray(); // defines the options
        string correctAns = options[Array.IndexOf(alphabet.ToCharArray(), line[1][0])]; // specifies which option is correct
        options = shuffle(options); // shuffles the options
        string correctAnsLetter = alphabet[Array.IndexOf(options, correctAns)].ToString(); // determines the correct ans letter

        color($"otazka {i + 1}/{allQ.Length}: {line[0]}", "cyan"); // prints the question
        // color($"ans: {correctAnsLetter}) {correctAns}", "black"); // prints the correct answer (for testing)
        for (int y = 0; y < options.Length; y++) // print all the options
        {
            Console.WriteLine($"{alphabet[y]}) {options[y]}");
        }

        // get user answer and give feedback on it
        string guess;
        for (; ; )
        {
            // print vyber odpovedi
            Console.Write("vyber odpoved (");
            for (int y = 0; y < options.Length; y++) // "a/b/c"
            {
                Console.Write(alphabet[y].ToString().ToLower());
                if (y < options.Length - 1)
                {
                    Console.Write("/");
                }
            }
            Console.Write(") nebo \"nevim\": ");

            // the guess
            guess = userInput().ToUpper();
            if (guess.ToLower() == "ex") // evaluates and exits
            {
                Console.WriteLine("ukoncuji test a zobrazuji vysledky...");
                evaluation(score, i);
                Environment.Exit(0);
            }
            bool checkGuess()
            {
                for (int y = 0; y < options.Length; y++) // goes through all the questions
                {
                    if (alphabet[y].ToString() == guess) // if the guess is in the first options.length part of alphabet, continue (or if it is nevm)
                        return true;
                }
                return false; // otherwise repeat, the guess is not in the valid part of the alphabet
            }
            if (checkGuess() || guess.ToLower() == "nevim")
                break;

            // otherwise repeat, the guess is not valid
            color("neplatný vstup!", "red");
        }

        if (guess == correctAnsLetter) // correct
        {
            color("spravne!", "green");
            score++;
        }
        else // wrong
        {
            if (guess.ToLower() == "nevim")
                color("skoda...", "yellow");
            else
                color("spatne :((", "red");

            color($"spravna odpoved je {correctAnsLetter}: {correctAns}", "yellow");

            // add the failed q to the temp array
            Array.Resize(ref qTemp, qTemp.Length + 1);
            qTemp[qTemp.Length - 1] = allQ[i];
        }
        Console.WriteLine();
    }

    // scores
    // if all the questions were right, end the test
    if (score == allQ.Length)
    {
        color($"skvele! vsechno mas spravne :)", "magenta");
        break;
    }

    // if there are still questions left, show the scores and prompt test repeat
    evaluation(score, allQ.Length);
    color(
        "tento test bude pokracovat dokud nebudes mit vse spravne! (zadej cokoliv k pokracovani nebo \"ex\" k ukonceni programu)",
        "yellow"
    );
    if (userInput() == "ex") // exit
    {
        Console.WriteLine("ukoncuji test...");
        break;
    }

    Console.WriteLine();
} */



// s console.clear()
// final final hopefully
// test postupne dava otazky v zamichanem poradi
// odpovedi jsou take v zamichanem poradi
// test je schopen brat ze souboru otazky s odpovedmi od a-z (tento test je jenom a-c, ale umi to:))
// uzivatel na zacatku testu muze zmenit pocet otazek, jinak v testu je zakladni pocet 12 (da se jednoduse zmenit v promenne QAmount)
// rekne uzivateli jestli odpovedel spravne nebo spatne, popr. jaka byla spravna odpoved
// pred ukoncenim testu vyhodnoceni kolik otazek z kolika uzivatel zodpovedel spravne (i v %)

Console.OutputEncoding = System.Text.Encoding.UTF8; // cz encoding
Console.Title = "autoskolni test";

static void color(string t, string c) // for colored text
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
        case "cyan":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
static void hr()
{
    for (int y = 0; y < Console.WindowWidth; y++)
        Console.Write("-");
    Console.WriteLine();
}
static void shuffle(ref string[] a) // to shuffle questions and answers
{
    string[] b = { };
    while (b.Length < a.Length)
    {
        int r = new Random().Next(a.Length);
        if (!b.Contains(a[r]))
        {
            Array.Resize(ref b, b.Length + 1);
            b[b.Length - 1] = a[r];
        }
    }
    a = b;
}
static string userInput() // string from user
{
    return Console.ReadLine().ToLower().Trim();
}
static void userPosInt(ref int i) // positive int from user
{
    for (; ; )
    {
        Console.Write($"prosim zadej cislo: ");
        if (int.TryParse(userInput(), out i) && i > 0)
            break;
    }
}
static void evaluation(float sco, int tot)
{
    Console.WriteLine();
    if (tot == 0)
        color("nezodpovedel jsi zadne otazky...", "red");
    else
    {
        Console.WriteLine("tvuj vysledek:");

        if (sco == 0) // 0/10
            color($"prosim, nikdy nesedej za volant...", "red");
        else if (sco == tot - 1) // 9/10
            color($"jen o kousek!", "magenta");
        else if (sco >= tot / 2) // over half
            color($"slo by to lepe...", "magenta");
        else // else - under half
            color($"nic moc :(", "magenta");

        color($"skore: {sco}/{tot} ({MathF.Round(sco / tot * 100)}%)", "magenta");
        Console.WriteLine();
    }
}

const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

Console.Clear();
color("test autoskoly. zadedj \"ex\" kdykoliv k ukonceni/vyhodnoceni testu ", "magenta");

// create and shuffle q array
string[] allQ = File.ReadAllLines("questions.data"); // read the file
shuffle(ref allQ); // shuffle all questions

// zmena poctu otazek
try
{
    File.ReadAllLines("question_amount.txt");
}
catch (FileNotFoundException)
{
    throw new Exception(
        "file \"question_amount.txt\" not found! it should be somewhere in the same folder as the program.cs file"
    );
}
if (!int.TryParse(File.ReadAllLines("question_amount.txt")[0], out int QAmount))
    throw new Exception("file does not contain a number");
Console.Write(
    $"pocet otazek: {QAmount}/{allQ.Length} (zadej \"zm\" pro zadani vlastniho poctu otazek, jinak pokracuj): "
);
switch (userInput())
{
    case "ex":
        Environment.Exit(0);
        break;
    case "zm":
        userPosInt(ref QAmount);
        if (QAmount > allQ.Length)
            QAmount = allQ.Length;
        File.WriteAllText("question_amount.txt", QAmount.ToString());
        break;
}

Array.Resize(ref allQ, QAmount); // resize q array to the desired question amount

string[] qTemp = allQ;

Console.Clear();

for (; ; ) // main loop - for every test iteration. breaks on "ex" input or when all questions were answered right
{
    float score = 0;

    // set questiosn
    allQ = qTemp;
    Array.Resize(ref qTemp, 0);
    shuffle(ref allQ); // shuffle all questions

    for (int i = 0; i < allQ.Length; i++) // for every question
    {
        string[] line = allQ[i].Split("|"); // splits the line

        string[] options = line.Skip(2).ToArray(); // defines the options
        string correctAns = options[alphabet.IndexOf(line[1][0])]; // specifies which option is correct
        shuffle(ref options); // shuffles the options
        string correctAnsLetter = alphabet[Array.IndexOf(options, correctAns)].ToString(); // determines the correct ans letter

        // question frame
        Console.WriteLine();
        //
        color($"otazka {i + 1}/{allQ.Length}:", "cyan"); // prints the question
        color($"{line[0]}", "cyan"); // prints the question
        // color($"ans: {correctAnsLetter}) {correctAns}", "black"); // prints the correct answer (for testing)
        //
        Console.WriteLine();

        // print the options
        for (int y = 0; y < options.Length; y++)
            Console.WriteLine($"{alphabet[y]}) {options[y]}");

        Console.WriteLine();
        hr();

        // get user answer and give feedback on it
        string guess;
        for (; ; )
        {
            // print vyber odpovedi
            Console.Write("vyber odpoved (");
            for (int y = 0; y < options.Length; y++) // "a/b/c"
            {
                Console.Write(alphabet[y].ToString().ToLower());
                if (y < options.Length - 1)
                    Console.Write("/");
            }
            Console.Write(") nebo \"nevim\": ");

            // the guess
            guess = userInput().ToUpper();

            if (guess.ToLower() == "ex") // evaluates and exits
            {
                Console.Clear();
                Console.WriteLine("ukoncuji test a zobrazuji vysledky...");
                hr();
                evaluation(score, i);
                hr();
                Environment.Exit(0);
            }
            bool checkGuess()
            {
                for (int y = 0; y < options.Length; y++) // goes through all the questions
                    if (alphabet[y].ToString() == guess) // if the guess is in the first options.length part of alphabet, continue (or if it is nevm)
                        return true;

                return false; // otherwise repeat, the guess is not in the valid part of the alphabet
            }
            if (checkGuess() || guess.ToLower() == "nevim")
                break;

            // otherwise repeat, the guess is not valid
            color("neplatný vstup!", "red");
        }

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"otazka {i + 1}/{allQ.Length}: {line[0]}"); // prints the question
        if (guess.ToLower() != "nevim")
            Console.WriteLine(
                $"vase odpoved byla: {guess}) {options[alphabet.IndexOf(guess.ToUpper())]}"
            );

        if (guess == correctAnsLetter) // correct
        {
            color("spravne!", "green");
            score++;
        }
        else // wrong
        {
            if (guess.ToLower() == "nevim")
                color("tak nevis...", "yellow");
            else
                color("spatne :((", "red");

            color($"spravna odpoved byla: {correctAnsLetter}) {correctAns}", "yellow");

            // add the failed q to the temp array
            Array.Resize(ref qTemp, qTemp.Length + 1);
            qTemp[qTemp.Length - 1] = allQ[i];
        }

        hr();
    }

    // scores
    // if all the questions were right, end the test
    if (score == allQ.Length)
    {
        color($"skvele! vsechno mas spravne :)", "magenta");
        break;
    }

    // if there are still questions left, show the scores and prompt test repeat
    evaluation(score, allQ.Length);
    hr();
    color(
        "tento test bude pokracovat dokud nebudes mit vse spravne! (zadej cokoliv k pokracovani nebo \"ex\" k ukonceni programu)",
        "yellow"
    );
    if (userInput() == "ex") // exit
    {
        Console.WriteLine("ukoncuji test...");
        break;
    }

    Console.Clear();
}
