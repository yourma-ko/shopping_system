using Microsoft.AspNetCore.Mvc;

namespace shopping_system.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
