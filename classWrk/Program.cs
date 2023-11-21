float a, b, c, r, pi = 22 / 7;

void colWrong()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
}
void colNormal()
{
    Console.ForegroundColor = ConsoleColor.Gray;
}

float getPosFloat()
{
    for (; ; )
    {
        if (float.TryParse(Console.ReadLine(), out float x))
        {
            if (x > 0)
            {
                return x;
            }
        }
        colWrong();
        Console.Write("prosim zadej cislo vetsi nez 0: ");
        colNormal();
    }
}

void kruh()
{
    Console.Write("prosim zadej delku polomeru r (v cm): ");
    r = getPosFloat();
    Console.WriteLine($"obvod kruhu je: {MathF.Round(2 * pi * r, 2)}cm\nobsah kruhu je: {MathF.Round(pi * MathF.Pow(r, 2), 2)}cm");
}
void trojuhelnik()
{
    Console.Write("prosim zadej delku strany a (v cm): ");
    a = getPosFloat();
    Console.Write("prosim zadej delku strany b (v cm): ");
    b = getPosFloat();
    Console.Write("prosim zadej delku strany c (v cm): ");
    c = getPosFloat();
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        float s = (a + b + c) / 2;
        Console.WriteLine($"obvod trojuhelniku je: {MathF.Round(a + b + c, 2)}cm\nobsah trojuhelniku je: {MathF.Round(MathF.Sqrt(s * (s - a) * (s - b) * (s - c)), 2)}cm");
    }
    else
    {
        colWrong();
        Console.WriteLine("neplati trojuhelnikova nerovnost! (soucet delek kazdych dvou stran ma byt vetsi nez delka strany treti)");
        colNormal();
    }
}
void ctverec()
{
    Console.Write("prosim zadej delku strany a (v cm): ");
    a = getPosFloat();
    Console.WriteLine($"obvod ctverce je: {MathF.Round(4 * a, 2)}cm\nobsah ctverce je: {MathF.Round(a * a, 2)}cm");
}
void obdelnik()
{
    Console.Write("prosim zadej delku strany a (v cm): ");
    a = getPosFloat();
    Console.Write("prosim zadej delku strany b (v cm): ");
    b = getPosFloat();
    Console.WriteLine($"obvod obdelniku je: {MathF.Round(2 * a + 2 * b, 2)}cm\nobsah obdelniku je: {MathF.Round(a * b, 2)}cm");
}

for (; ; )
{
    Console.Write("vyber utvar, ktery chces vypocitat: [k]ruh, [t]rojuhelnik, [c]tverec, [o]bdelnik nebo [s]top k ukonceni programu: ");
    switch (Console.ReadLine().ToLower())
    {
        case "k":
            kruh();
            break;
        case "t":
            trojuhelnik();
            break;
        case "c":
            ctverec();
            break;
        case "o":
            obdelnik();
            break;
        case "s":
            Environment.Exit(0);
            break;
        default:
            colWrong();
            Console.WriteLine("neplatny vyber! ");
            colNormal();
            break;
    }
}