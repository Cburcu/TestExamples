using System.Collections.Generic;

namespace HwQueryMasterTest
{
    internal class ProductManager
    {
        public static Product GetProduct()
        {
            var product = new Product
            {
                Id = 1,
                Title = "Hp intel core i7",
                ListPrice = 2500,
                CategoryId = 3
            };
            return product;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(GetProduct());
            products.Add(GetProduct());
            return products;
        }
    }
}