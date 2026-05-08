using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.FactoryMethod
{
    public class ProductService : IProductService
    {
        private readonly IProductFactory _productFactory;

        public ProductService(IProductFactory productFactory)
        {
            _productFactory = productFactory;
        }

        public IProduct DoSomethingWithProduct(ProductType productType)
        {
            // Do something with the product.

            var product = _productFactory.CreateProduct(productType);
            product.Name += "- Processed";

            return product;
        }
    }
}
