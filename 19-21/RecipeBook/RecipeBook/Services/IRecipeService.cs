using RecipeBook.Models;
using System.Collections.Generic;

namespace RecipeBook.Services
{
    public interface IRecipeService
    {
        IEnumerable<Recipe> SearchByIngredient(string ingredient);
    }
}