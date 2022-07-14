using Balu.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Balu.ViewModels
{
    public class ProductsVM
    {
        public IEnumerable<Product> allProducts { get; set; }
        public string currCatedory { get; set; }
    }
}
