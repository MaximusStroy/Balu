using Balu.Data.Interfaces;
using Balu.Data.Models;
using Balu.Data.Repository;
using Balu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Balu.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProduct _productRepository;
        private readonly Basket _basket;

        public BasketController(IProduct productRepository, Basket basket)
        {
            _productRepository = productRepository;
            _basket = basket;
        }

        public IActionResult Index()
        {
            var items = _basket.GetBasketItems();
            _basket.ListItemsInBasket = items;

            var obj = new BasketVM
            {
                basket = _basket
            };

            return View(obj);
        }

        public RedirectToActionResult addToBasket(int id)
        {
            var item = _productRepository.GetAllProducts.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _basket.AddToBasket(item);
            }
            return RedirectToAction("Index");
        }
    }
}
