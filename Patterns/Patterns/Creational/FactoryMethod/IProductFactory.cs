namespace Patterns.Creational.FactoryMethod;

public interface IProductFactory
{
    IProduct CreateProduct(ProductType productType);
}