namespace ukol_classes
{
    public class Book : Product
    {
        private string author = "book author here";

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($", author: {author}");
        }

        public void assignAuthor(string a)
        {
            author = a;
        }
    }
}
