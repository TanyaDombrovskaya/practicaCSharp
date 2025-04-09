using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Display(Name = "Введите название блюда: ")]
        [Required(ErrorMessage = "Заполните поле")]
        
        public string Title { get; set; }

        [Display(Name = "Введите ингридиенты: ")]
        [StringLength(30, ErrorMessage = "Текст не более 100 символов")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Ingredients { get; set; }

        [Display(Name = "Введите шаги: ")]
        [StringLength(30, ErrorMessage = "Текст не более 150 символов")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Steps { get; set; }
    }
}   
