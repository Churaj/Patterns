namespace Patterns.Creational.FactoryMethod
{
    public class ProductOfType2 : IProduct
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"I'm product 2 with name {Name}";
        }
    }
}
