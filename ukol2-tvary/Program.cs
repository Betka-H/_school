const float pi = 22f / 7f;
float a, b, c, r, h;
string unit = "cm";

// visage
Console.Title = "shape calculator :)";
static void colNormal() // normal color
{
    Console.ForegroundColor = ConsoleColor.Gray;
}
static void colHighlight() // highlight color
{
    Console.ForegroundColor = ConsoleColor.Green;
}
static void colMath() // for asking and printing math
{
    Console.ForegroundColor = ConsoleColor.Magenta;
}
static void colWrong() // wrong color
{
    Console.ForegroundColor = ConsoleColor.Red;
}

// user input
void numberInputPrompt(string s) // input prompt
{
    Console.Write("please input ");
    colMath();
    Console.Write(s);
    colNormal();
    Console.Write($" (in {unit}): ");
}
float getPosFloat() // positive float from user
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
        Console.Write("please enter a number (> 0): ");
        colNormal();
    }
}

// shape calculations
void printResult(string dimension, float value)
{
    colMath();
    Console.WriteLine($"{dimension} = {MathF.Round(value, 2)}{unit}");
    colNormal();
}

void circle()
{
    numberInputPrompt("circle radius");
    r = getPosFloat();
    printResult("perimeter", 2 * pi * r);
    printResult("area", pi * r * r);
}
void triangle()
{
    numberInputPrompt("triangle side a");
    a = getPosFloat();
    numberInputPrompt("triangle side b");
    b = getPosFloat();
    numberInputPrompt("triangle side c");
    c = getPosFloat();
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        float s = (a + b + c) / 2;
        printResult("perimeter", a + b + c);
        printResult("area", MathF.Sqrt(s * (s - a) * (s - b) * (s - c)));
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
    numberInputPrompt("square side a");
    a = getPosFloat();
    printResult("perimeter", 4 * a);
    printResult("area", a * a);
}
void rectangle()
{
    numberInputPrompt("rectangle side a");
    a = getPosFloat();
    numberInputPrompt("rectangle side b");
    b = getPosFloat();
    printResult("perimeter", 2 * a * b);
    printResult("area", a * b);
}
void pentagon()
{
    numberInputPrompt("pentagon side a");
    a = getPosFloat();
    printResult("perimeter", 5 * a);
    printResult("area", MathF.Sqrt(5 * (5 + 2 * MathF.Sqrt(5))) * a * a / 4);
}
void hexagon()
{
    numberInputPrompt("hexagon side a");
    a = getPosFloat();
    printResult("perimeter", 6 * a);
    printResult("area", 3 * MathF.Sqrt(3) / 2 * a * a);
}
void cube()
{
    numberInputPrompt("cube side a");
    a = getPosFloat();
    printResult("perimeter", 12 * a);
    printResult("area", 6 * a * a);
    printResult("volume", a * a * a);
}
void rBox()
{
    numberInputPrompt("rectangular box side a");
    a = getPosFloat();
    numberInputPrompt("rectangular box side b");
    b = getPosFloat();
    numberInputPrompt("rectangular box side c");
    c = getPosFloat();
    printResult("perimeter", 4 * a + 4 * b + 4 * c);
    printResult("area", 2 * (a * b + a * c + b * c));
    printResult("volume", a * b * c);
}
void cylinder()
{
    numberInputPrompt("cylinder radius r");
    r = getPosFloat();
    numberInputPrompt("cylinder height h");
    h = getPosFloat();
    printResult("area", 2 * (pi * r * r) + h * (2 * pi * r));
    printResult("volume", pi * r * r * h);
}
void sphere()
{
    numberInputPrompt("sphere radius r");
    r = getPosFloat();
    printResult("area", 4 * pi * r * r);
    printResult("volume", pi * r * r * r * (4 / 3));
}
void cone()
{
    numberInputPrompt("cone radius r");
    r = getPosFloat();
    numberInputPrompt("cone height h");
    h = getPosFloat();
    printResult("area", pi * r * (r + MathF.Sqrt(h * h + r * r)));
    printResult("volume", pi * r * r * (h / 3));
}

// main
void printShapeSelection() // prints the selection of available shapes
{
    Console.Write("choose a shape or e");
    colHighlight();
    Console.Write("[x]");
    colNormal();
    Console.WriteLine("it:");

    string[] shapes = { "circle", "triangle", "square", "rectangle", "pentagon", "hexagon", "cube", "rectangular box", "cylinder", "sphere", "cone" };
    foreach (string s in shapes)
    {
        if (s == "cube" || s == "square" || s == "cone" || s == "cylinder") // [highlight] the 2nd letter
        {
            Console.Write(s[0]);
            colHighlight();
            Console.Write($"[{s[1]}]");
            colNormal();
            Console.Write(s.Remove(0, 2));
        }
        else if (s == "rectangular box")  // [highlight] the box letter
        {
            Console.Write("rectangular ");
            colHighlight();
            Console.Write("[b]");
            colNormal();
            Console.Write("ox");
        }
        else // (default) [highlight] the 1st letter
        {
            colHighlight();
            Console.Write($"[{s[0]}]");
            colNormal();
            Console.Write(s.Remove(0, 1));
        }

        if (Array.IndexOf(shapes, s) < shapes.Length - 1) // write "," after every item, but not at the end
        {
            Console.Write(", ");
        }
    }
    Console.Write(": ");
}
void shapeSwitch(ConsoleKey k) // main switch
{
    if (k != ConsoleKey.X) // since readkey doesnt make a new line, but only unless exiting (for some reason only displays in ET but not IT)
    {
        Console.WriteLine();
    }
    switch (k)
    {
        // circle
        case ConsoleKey.C:
            circle();
            break;
        // triangle
        case ConsoleKey.T:
            triangle();
            break;
        // square
        case ConsoleKey.Q:
            square();
            break;
        // rectangle
        case ConsoleKey.R:
            rectangle();
            break;
        // pentagon
        case ConsoleKey.P:
            pentagon();
            break;
        // hexagon
        case ConsoleKey.H:
            hexagon();
            break;
        // cube
        case ConsoleKey.U:
            cube();
            break;
        // rectangular box
        case ConsoleKey.B:
            rBox();
            break;
        // cylinder
        case ConsoleKey.Y:
            cylinder();
            break;
        // sphere
        case ConsoleKey.S:
            sphere();
            break;
        // cone
        case ConsoleKey.O:
            cone();
            break;
        // exit
        case ConsoleKey.X:
            Environment.Exit(0);
            break;
        default:
            colWrong();
            Console.WriteLine("invalid input!");
            colNormal();
            break;
    }
}

for (; ; )
{
    colNormal(); // just to make sure... or if previous run was cancelled with a color
    printShapeSelection();
    shapeSwitch(Console.ReadKey().Key);
}