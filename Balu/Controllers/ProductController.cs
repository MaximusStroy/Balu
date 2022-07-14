using Balu.Data.Interfaces;
using Balu.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Balu.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _productRepository;
        private readonly Product _product;

        public ProductController(IProduct productRepository, Product product)
        {
            _productRepository = productRepository;
            _product = product;
        }

        public IActionResult Index(int? id)
        {
            var item = _productRepository.GetAllProducts.FirstOrDefault(i => i.Id == id);
            return View(item);
        }
    }
}
