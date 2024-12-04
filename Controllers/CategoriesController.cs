using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit([FromRoute]int? id)
        {
            var category = new Category 
            {
                CategoryId = id.HasValue ? id.Value : 0

            };
            return View(category);
        }
    }
}
