using Balu.Data.Interfaces;
using Balu.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Balu.Data.Mocks
{
    public class MockProduct : IProduct
    {
        private readonly ICategory category = new MockCategory();
        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return new List<Product>
                {
                    new Product { Name = "Balu", Img = "", Price = 1000, CategoryId = 1, IsFavourite = true, Category = category.GetAllCategories.First() }
                };
            }
        }
        public IEnumerable<Product> GetFavouriteProducts { get; set; }

        public Product GetProduct(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
