using Balu.Data.Models;
using System.Collections.Generic;

namespace Balu.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
