using Balu.Data.Interfaces;
using Balu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Balu.Controllers
{
    public class MoreInfoProductController : Controller
    {
        public IActionResult Index(int id)
        {
            OneProductVM item = new OneProductVM();
            item.product = _product.GetAllProducts.FirstOrDefault(_product => _product.Id == id);
            return View(item);
        }

        private readonly IProduct _product;
        private readonly ICategory _category;

        public MoreInfoProductController(IProduct product, ICategory category)
        {
            _product = product;
            _category = category;
        }
    }
}
