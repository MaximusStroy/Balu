using Microsoft.AspNetCore.Mvc;

namespace Balu.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
