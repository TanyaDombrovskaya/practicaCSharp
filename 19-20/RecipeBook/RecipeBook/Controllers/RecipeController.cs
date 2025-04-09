using Microsoft.AspNetCore.Mvc;
using RecipeBook.Models;

namespace RecipeBook.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                RecipeStorage.Recipes.Add(recipe);

                return RedirectToAction("Index", "Home");
            }

            return View("Index");
        }
    }
}
