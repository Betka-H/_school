Random rnd = new Random();

Console.ForegroundColor = ConsoleColor.Gray;

int w3CatAmount = 3; // how many categories to use
int w3ItemAmount = 5; // how many items to use from each category
string[] w3AllCategories = { "animals", "foods", "drinks", "plants", "countries", "weather", "body parts", "clothes", "colors", "names", "games" };
int w3CatRandom; // random number that gets generated repeatedly to determine which categories to sort into
int w3ItemRandom; // random number that gets generated repeatedly to determine which items to sort
string[] w3CategoriesChosen = { }; // array of randomly generated categories
string[] w3ItemsChosen = { }; // array of randomly generated items from these categories

int w3RandomCatLoopCheck = 1; // purely for debug



string[][] w3AllItems = new string[][]
{
    new string[]{ // 0 animals
        "cat", "dog", "fish", "fox", "raccoon", "rat", "guinea pig", "bunny", "bear", "goose", "frog", "mole", "bee", "chicken"
        },
    new string[]{ // 1 foods
        "burger", "carrot", "cucumber", "bread", "rice", "potatoes", "sandwich", "yoghurt", "cheese", "apple", "pear", "grape", "eggplant", "egg"
        },
    new string[]{ // 2 drinks
        "water", "orange juice", "apple juice", "vodka", "beer", "wine", "jagermilker", "grimace shake", "lean", "milk", "tea", "coffee"
        },
    new string[]{ // 3 plants
        "grass", "dandelion", "rose", "sunflower", "tree", "bush", "seaweed", "oxeye daisy", "peony", "forget me not", "lily", "orchid", "cactus", "bamboo", "sugar cane", "wheat", "allium", "cornflower", "tulip"
        },
    new string[]{ // 4 countries
        "america", "china", "great britain", "ukraine", "czech republic", "deutschland", "poland", "netherlands", "slovakia", "slovenia", "india", "taiwan", "korea", "greece"
        },
    new string[]{ // 5 weather
        "rain", "wind", "sun", "breeze", "heat", "cold", "freezing", "clouds"
        },
    new string[]{ // 6 body parts
        "arm", "hand", "leg", "foot", "head", "neck", "ear", "nose", "eyes", "finger", "wrist"
        },
    new string[]{ // 7 clothes
        "hat", "scarf", "gloves", "t-shirt", "shirt", "jacket", "blouse", "pants", "jeans", "shoes", "coat"
        },
    new string[]{ // 8 colors
        "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "gray", "black", "white", "lime green", "cyan", "ultramarine", "magenta", "blurple"
        },
    new string[]{ // 9 names
        "alexa", "alex", "steve", "karen", "joe", "john", "mary", "susie", "henry", "jack", "george", "elisabeth", "lucy", "emma", "catherine", "jane", "anna", "carl"
        },
    new string[]{ // 10 games
        "settlers of catan", "carcassonne", "karnoffel", "uno", "monopoly", "minecraft", "ori and the blind forest", "poker", "canasta", "domino", "magic the gathering", "inscryption", "five nights at freddys", "geometry dash", "hill climb racing"
        }
};





//// terminate the program...
// if the requested category amount exceeds the existing amount
if (w3CatAmount > w3AllCategories.Count())
{
    Console.WriteLine("> error: w3CatAmount exceeds the amount of elements in w3AllCategories\n> terminating program...");
    Environment.Exit(0);
}
// if the requested amount of categories is 1 or less
if (w3CatAmount <= 1)
{
    Console.WriteLine("> error: requested category draw amount is less than 2\n> terminating program...");
    Environment.Exit(0);
}
// if the requested amount of items is 0 or less
if (w3ItemAmount <= 0)
{
    Console.WriteLine("> error: requested item draw amount is less than 0\n> terminating program...");
    Environment.Exit(0);
}

/* Console.WriteLine("> sort the words into their correct categories:"); */

///////////xxxxxxxxxxxxxxxxxxxxxxxxx
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(">>>>> | start | <<<<<");
Console.WriteLine(DateTime.Now);
Console.ForegroundColor = ConsoleColor.Gray;
// for the requested amount of categories
for (int i = 1; i <= w3CatAmount; i++)
{
    Console.WriteLine("loop " + w3RandomCatLoopCheck + " (category " + i + "/" + w3CatAmount + ")");
    w3CatRandom = rnd.Next(w3AllCategories.Count()); // chooses a random index from all the existing categories

    Console.WriteLine("the category name is: " + w3AllCategories[w3CatRandom]);

    if (!w3CategoriesChosen.Contains(w3AllCategories[w3CatRandom])) // only runs if the category isnt already in the list
    {
        Array.Resize(ref w3CategoriesChosen, i); // resizes chosen category array  to i
        w3CategoriesChosen[i - 1] = w3AllCategories[w3CatRandom]; // writes the category name into the chosen categories array
    }
    else // skip
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("the category is in the array already. skipping");  // debug
        Console.ForegroundColor = ConsoleColor.Gray;
        i--;
    }


    w3RandomCatLoopCheck++;
    Console.WriteLine();
}


for (int i = 1; i <= w3ItemAmount; i++)
{

    w3ItemRandom = rnd.Next(w3AllItems[Array.IndexOf(w3AllCategories, w3CategoriesChosen[69])].Count()); // chooses a random index from all the existing items in the category
    Console.Write(w3ItemRandom);
    Console.Write(": ");
    Console.Write(w3AllItems[i - 1][w3ItemRandom]);

    if (!w3ItemsChosen.Contains(w3AllItems[i - 1][w3ItemRandom])) // only runs if the category isnt already in the list
    {
        Console.WriteLine();
        Array.Resize(ref w3ItemsChosen, i);
        w3ItemsChosen[i - 1] = w3AllItems[i - 1][w3ItemRandom];
    }
    else // skip
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" > the item is in the array already. skipping");  // debug
        Console.ForegroundColor = ConsoleColor.Gray;
        i--;
    }



}


///////////xxxxxxxxxxxxxxxxxxxxxxxxx
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("the selected categories are: "); // list categories
for (int i = 1; i <= w3CatAmount; i++)
{
    Console.Write(w3CategoriesChosen[i - 1] + " " + (i - 1));
    if (i < w3CatAmount)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

Console.Write("the selected items are: "); // list items
for (int i = 1; i <= w3ItemAmount; i++)
{
    Console.Write(w3ItemsChosen[i - 1] + " " + (i - 1));
    if (i < w3ItemAmount)
    {
        Console.Write(", ");
    }
}

Console.ForegroundColor = ConsoleColor.Gray;

Console.WriteLine();








/* 
Console.WriteLine("> press anything to exit");
Console.ReadKey();
 */