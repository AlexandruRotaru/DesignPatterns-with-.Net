namespace IteratorPattern.Aggregator
{
    public class MenuItem
    {
        private readonly string name;
        private readonly string description;
        private readonly bool isVegetarian;
        private readonly double price;

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.isVegetarian = isVegetarian;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public bool GetIsVegetarian()
        {
            return isVegetarian;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
