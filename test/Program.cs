bool suces;
double a, b, c, x, vysledek;
string textuzivatel;


double ziskatCislo()
{
    do
    {
        textuzivatel = Console.ReadLine();
        suces = double.TryParse(textuzivatel, out vysledek);
        if (!suces)
        {
            Console.WriteLine("spatne. zadej cislo: ");
        }
    } while (!suces);
    return vysledek;
}


Console.WriteLine("Tvá osobní kalkulačka :)))");

Console.WriteLine("Napiš koeficient a");
do
{
    a = ziskatCislo();
    if (a == 0)
    {
        Console.WriteLine("a nemuze byt 0. zadej jine cislo: ");
    }
} while (a == 0);
Console.WriteLine("Napiš koeficient b");
b = ziskatCislo();
Console.WriteLine("Napiš koeficient c");
c = ziskatCislo();

Console.WriteLine($"a={a}, b={b}, c={c}");

do
{
    Console.WriteLine("napiste parametr x. Pokud nechcete psat parametr x, napiste stop");
    textuzivatel = Console.ReadLine(); // precte, co napise uzivatel
    if (textuzivatel == "stop")
    {
        break; // kdyz uzivatel napise "stop", smycka se prestane opakovat
    }
    suces = double.TryParse(textuzivatel, out x); // teprve kdyz nenapise "stop", tak to vyzkousi jestli uzivatel napsal cislo
    if (suces)
    {
        Console.WriteLine(a * Math.Pow(x, 2) + b * x + c); // kdyz to je cislo, vypise vysledek rovnice a opakuje smycku
    }
    Console.Write("neni cislo. napis cislo: "); // kdyz je to neco jineho nez cislo, opakuje smycku
} while (true);

Console.WriteLine("konec");