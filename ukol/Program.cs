#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8321 // Local function is declared but never used

static void quadraticEquation()
{
    // variables
    float a,
        b,
        c,
        D,
        userNumber;
    string userString;

    // functions
    void detectAndTerminate()
    {
        if (userString == "e")
        {
            Console.WriteLine("terminating program...");
            Environment.Exit(0);
        }
    }
    float getNumber()
    {
        for (; ; )
        {
            userString = Console.ReadLine().ToLower();
            detectAndTerminate();
            if (float.TryParse(userString, out userNumber))
            {
                return userNumber;
            }
            Console.Write("that's not a number. please input a number: ");
        }
    }
    float x1()
    {
        return MathF.Round((-b + MathF.Sqrt(D)) / (2 * a), 2);
    }
    float x2()
    {
        return MathF.Round((-b - MathF.Sqrt(D)) / (2 * a), 2);
    }

    // main
    for (; ; ) // more readable than while(true)??
    {
        // number input
        Console.WriteLine(
            "this program will solve ax^2 + bx + c = 0. input \"e\" at any time to exit"
        );
        Console.Write("enter number a: ");
        a = getNumber();
        Console.Write("enter number b: ");
        b = getNumber();
        Console.Write("enter number c: ");
        c = getNumber();
        Console.WriteLine($"a = {a}, b = {b}, c = {c}");

        // results
        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine(
                $"there is an infinite amount of x values for {a} * x^2 + {b} * x + {c} = 0"
            );
        }
        else
        {
            while (a == 0)
            {
                Console.Write("\"a\" cannot equal zero! please input a different number: ");
                a = getNumber();
            }

            D = MathF.Pow(b, 2) - 4 * a * c;
            switch (D)
            {
                case < 0:
                    Console.WriteLine($"there is no answer for x in {a} * x^2 + {b} * x + {c} = 0");
                    break;
                case 0:
                    Console.WriteLine(
                        $"there is one answer for x in {a} * x^2 + {b} * x + {c} = 0: "
                    );
                    Console.WriteLine($"x = {x1()}");
                    break;
                case > 0:
                    Console.WriteLine(
                        $"there are two answers for x in {a} * x^2 + {b} * x + {c} = 0: "
                    );
                    Console.WriteLine($"x1 = {x1()}, x2 = {x2()}");
                    break;
            }

            // x evaluation
            for (; ; )
            {
                Console.Write(
                    "enter parameter x for evaluation (or enter \"s\" to stop evaluating): "
                );
                userString = Console.ReadLine().ToLower();
                detectAndTerminate(); // detects "e" keyword
                if (userString == "s")
                {
                    break;
                }
                if (float.TryParse(userString, out userNumber))
                {
                    Console.WriteLine(
                        $"the equation is {a} * {userNumber}^2 + {b} * {userNumber} + {c} = {MathF.Round(a * MathF.Pow(userNumber, 2) + b * userNumber + c, 2)}"
                    );
                }
                else
                {
                    Console.Write("invalid input. please ");
                }
            }
        }

        // end
        for (; ; )
        {
            Console.Write("do you want to repeat the program? \"r\" to repeat, \"e\" to exit: ");
            userString = Console.ReadLine().ToLower();
            detectAndTerminate();
            if (userString == "r")
            {
                break;
            }
            Console.Write("invalid input; ");
        }
    }
}
static void shapesCalculator()
{
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
            float s = (a + b + c) / 2f;
            printResult("perimeter", a + b + c);
            printResult("area", MathF.Sqrt(s * (s - a) * (s - b) * (s - c)));
        }
        else
        {
            setColor(
                "the triangle inequality (the sum of any two sides of a triangle must be greater than or equal to the third side) does not hold!",
                "wrong"
            );
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
        printResult("perimeter", 2 * a + 2 * b);
        printResult("area", a * b);
    }
    static void pentagon()
    {
        float a = getPosFloat("pentagon side a");
        printResult("perimeter", 5 * a);
        printResult("area", MathF.Sqrt(5 * (5 + 2 * MathF.Sqrt(5))) * a * a / 4f);
    }
    static void hexagon()
    {
        float a = getPosFloat("hexagon side a");
        printResult("perimeter", 6 * a);
        printResult("area", 3 * MathF.Sqrt(3) / 2f * a * a);
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
        printResult("volume", pi * r * r * r * (4f / 3f));
    }
    static void cone()
    {
        float r = getPosFloat("cone radius r");
        float h = getPosFloat("cone height h");
        printResult("area", pi * r * (r + MathF.Sqrt(h * h + r * r)));
        printResult("volume", pi * r * r * (h / 3f));
    }

    static void printShapeSelection() // prints the selection of available shapes
    {
        Console.Write("choose a shape or e");
        setColor("[x]", "highlight");
        Console.Write("it:");
        Console.WriteLine();
        string[] shapes =
        {
            "circle",
            "triangle",
            "square",
            "rectangle",
            "pentagon",
            "hexagon",
            "cube",
            "rectangular box",
            "cylinder",
            "sphere",
            "cone"
        };
        foreach (string s in shapes)
        {
            if (s == "cube" || s == "square" || s == "cone" || s == "cylinder") // 2nd letter
            {
                Console.Write(s[0]);
                setColor($"[{s[1]}]", "highlight");
                Console.Write(s.Remove(0, 2));
            }
            else if (s == "rectangular box") // box letter
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
        setColor("", ""); // (< sets color to default) just to make sure... or if previous run was cancelled with a color
        printShapeSelection();
        shapeSwitch(Console.ReadKey().Key);
    }
}
static void autoskola(int run)
{
    /*
        zadani: (veci oznacene XXX tu nejsou, prisly mi vic komplikovane)
        1) Program načte přiložený soubor se všemi otázkami a odpověďmi.
        (!) Pracujte se souborem "questions.data" (tento název neměňte). Nepoužívejte absolutní cestu (např. ne: "C:\Users..."), správně je pouze "questions.data".
        (!) program musí umět zamíchat pořadí otázek (aby nebyly pokaždé ve stejném pořadí).
        
        bonus 1) Možnost zadání počtu otázek, na které se má program uživatele zeptat.
        (!) Program by neměl spadnout při zadání neočekávaného vstupu.
        
        2) Postupně se ptá uživatele na otázky ze souboru
        
        XXX bonus 1.2) Zamíchání pořadí možností u otázky.
        
        3) dává uživateli na výběr z možností (A, B, C)
        
        4) kontroluje správnost odpovědi (vypíše, jestli uživatel odpověděl správně, v opačném případně vypíše správnou odpověď)
        
        5) Po ukončení kvízu program vypíše uživatelovu úspěšnost v % (počet správných odpovědí / počet všech odpovědí).
        
        XXX bonus 2) Po zodpovězení zvoleného počtu otázek se program znova zeptá na otázky, na které uživatel odpověděl špatně. (Takto se může ptát dokud uživatel nezodpoví vše správně)
        
        (!) Program běží ve smyčce, dokud si uživatel nepřeje skončit nebo dokud nedojdou otázky.
        */

    // lite
    if (run == 0)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // umoznuje ceske znaky v konzoli
        Console.Title = "autoskolni test"; // zmeni nazev okna :) jenom mala esteticka zmena
        Console.Clear(); // "vycisti" konzoli, smaze radky co tam byly predtim. podle me to vypada hezcejs, ale vubec to neni nutnost
        Console.WriteLine(
            "vitej v testu autoskoly. zadej \"q\" kdykoliv k ukonceni a vyhodnoceni testu"
        );

        // 1) Program načte přiložený soubor se všemi otázkami a odpověďmi.
        string[] vsechnyOtazky = File.ReadAllLines("questions.data"); // kazda hodnota v arrayi je jedna radka ze souboru (tedy "otazka|spravna odpoved|odpoved 1|odpoved 2|odpoved 3")

        // (!) program musí umět zamíchat pořadí otázek (aby nebyly pokaždé ve stejném pořadí).
        // neni to nutne, ale michaci algoritmus je dobre dat do funkce (muze se pak kdyztak vyuzit na bonus 1) Zamíchání pořadí možností u otázky.)
        static string[] zamichat(string[] a)
        {
            // slovo "static" znamena, ze funkce nemuze cist zadne promenne ktere nema v sobe (v tomto pripade treba promennou allQuestions)
            // ted to nic moc nemeni, ale je to uzitecne v jinych pripadech a take proste jako ukazatel toho, ze "aha, tady ta funkce nepotrebuje nic zvenci, jestli to hazi chybu, mam hledat jenom v ni"

            // vytvori novy prazdny array
            string[] b = { };
            while (b.Length < a.Length) // dokud neni novy array stejne dlouhy jako ten stary, opakuje tento kod:
            {
                int r = new Random().Next(a.Length); // vygeneruje nahodne cislo mezi 0 a poctem hodnot ve starem arrayi - v tomto pripade stary array bude obsahovat radky ze souboru (otazka|spravna odpoved|...) popripade jednotlive odpovedi
                if (!b.Contains(a[r])) // kdyz v novem array NEnajde nahodnou hodnota ze stareho arraye, zapise ji tam
                {
                    Array.Resize(ref b, b.Length + 1); // zvetsi velikost noveho arraye o 1 (jinak by tam neslo nic zapsat)
                    b[b.Length - 1] = a[r]; // do vytvoreneho mista zapise nahodnou hodnotu
                }
            }
            return b; // kdyz se funkce zavola, vrati zamichany array
        }
        vsechnyOtazky = zamichat(vsechnyOtazky);

        // bonus 1) Možnost zadání počtu otázek, na které se má program uživatele zeptat.
        Console.Write(
            $"ze souboru je nacteno {vsechnyOtazky.Length} otazek. jestli chces zmenit pocet otazek, zadej \"z\": "
        );

        // znak "$" pred stringem znamena, ze do {} se v nem da jednoduse vypsat jakakoliv promenna/matematicky vypocet
        // znak \ pred " (v zadej \"z\") znamena, ze program znak " normalne vytiskne, jinak by ho spatne pochopil jako konec stringu, co chce tisknout a hodilo by to chybu
        // vsechnyOtazky.Length je cele cislo odpovidajici poctu radku v prectenem souboru

        // slo by udelat: string zmenaPoctu = Console.ReadLine(); ale! precist vstup od uzivatele bude potreba jeste pri zadavani samotneho cisla a pri zadavani odpovedi, takze je lepsi udelat funkci:
        static string vstupOdUzivatele()
        {
            string coNapiseUzivatel = Console.ReadLine().Trim().ToUpper();
            // Trim() udela to, ze kdyby ve stringu od uzivatele byl na zacatku nebo na konci whitespace (= mezernik, tab), tak to z tama odenda (trim)
            // ToLower() string od uzivatele prevede do malych pismen (kdyby uzivatel napsal "Z" misto "z")
            return coNapiseUzivatel; // kdyz se funkce zavola, vrati upraveny string od uzivatele
            // jde take udelat jednoduse return Console.ReadLine().Trim().ToLower();, coz eliminuje celou promennou coNapiseUzivatel (cim mene promennych, tim lepe). ale neni to nutnost
        }

        // zmena poctu otazek bude umoznena jen kdyz uzivatel zada "z", jinak program pokracuje se stejnym poctem jako predtim (tedy vsechny otazky co jsou v souboru)
        if (vstupOdUzivatele() == "Z")
        {
            Console.Write("zadej kolik chces otazek: ");
            // ted musi precist vstup od uzivatele, ale vezme ho, jenom pokud je to cislo nad 0 (zaporny nebo nulovy pocet otazek samozrejme nejde). program bude cislo cist jenom tady, ale stejne je dobre si to zase dat do funkce

            static int pozitivniCisloOdUzivatele()
            {
                // prazdna podminka u for loopu znamena, ze bezi nekonecne, protoze neni specifikovany zadny pripad, kdy ma skoncit (treba i<x nebo podobne). v tomto pripade tedy opakuje ziskavani cisla, dokud se nedostane k "return x;"
                for (; ; )
                {
                    // (!) Program by neměl spadnout při zadání neočekávaného vstupu.
                    // TryParse je bool (hodnota true/false), ktery zavisi na tom, jestli je to co do nej dam cislo, nebo ne. takze kdyz uzivatel zada neco jineho nez cislo vetsi nez 0 (pridana podminka x > 0, && znamena, ze musi platit zaroven s tou predchozi), tento blok kodu neprobehne a funkce nevrati hodnotu, a protoze je v nekonecnem for loopu, bude se opakovat
                    if (int.TryParse(vstupOdUzivatele(), out int x) && x > 0)
                    {
                        return x;
                    }
                    Console.Write("neplatny vstup! zadej cislo: "); // tato zprava se zobrazi jenom kdyz predchozi blok neda return, a smycka se bude opakovat
                }
            }
            int zmenaPoctu = pozitivniCisloOdUzivatele();
            // zmeni velikost arraye jenom kdyz je pozadovana hodnota mensi nez jeho soucasna delka, jinak se nic nestane a array zustane stejne velky (tedy vsechny otazky co nacetl ze souboru tam zustaly)
            if (zmenaPoctu < vsechnyOtazky.Length)
            {
                Array.Resize(ref vsechnyOtazky, zmenaPoctu); // zmeni velikost arraye na pozadovanou hodnotu
            }
        }

        // na tomhle miste se deklaruje protoze nesmi byt v hlavni smycce, kde by skore po kazde otazce zase slo na 0. proc je to float (desetinne cislo) vysvetlim az se bude pouzivat pozdeji
        float score = 0;

        // toto je na tom uplne stejne
        float celkemZodpovezeno = 0;

        Console.Clear(); // "vycisti" konzoli, smaze radky co tam byly predtim. podle me to vypada hezcejs, ale vubec to neni nutnost

        // 2) Postupně se ptá uživatele na otázky ze souboru
        for (int i = 0; i < vsechnyOtazky.Length; i++)
        {
            // rozdeli radku v poradi [i] z arraye s otazkama ze souboru na casti podle rozdelovace |
            string[] otazkaAOdpovedi = vsechnyOtazky[i].Split("|");
            // otazkaAOdpovedi tedy obsahuje hodnoty: otazka, pismeno spravne odpovedi, odpoved a, odpoved b a popripade odpoved c (nektere otazky maji jen 2 odpovedi!!)

            // 3) dává uživateli na výběr z možností (A, B, C)
            Console.WriteLine($"otazka {i + 1}/{vsechnyOtazky.Length}: {otazkaAOdpovedi[0]}"); // vypise otazku - vzdycky je na nultem indexu ve stringu[] otazkyAOdpovedi

            string povoleneOdpovedi = "Q"; // pozdeji se musi poznat, jestli uzivatel zadava spravnou vec. protoze muzou byt 3 ale i 2 odpovedi, nemuze to vzdycky kontrolovat pro a,b i c, protoze jinak by to u 2 odpovedovych otazek bralo i c, coz nema. q je tam vzdycky, to je pro quit

            // nastavi (do stringu povoleneOdpovedi) a vypise mozne odpovedi
            for (int y = 2; y < otazkaAOdpovedi.Length; y++)
            {
                // bezi od 2. do posledniho mista arraye s otazkou a odpovedma, tzn. preskoci 0. a 1. misto a bere v potaz jenom to za tim, coz jsou vsechny moznosti odpovedi

                // switch vypise a, b nebo c podle toho, kolikatou odpoved prave vypisuje
                switch (y)
                {
                    case 2:
                        povoleneOdpovedi += "A";
                        // prida pismeno do seznamu povolencyh odpovedi oz uzivatele
                        Console.Write("A");
                        // (!) jen console.write, console.writeline by udelal novy radek a samotna otazka by uz byla napsana pod tim, coz se pravdepodobne stat nema
                        break;
                    case 3:
                        povoleneOdpovedi += "B";
                        Console.Write("B");
                        break;
                    case 4:
                        povoleneOdpovedi += "C";
                        Console.Write("C");
                        break;
                }
                // tady uz k pismenu prida jen ") odpoved" pro finalni formu "pismeno odpovedi) odpoved
                Console.WriteLine($") " + otazkaAOdpovedi[y]); // vypise co je prave na indexu y, tedy moznost odpovedi
            }

            // vypise uzivateli prompt aby zadal svou odpoved. asi nemusi, ale vypise mu i ocekavane odpovedi
            Console.Write("vyber odpoved (");
            for (int y = 1; y < povoleneOdpovedi.Length; y++)
            {
                Console.Write(povoleneOdpovedi[y]);
                if (y < povoleneOdpovedi.Length - 1)
                {
                    Console.Write("/");
                }
            }
            Console.Write("): ");

            // 4) kontroluje správnost odpovědi (vypíše, jestli uživatel odpověděl správně, v opačném případně vypíše správnou odpověď)
            string pismenoSpravneOdpovedi = otazkaAOdpovedi[1]; // precte z 2. mista pismeno spravne odpovedi
            string odpoved;
            for (; ; )
            {
                odpoved = vstupOdUzivatele();
                // spravna odpoved je vzdycky zadana velkym pismenem, proto to .ToUpper(), aby i vstup od uzivatele byl preveden na velke pismeno a nemusel to tak psat vzdycky sam uzivatel. program si tedy ted poradi stejne s "a" i s "A" (a diky .Trim() v samotne funkci vstupOdUzivatele() tomu nevadi ani napriklad "     a   " nebo "       A" )
                if (!povoleneOdpovedi.Contains(odpoved) || string.IsNullOrEmpty(odpoved)) // kdyz uzivatel napise neco jineho nez a,b,(c) nebo q, znovu se to zepta na vstup nebo kdyz zada enter (z nejakeho me zahadneho duvodu to bralo enter i kdyz povoleneOdpovedi v sobe melo jenom QABC)
                {
                    Console.WriteLine("neplatny vstup!");
                }
                else // kdyz neplati podminka predtim, tedy vstup je v poradku (a/b/(c), q)
                    break;
            }
            if (odpoved == "Q")
                break; // kdyz uzivatel zada q k ukonceni testu, program vyskoci ze smycky a jde na vyhodnoceni
            Console.Clear(); // vycisti konzoli pred dalsi otazkou. je to na tomhle miste, aby i pred dalsi otazkou byl videt feedback na tu co uzivatel prave odpovedel
            if (odpoved == pismenoSpravneOdpovedi) // kdyz se to, co uzivatel napise rovna spravne odpovedi
            {
                score++; // zvysi skore o 1
                Console.WriteLine("spravna odpoved!");
            }
            else // jedina zbyvajici moznost je spatna odpoved, neni tedy treba znovu upresnovat podminky
            {
                Console.WriteLine("spatna odpoved!");
                Console.Write($"spravna odpoved byla: {pismenoSpravneOdpovedi}) "); // vypise pismeno)
                switch (pismenoSpravneOdpovedi) // vypise odpoved podle toho jake je pismeno spravne odpovedi
                {
                    case "A":
                        Console.WriteLine(otazkaAOdpovedi[2]);
                        break;
                    case "B":
                        Console.WriteLine(otazkaAOdpovedi[3]);
                        break;
                    case "C":
                        Console.WriteLine(otazkaAOdpovedi[4]);
                        break;
                }
            }

            // kviz jde ukoncit i pred zodpovezenim vsech otazek! potrebujeme tedy v prubehu testu zaznamenavat nejen skore (pocet spravnych odpovedi), ale i celkovy pocet zodpovezenych otazek. je az tady dole, protoze ho chceme zvetsit jenom pote, co uzivatel realne odpovi na otazku (kdyz misto odpovedi napise q, tak ta otazka se nebude pocitat do celkoveho poctu)
            celkemZodpovezeno++;
            Console.WriteLine(); // prida prazdny radek pro lepsi citelnost
        }

        // 5) Po ukončení kvízu program vypíše uživatelovu úspěšnost v % (počet správných odpovědí / počet všech odpovědí).
        Console.Clear();
        if (celkemZodpovezeno != 0)
            Console.WriteLine(
                $"skore: {MathF.Round(score / celkemZodpovezeno * 100)}% ({score}/{celkemZodpovezeno})"
            );
        else
            Console.WriteLine("zadna otazka nebyla zodpovezena...");
    }
    // real
    if (run == 1)
    {
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
        // #pragma warning disable CS8602 // Dereference of a possibly null reference.

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
            /* string[] b = { };
            while (b.Length < a.Length)
            {
                int r = new Random().Next(a.Length);
                if (!b.Contains(a[r]))
                {
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = a[r];
                }
            }
            a = b; */
            for (int i = 0; i < a.Length; i++)
            {
                int r = new Random().Next(i);
                string temp = a[i];
                a[i] = a[r];
                a[r] = temp;
            }
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
        if (
            !int.TryParse(File.ReadAllLines("question_amount.txt")[0], out int QAmount)
            || QAmount > allQ.Length
            || QAmount < 0
        )
        {
            throw new Exception("file contents invalid");
        }
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
            int score = 0;

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
                color($"otazka {i + 1}/{allQ.Length}:", "cyan"); // prints the question number
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
    }
}
