using RecipeBook.Models;

namespace RecipeBook.Controllers
{
    public static class RecipeStorage
    {
        public static List<Recipe> Recipes { get; } = new List<Recipe>
        {
            new Recipe { Id = 1, Title = "Паста", Ingredients = "Паста, Вода, Соль", Steps = "Варить пасту в воде." },
            new Recipe { Id = 2, Title = "Салат", Ingredients = "Огурцы, Помидоры, Оливковое масло", Steps = "Смешать все ингредиенты." },
            new Recipe { Id = 3, Title = "Омлет", Ingredients = "Яйца, Молоко, Соль", Steps = "Взбить яйца и пожарить." }
        };
    }
}
