namespace ukol_classes
{
    public class Product
    {
        private string name = "product name here";
        private double price = -1;

        public virtual void ShowInfo()
        {
            Console.Write($"name: {name}, price: {price}");
        }

        public void assignName(string n)
        {
            name = n;
        }

        public void assignPrice(double p)
        {
            price = p;
        }
    }
}
