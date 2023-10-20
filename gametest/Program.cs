Random rnd = new Random();



int w3CatNumber = 5; //how many categories to draw from
string[] w3Categories = { "animal", "food", "drink", "plant", "country", "weather", "body part", "clothes", "color", "name", "game" };
string[] w3CategoriesChosen = { "", "", "", "", "" };
//all the items
{
    string[] w3CAnimal = { "cat", "dog", "fish", "fox", "raccoon", "rat", "guinea pig", "bunny", "bear", "goose", "frog", "mole", "bee" };
    string[] w3CFood = { "burger", "carrot", "cucumber", "bread", "rice", "potatoes", "sandwich", "yoghurt", "cheese", "apple", "pear", "grape", "eggplant", "egg" };
    string[] w3CDrink = { "water", "orange juice", "apple juice", "vodka", "beer", "wine", "jagermilker", "grimace shake", "lean", "milk", "tea", "coffee" };
    string[] w3CPlant = { "grass", "dandelion", "rose", "sunflower", "tree", "bush", "seaweed", "oxeye daisy", "peony", "forget me not", "lily", "orchid", "cactus", "bamboo", "sugar cane", "wheat", "allium", "cornflower", "tulip" };
    string[] w3CCountry = { "america", "china", "great britain", "ukraine", "czech republic", "deutschland", "poland", "netherlands", "slovakia", "slovenia", "india", "taiwan", "korea" };
    string[] w3CWeather = { "rain", "wind", "sun", "breeze", "heat", "cold", "freezing", "clouds" };
    string[] w3CBodyPart = { "arm", "hand", "leg", "foot", "head", "neck", "ear", "nose", "eyes", "finger", "wrist" };
    string[] w3CClothes = { "hat", "scarf", "gloves", "t-shirt", "shirt", "jacket", "blouse", "pants", "jeans", "shoes", "coat" };
    string[] w3CColor = { "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "gray", "black", "white", "lime green", "cyan", "ultramarine", "magenta", "blurple" };
    string[] w3CName = { "alexa", "alex", "steve", "karen", "joe", "john", "mary", "susie", "henry", "jack", "george", "elisabeth", "lucy", "emma", "catherine", "jane", "anna", "carl" };
    string[] w3CGame = { "settlers of catan", "carcassonne", "karnoffel", "uno", "monopoly", "minecraft", "ori and the blind forest", "poker", "canasta", "domino", "magic the gathering", "inscryption", "five nights at freddys", "geometry dash", "hill climb racing" };
}

//sort stuff///////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("> sort the words into their correct categories:");

for (int i = 1; i <= w3CatNumber; i++)
{
    //choose a random category index and print it's name
    int w3CategoryIndex = rnd.Next(10);
    Console.WriteLine(i + ": " + w3Categories[w3CategoryIndex]);
    //write the chosen category into the chosen categories array
    int w3CategoriesChosenIndex = i - 1;
    w3CategoriesChosen[w3CategoriesChosenIndex] = w3Categories[w3CategoryIndex];
}











Console.WriteLine("> press enter to exit");
Console.ReadLine();