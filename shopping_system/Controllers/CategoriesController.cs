using Microsoft.AspNetCore.Mvc;
using shopping_system.Models;

namespace shopping_system.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesReopsitory.GetCategories();
            return View(categories);
        }
        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
            return View(category);

        }
    }

}
