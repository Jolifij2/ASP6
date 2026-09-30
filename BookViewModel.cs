using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlsApp.Models
{
    public class BookViewModel
    {
        public Book Book { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public BookViewModel()
        {
            Categories = new List<SelectListItem>
            {
                new SelectListItem { Value = "Художественная", Text = "Художественная" },
                new SelectListItem { Value = "Научная", Text = "Научная" },
                new SelectListItem { Value = "Техническая", Text = "Техническая" },
                new SelectListItem { Value = "Детская", Text = "Детская" },
                new SelectListItem { Value = "Учебная", Text = "Учебная" }
            };
        }
    }
}
