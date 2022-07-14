using Balu.Data.Interfaces;
using Balu.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Balu.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrder order;
        private readonly Basket basket;

        public OrderController(IOrder order, Basket basket)
        {
            this.order = order;
            this.basket = basket;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
