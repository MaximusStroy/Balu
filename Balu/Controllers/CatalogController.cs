using Balu.Data.Interfaces;
using Balu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Balu.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            ProductsVM obj = new ProductsVM();
            obj.allProducts = _product.GetAllProducts;
            obj.currCatedory = "none category";
            return View(obj);
        }

        private readonly IProduct _product;
        private readonly ICategory _category;

        public CatalogController(IProduct product, ICategory category)
        {
            _product = product;
            _category = category;
        }

    }
}
