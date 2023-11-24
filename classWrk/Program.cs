float a, b, c, r;
const float pi = 22 / 7;
string unit = "cm";
string[] shapes = { "circle", "triangle", "square", "rectangle", "pentagon", "hexagon", "cube", "rectangular box", "sphere" };
void colWrong() // wrong color
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void colNormal() // normal color
{
    Console.ForegroundColor = ConsoleColor.Gray;
}

float getPosFloat() // outputs a positive float, from user
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
        Console.Write("please enter a number (bigger than 0): ");
        colNormal();
    }
}
void printShapeSelection() // prints the selection of available shapes
{
    Console.Write("choose a shape: ");
    foreach (string s in shapes)
    {
        if (s == "cube")
        {
            Console.Write("c[u]be");
        }
        else if (s == "square")
        {
            Console.Write("s[q]uare");
        }
        else if (s == "rectangular box")
        {
            Console.Write("rectangular [b]ox");
        }
        else
        {
            Console.Write($"[{s[0]}]{s.Remove(0, 1)}");
        }
        if (Array.IndexOf(shapes, s) < shapes.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("; or e[x]it: ");
}
void numberInputPrompt(string s) // reusable user number input prompt
{
    Console.Write($"please input {s} (in {unit}): ");
}
void printPerimeterAndArea(string s, float per, float ar) // calculates perimeter and area
{
    Console.Write($"{s}: perimeter = {MathF.Round(per, 2)}, area = {MathF.Round(ar, 2)}");
}
void printVolume(float vol) // calculates volume
{
    Console.Write($", volume = {MathF.Round(vol, 2)}");
}
// real shapes
void circle()
{
    numberInputPrompt("radius");
    r = getPosFloat();
    printPerimeterAndArea("circle", 2 * pi * r, pi * MathF.Pow(r, 2));
}
void triangle()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    numberInputPrompt("side b");
    b = getPosFloat();
    numberInputPrompt("side c");
    c = getPosFloat();
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        float s = (a + b + c) / 2;
        printPerimeterAndArea("triangle", a + b + c, MathF.Sqrt(s * (s - a) * (s - b) * (s - c)));
    }
    else
    {
        colWrong();
        Console.WriteLine("the triangle inequality (the sum of any two sides of a triangle must be greater than or equal to the third side) does not hold!");
        colNormal();
    }
}
void square()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    printPerimeterAndArea("square", 4 * a, a * a);
}
void rectangle()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    numberInputPrompt("side b");
    b = getPosFloat();
    printPerimeterAndArea("square", 2 * a * b, a * b);
}
void pentagon()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    printPerimeterAndArea("square", 5 * a, MathF.Sqrt(5 * (5 + 2 * MathF.Sqrt(5))) * a * a / 4);
}
void hexagon()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    printPerimeterAndArea("square", 5 * a, 3 * MathF.Sqrt(3) / 2 * a * a);
}
void cube()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    printPerimeterAndArea("cube", 12 * a, 6 * a * a);
    printVolume(a * a * a);
}
void rBox()
{
    numberInputPrompt("side a");
    a = getPosFloat();
    numberInputPrompt("side b");
    b = getPosFloat();
    numberInputPrompt("side c");
    c = getPosFloat();
    printPerimeterAndArea("rectangular box", 4 * a * b * c, 2 * (a * b + a * c + b * c));
    printVolume(a * b * c);
}
void sphere()
{
    numberInputPrompt("radius r");
    r = getPosFloat();
    printPerimeterAndArea("sphere", 2 * pi * r, 4 * pi * r * r);
    printVolume(pi * r * r * r * (4 / 3));
}

colNormal();
for (; ; )
{
    for (; ; )
    {
        printShapeSelection();
        ConsoleKey userChar = Console.ReadKey().Key;
        Console.WriteLine();
        switch (userChar) // shape choices
        {
            case ConsoleKey.C:
                circle();
                break;
            case ConsoleKey.T:
                triangle();
                break;
            case ConsoleKey.Q:
                square();
                break;
            case ConsoleKey.R:
                rectangle();
                break;
            case ConsoleKey.P:
                pentagon();
                break;
            case ConsoleKey.H:
                hexagon();
                break;
            case ConsoleKey.U:
                cube();
                break;
            case ConsoleKey.B:
                rBox();
                break;
            case ConsoleKey.S:
                sphere();
                break;
            case ConsoleKey.X:
                Environment.Exit(0);
                break;
            default:
                colWrong();
                Console.Write("invalid input!");
                colNormal();
                break;
        }
        Console.WriteLine();
    }



    break;
}









void writeGet(string s) // prosim zadej delku {s} (v {unit}):
{
    Console.Write($"prosim zadej delku {s} (v {unit}): ");
}

void kruh()
{
    writeGet("polomeru r");
    r = getPosFloat();
    Console.WriteLine($"obvod kruhu je: {MathF.Round(2 * pi * r, 2)}{unit}\nobsah kruhu je: {MathF.Round(pi * MathF.Pow(r, 2), 2)}{unit}");
}
void trojuhelnik()
{
    writeGet("strany a");
    a = getPosFloat();
    writeGet("strany b");
    b = getPosFloat();
    writeGet("strany c");
    c = getPosFloat();
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        float s = (a + b + c) / 2;
        Console.WriteLine($"obvod trojuhelniku je: {MathF.Round(a + b + c, 2)}{unit}\nobsah trojuhelniku je: {MathF.Round(MathF.Sqrt(s * (s - a) * (s - b) * (s - c)), 2)}{unit}");
    }
    else
    {
        colWrong();
        Console.WriteLine("neplati trojuhelnikova nerovnost (soucet delek kazdych dvou stran ma byt vetsi nez delka strany treti)!");
        colNormal();
    }
}
void ctverec()
{
    writeGet("strany a");
    a = getPosFloat();
    Console.WriteLine($"obvod ctverce je: {MathF.Round(4 * a, 2)}{unit}\nobsah ctverce je: {MathF.Round(a * a, 2)}{unit}");
}
void obdelnik()
{
    writeGet("strany a");
    a = getPosFloat();
    writeGet("strany b");
    b = getPosFloat();
    Console.WriteLine($"obvod obdelniku je: {MathF.Round(2 * a + 2 * b, 2)}{unit}\nobsah obdelniku je: {MathF.Round(a * b, 2)}{unit}");
}

for (; ; )
{
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
            Console.WriteLine("neplatny vyber!");
            colNormal();
            break;
    }
}
// do utery 5.12. vecer