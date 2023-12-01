const float pi = 22f / 7f;
const string unit = "cm";
// a,b,c should be short lived

Console.Title = "shape calculator :)";
static void setColor(string s, string color) // change color
{
    switch (color)
    {
        case "highlight":
            Console.ForegroundColor = ConsoleColor.Green; // highlight color
            break;
        case "math":
            Console.ForegroundColor = ConsoleColor.Magenta; // math color
            break;
        case "wrong":
            Console.ForegroundColor = ConsoleColor.Red; // wrong color
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Gray; // default color
            break;
    }
    Console.Write(s);
    Console.ForegroundColor = ConsoleColor.Gray; // default color
}
static float getPosFloat(string s) // input prompt + positive float from user
{
    Console.Write("please input ");
    setColor(s, "math");
    Console.Write($" (in {unit}): ");
    for (; ; )
    {
        if (float.TryParse(Console.ReadLine(), out float x))
        {
            if (x > 0)
            {
                return x;
            }
        }
        setColor("please enter a number (> 0): ", "wrong");
    }
}
static void printResult(string dimension, float value) // print result
{
    string s = "";
    switch (dimension)
    {
        case "perimeter":
            break;
        case "area":
            s = "²";
            break;
        case "volume":
            s = "³";
            break;
    }
    setColor($"{dimension} = {MathF.Round(value, 2)}{unit}{s}", "math");
    Console.WriteLine();
}

static void circle()
{
    float r = getPosFloat("circle radius");
    printResult("perimeter", 2 * pi * r);
    printResult("area", pi * r * r);
}
static void triangle()
{
    float a = getPosFloat("triangle side a");
    float b = getPosFloat("triangle side b");
    float c = getPosFloat("triangle side c");
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        float s = (a + b + c) / 2;
        printResult("perimeter", a + b + c);
        printResult("area", MathF.Sqrt(s * (s - a) * (s - b) * (s - c)));
    }
    else
    {
        setColor("the triangle inequality (the sum of any two sides of a triangle must be greater than or equal to the third side) does not hold!", "wrong");
        Console.WriteLine();
    }
}
static void square()
{
    float a = getPosFloat("square side a");
    printResult("perimeter", 4 * a);
    printResult("area", a * a);
}
static void rectangle()
{
    float a = getPosFloat("rectangle side a");
    float b = getPosFloat("rectangle side b");
    printResult("perimeter", 2 * a * b);
    printResult("area", a * b);
}
static void pentagon()
{
    float a = getPosFloat("pentagon side a");
    printResult("perimeter", 5 * a);
    printResult("area", MathF.Sqrt(5 * (5 + 2 * MathF.Sqrt(5))) * a * a / 4);
}
static void hexagon()
{
    float a = getPosFloat("hexagon side a");
    printResult("perimeter", 6 * a);
    printResult("area", 3 * MathF.Sqrt(3) / 2 * a * a);
}
static void cube()
{
    float a = getPosFloat("cube side a");
    printResult("perimeter", 12 * a);
    printResult("area", 6 * a * a);
    printResult("volume", a * a * a);
}
static void rBox()
{
    float a = getPosFloat("rectangular box side a");
    float b = getPosFloat("rectangular box side b");
    float c = getPosFloat("rectangular box side c");
    printResult("perimeter", 4 * a + 4 * b + 4 * c);
    printResult("area", 2 * (a * b + a * c + b * c));
    printResult("volume", a * b * c);
}
static void cylinder()
{
    float r = getPosFloat("cylinder radius r");
    float h = getPosFloat("cylinder height h");
    printResult("area", 2 * (pi * r * r) + h * (2 * pi * r));
    printResult("volume", pi * r * r * h);
}
static void sphere()
{
    float r = getPosFloat("sphere radius r");
    printResult("area", 4 * pi * r * r);
    printResult("volume", pi * r * r * r * (4 / 3));
}
static void cone()
{
    float r = getPosFloat("cone radius r");
    float h = getPosFloat("cone height h");
    printResult("area", pi * r * (r + MathF.Sqrt(h * h + r * r)));
    printResult("volume", pi * r * r * (h / 3));
}

static void printShapeSelection() // prints the selection of available shapes
{
    Console.Write("choose a shape or e");
    setColor("[x]", "highlight");
    Console.Write("it:");
    Console.WriteLine();
    string[] shapes = { "circle", "triangle", "square", "rectangle", "pentagon", "hexagon", "cube", "rectangular box", "cylinder", "sphere", "cone" };
    foreach (string s in shapes)
    {
        if (s == "cube" || s == "square" || s == "cone" || s == "cylinder") // 2nd letter
        {
            Console.Write(s[0]);
            setColor($"[{s[1]}]", "highlight");
            Console.Write(s.Remove(0, 2));
        }
        else if (s == "rectangular box")  // box letter
        {
            Console.Write("rectangular ");
            setColor("[b]", "highlight");
            Console.Write("ox");
        }
        else // (default) 1st letter
        {
            setColor($"[{s[0]}]", "highlight");
            Console.Write(s.Remove(0, 1));
        }

        if (Array.IndexOf(shapes, s) < shapes.Length - 1) // write ", " after every item, but not at the end
        {
            Console.Write(", ");
        }
    }
    Console.Write(": ");
}
static void shapeSwitch(ConsoleKey k) // main switch
{
    if (k != ConsoleKey.X) // since readkey doesnt make a new line, but only unless exiting (for some reason only displays in ET but not IT)
    {
        Console.WriteLine();
    }
    static void printChoice(string s)
    {
        Console.WriteLine($"you chose {s}");
    }
    switch (k)
    {
        // circle
        case ConsoleKey.C:
            printChoice("circle");
            circle();
            break;
        // triangle
        case ConsoleKey.T:
            printChoice("triangle");
            triangle();
            break;
        // square
        case ConsoleKey.Q:
            printChoice("square");
            square();
            break;
        // rectangle
        case ConsoleKey.R:
            printChoice("rectangle");
            rectangle();
            break;
        // pentagon
        case ConsoleKey.P:
            printChoice("pentagon");
            pentagon();
            break;
        // hexagon
        case ConsoleKey.H:
            printChoice("hexagon");
            hexagon();
            break;
        // cube
        case ConsoleKey.U:
            printChoice("cube");
            cube();
            break;
        // rectangular box
        case ConsoleKey.B:
            printChoice("rectangular box");
            rBox();
            break;
        // cylinder
        case ConsoleKey.Y:
            printChoice("cylinder");
            cylinder();
            break;
        // sphere
        case ConsoleKey.S:
            printChoice("sphere");
            sphere();
            break;
        // cone
        case ConsoleKey.O:
            printChoice("cone");
            cone();
            break;
        // exit
        case ConsoleKey.X:
            Environment.Exit(0);
            break;
        default:
            setColor("invalid input!", "wrong");
            Console.WriteLine();
            break;
    }
}

// main
for (; ; )
{
    setColor("", ""); // just to make sure... or if previous run was cancelled with a color (< sets color to default)
    printShapeSelection();
    shapeSwitch(Console.ReadKey().Key);
}