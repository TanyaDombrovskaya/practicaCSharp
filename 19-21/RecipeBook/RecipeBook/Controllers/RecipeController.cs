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

        [HttpPost]
        public IActionResult Change(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return View(recipe);
            }

            var existingRecipe = RecipeStorage.Recipes.FirstOrDefault(r => r.Id == recipe.Id);

            if (existingRecipe != null)
            {
                existingRecipe.Title = recipe.Title;
                existingRecipe.Ingredients = recipe.Ingredients;
                existingRecipe.Steps = recipe.Steps;

                return RedirectToAction("Index", "Home");
            }

            return NotFound();
        }
    }
}
