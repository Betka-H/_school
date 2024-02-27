namespace ukol_classes
{
    public class Utilities
    {
        public string userInput()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return Console.ReadLine().Trim().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
