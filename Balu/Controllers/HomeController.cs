using Balu.Data.Interfaces;
using Balu.Models;
using Balu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Balu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IProduct _product;
        public HomeController(ILogger<HomeController> logger, IProduct product)
        {
            _logger = logger;
            _product = product;
        }

        public IActionResult Index()
        {
            ProductsVM obj = new ProductsVM();
            obj.allProducts = _product.GetAllProducts;
            obj.currCatedory = "none category";
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
