using System;

namespace Patterns.Creational.FactoryMethod
{
    public class ProductFactory : IProductFactory
    {
        public IProduct CreateProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Type1:
                    return new ProductOfType1();
                case ProductType.Type2:
                    return new ProductOfType2();
                case ProductType.None:
                default:
                    throw new ArgumentException("Not supported product type.");
            }
        }
    }
}
