namespace ukol_classes
{
    public class ElectronicProduct : Product
    {
        private string manufacturer = "electronic product manufacturer here";

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($", manufacturer: {manufacturer}");
        }

        public void assignManufacturer(string m)
        {
            manufacturer = m;
        }
    }
}
