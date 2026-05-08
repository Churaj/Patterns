namespace Patterns.Creational.FactoryMethod
{
    public interface IProductService
    {
        IProduct DoSomethingWithProduct(ProductType productType);
    }
}
