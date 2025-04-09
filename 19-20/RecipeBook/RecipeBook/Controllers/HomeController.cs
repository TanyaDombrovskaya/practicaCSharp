using Microsoft.AspNetCore.Mvc;
using RecipeBook.Models;
using System.Diagnostics;
using RecipeBook.Services;

namespace RecipeBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRecipeService _recipeService;

        public HomeController(ILogger<HomeController> logger, IRecipeService recipeService)
        {
            _logger = logger;
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            var recipes = RecipeStorage.Recipes;
            return View(recipes);
        }

        [HttpGet]
        public IActionResult Search(string ingredient)
        {
            var matchedRecipes = _recipeService.SearchByIngredient(ingredient);

            if (matchedRecipes == null || !matchedRecipes.Any())
            {
                return View("Index", new List<Recipe>());
            }

            return View("Index", matchedRecipes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
