bool suces;
double a, b, c, vysledek;
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
a = ziskatCislo();
Console.WriteLine("Napiš koeficient b");
b = ziskatCislo();
Console.WriteLine("Napiš koeficient c");
c = ziskatCislo();

Console.WriteLine($"a={a}, b={b}, c={c}");