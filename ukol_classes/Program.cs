/*
Třídy Produkt, ElektronickýProdukt a Kniha podle specifikace. Každou do svého souboru (Product.cs, ...).
Cílem úkolu je hlavně napsání kódu tříd, ne nutně celý fungující program.

V souboru Program.cs napište kód pro vytvoření pole objektů typu **Produkt**, které obsahuje instance tříd Produkt, ElektronickýProdukt a Kniha. Projděte pole a zavolejte metodu *ShowInfo()* pro každý objekt.

Produkt
* string Název (Name): Reprezentuje název produktu.
* double Cena (Price): Reprezentuje cenu produktu.
zobrazInfo()*, vytiskne název a cenu produktu.

ElektronickýProdukt (Dědí od Produktu):
Zahrňte dodatečnou vlastnost:
* string Výrobce (Manufacturer): Reprezentuje výrobce elektronického produktu.
Přepište metodu *ZobrazInfo()* tak, aby obsahovala informace o výrobci.

Třída Kniha (Dědí od Produktu):
Zahrňte dodatečnou vlastnost:
* string Autor (Author): Reprezentuje autora knihy.
Přepište metodu *ZobrazInfo()* tak, aby obsahovala informace o autorovi.
*/

using ukol_classes;

Product thing1 = new Product();
Product thing2 = new Product();
Product thing3 = new Product();
ElectronicProduct thing4 = new ElectronicProduct();
ElectronicProduct thing5 = new ElectronicProduct();
Book thing6 = new Book();

thing1.assignName("table lamp");
thing1.assignPrice(32);

thing2.assignName("vacuum cleaner");
thing2.assignPrice(132.5);

thing3.assignName("car");
thing3.assignPrice(666.666);

thing4.assignName("laptop");
thing4.assignPrice(2222.2);
thing4.assignManufacturer("asus");

thing5.assignName("phone");
thing5.assignPrice(999.9);
thing5.assignManufacturer("jPhone");

thing6.assignName("a bowl of mac and cheese - an epic story");
thing6.assignPrice(0.69);
thing6.assignAuthor("john doe");

// Product[] products = new Product[5];
Product[] products = { thing1, thing2, thing3, thing4, thing5, thing6 };

Console.Clear();
foreach (Product thing in products)
{
    thing.ShowInfo();
    Console.WriteLine();
}
