using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ControlsApp.Models;

namespace ControlsApp.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> _students = new List<Student>();
        private static int _nextId = 1;

        // GET: /Students/Create
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new StudentViewModel
            {
                Student = new Student()
            };
            return View(viewModel);
        }

        // POST: /Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.Student.Id = _nextId++;
                _students.Add(viewModel.Student);

                TempData["Message"] = $"Студент {viewModel.Student.Name} успешно добавлен!";
                return RedirectToAction("Index");
            }

            // Если валидация не прошла – показываем форму снова с ошибками
            return View(viewModel);
        }

        // GET: /Students – список студентов
        public IActionResult Index()
        {
            return View(_students);
        }
    }
}
