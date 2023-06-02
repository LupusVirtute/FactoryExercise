namespace FactoryExercise
{
    public class Product
    {
        public Product(decimal price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;
        }

        public decimal Price { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
