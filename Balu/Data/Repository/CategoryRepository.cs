using Balu.Data.Interfaces;
using Balu.Data.Models;
using System.Collections.Generic;

namespace Balu.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAllCategories => db.Category;
    }
}
