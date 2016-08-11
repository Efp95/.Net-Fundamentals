using Exercise.Entities;
using System.Collections.Generic;

namespace Exercise.Extensions
{
    public static class ProductsCollectionExtensions
    {
        public static void Add(this List<Product> list, string name, int quantity)
        {
            list.Add(new Product
            {
                Name = name,
                Quantity = quantity
            });
        }
    }
}
