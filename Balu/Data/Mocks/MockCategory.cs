using Balu.Data.Interfaces;
using Balu.Data.Models;
using System.Collections.Generic;

namespace Balu.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {Title = "Футболка"},
                    new Category {Title = "Худи"},
                    new Category {Title = "Шорты"}
                };
            }
        }
    }
}
