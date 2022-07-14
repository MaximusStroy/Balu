using System.Collections.Generic;

namespace Balu.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
