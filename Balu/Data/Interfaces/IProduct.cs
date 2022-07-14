using Balu.Data.Models;
using System.Collections.Generic;

namespace Balu.Data.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetFavouriteProducts { get; }
        Product GetProduct(int productId);

    }
}
