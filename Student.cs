using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlsApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя от 2 до 50 символов")]
        [Display(Name = "Имя студента")]
        public string Name { get; set; }

        [Range(1, 120, ErrorMessage = "Возраст от 1 до 120")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Некорректный email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Активен")]
        public bool IsActive { get; set; }

        [Display(Name = "О себе")]
        [StringLength(500, ErrorMessage = "Не более 500 символов")]
        public string About { get; set; }

        // ===== Задание 1. Телефон =====
        [Display(Name = "Телефон")]
        [RegularExpression(@"^\d{10,}$", ErrorMessage = "Телефон должен содержать только цифры и быть не короче 10 символов")]
        public string Phone { get; set; }

        // ===== Задание 2. Дата рождения =====
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        // ===== Задание 3. Несколько городов =====
        [Display(Name = "Выбранные города")]
        public List<string> SelectedCities { get; set; } = new List<string>();
    }
}
