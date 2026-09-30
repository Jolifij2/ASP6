using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlsApp.Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }

        public List<SelectListItem> Cities { get; set; }

        public List<SelectListItem> Genders { get; set; }

        public StudentViewModel()
        {
            Cities = new List<SelectListItem>
            {
                new SelectListItem { Value = "Москва", Text = "Москва" },
                new SelectListItem { Value = "Санкт-Петербург", Text = "Санкт-Петербург" },
                new SelectListItem { Value = "Казань", Text = "Казань" },
                new SelectListItem { Value = "Новосибирск", Text = "Новосибирск" }
            };

            Genders = new List<SelectListItem>
            {
                new SelectListItem { Value = "Мужской", Text = "Мужской" },
                new SelectListItem { Value = "Женский", Text = "Женский" }
            };
        }
    }
}
