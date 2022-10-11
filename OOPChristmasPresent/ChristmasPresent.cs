namespace OOPChristmasPresent
{
    public class ChristmasPresent
    {
        private string name;
        private int price;

        public ChristmasPresent (string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int Price { get { return price; } }
    }
}
