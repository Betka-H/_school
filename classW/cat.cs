public class Cat
{
    public string? name,
        breed,
        hairColor,
        personality,
        favoriteFood;
    public float age;

    public void list()
    {
        Console.WriteLine("name: " + name);
        Console.WriteLine("age: " + age);
        Console.WriteLine("breed: " + breed);
        Console.WriteLine("hair color: " + hairColor);
        Console.WriteLine("personality: " + personality);
        Console.WriteLine("favorite food: " + favoriteFood);
    }
}
