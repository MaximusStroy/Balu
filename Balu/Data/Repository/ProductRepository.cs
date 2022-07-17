using Balu.Data.Interfaces;
using Balu.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Balu.Data.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> GetAllProducts => db.Product.Include(p => p.Category);

        public IEnumerable<Product> GetFavouriteProducts => db.Product.Where(p => p.IsFavourite).Include(p => p.Category);

        public Product GetProduct(int productId) => db.Product.FirstOrDefault(p => p.Id == productId);
    }
}
