Random rnd = new Random();


int w3CategoryAmount = 5; // how many categories to use
int w3ItemAmount = 3; // how many items to use from each category
string[] w3Categories = {
        "animals", "foods", "drinks", "plants", "countries", "weather", "body parts", "clothes", "colors", "names", "games"
        };
int w3CatRandom; // random number that gets generated repeatedly to determine which categories to sort into
int w3ItemRandom; // random number that gets generated repeatedly to determine which items to sort
int[] w3CategoriesChosenIndex = { }; // array of randomly generated category indexes
int[] w3ItemsChosenIndex = { };
string[] w3CategoriesChosen = { }; // array of randomly generated categories
                                   //all the items




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

//sort stuff///////////////////////////////////////////////////////////////////////////////////

if (w3CategoryAmount > w3Categories.Count()) // terminate the program if w3CategoryAmount > elements in w3Categories
{
    Console.WriteLine("> error: w3CategoryAmount exceeds the amount of elements in w3Categories\n> terminating program...");
    Environment.Exit(0);
}
if (w3CategoryAmount <= 0) // terminate the program if w3CategoryAmount is 0 or less
{
    Console.WriteLine("> error: requested category draw amount is less than 1\n> terminating program...");
    Environment.Exit(0);
}

Console.WriteLine("> sort the words into their correct categories:");

for (int i = 1; i <= w3CategoryAmount; i++)
{
    w3CatRandom = rnd.Next(w3Categories.Count()); // generates a random number
    if (!w3CategoriesChosenIndex.Contains(w3CatRandom)) // // only run if the random number isnt already in the array
    {
        // number part
        Array.Resize(ref w3CategoriesChosenIndex, i); // resizes repeat check array +1
        w3CategoriesChosenIndex[i - 1] = w3CatRandom; // writes the random number into the freed up space
        Console.Write("> category " + i + ": "); // prints category number
        // category part
        Array.Resize(ref w3CategoriesChosen, i); // resizes chosen category list array +1
        w3CategoriesChosen[i - 1] = w3Categories[w3CatRandom]; // writes the randomly chosen category into the freed up space
        Console.WriteLine(w3Categories[w3CatRandom]); // prints category name
                                                      // item part
        for (int j = 1; j <= w3ItemAmount; j++)
        {
            w3ItemRandom = rnd.Next(w3AllItems[w3CatRandom].Count()); // generates random item number
            Array.Resize(ref w3ItemsChosenIndex, j); // resizes repeat check array +1
            w3CategoriesChosenIndex[i - 1] = w3CatRandom; // writes the random number into the freed up space
            Console.WriteLine("debug>> item index: " + w3ItemRandom); // prints item index
            //Console.WriteLine(w3AllItems[2][4]);
            if (!w3CategoriesChosenIndex.Contains(w3ItemRandom))
            {

            }
            else
            {

            }
        }
    }
    else // if the random number already is in the array
    {
        Console.WriteLine("debug>> number " + "(" + w3CatRandom + ")" + " already in list. skipping."); // debug
        i--; // so that the loop can run again correctly
    }
}

Console.Write("> items: ");












Console.WriteLine("> press anything to exit");
Console.ReadKey();