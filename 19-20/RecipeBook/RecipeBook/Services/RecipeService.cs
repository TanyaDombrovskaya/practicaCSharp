using RecipeBook.Controllers;
using RecipeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBook.Services
{
    public class RecipeService : IRecipeService
    {
        public IEnumerable<Recipe> SearchByIngredient(string ingredient)
        {
            if (string.IsNullOrWhiteSpace(ingredient))
            {
                return new List<Recipe>();
            }

            var matchedRecipes = RecipeStorage.Recipes
                .Where(r => r.Ingredients.Contains(ingredient, System.StringComparison.OrdinalIgnoreCase))
                .ToList();

            return matchedRecipes;
        }
    }
}