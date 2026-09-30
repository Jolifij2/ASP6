using System;
using System.ComponentModel.DataAnnotations;

namespace ControlsApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Название от 1 до 200 символов")]
        [Display(Name = "Название")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Автор обязателен")]
        [StringLength(150, ErrorMessage = "Не более 150 символов")]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Range(1000, 2100, ErrorMessage = "Год от 1000 до 2100")]
        [Display(Name = "Год издания")]
        public int Year { get; set; }

        [Range(0.01, 1000000, ErrorMessage = "Цена должна быть положительной")]
        [DataType(DataType.Currency)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Категория обязательна")]
        [Display(Name = "Категория")]
        public string Category { get; set; }

        [StringLength(1000, ErrorMessage = "Не более 1000 символов")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Доступна")]
        public bool IsAvailable { get; set; }
    }
}
