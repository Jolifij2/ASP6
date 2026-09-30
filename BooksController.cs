using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ControlsApp.Models;

namespace ControlsApp.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> _books = new List<Book>();
        private static int _nextId = 1;

        // GET: /Books/Create
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new BookViewModel
            {
                Book = new Book()
            };
            return View(viewModel);
        }

        // POST: /Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.Book.Id = _nextId++;
                _books.Add(viewModel.Book);

                TempData["Message"] = $"Книга \"{viewModel.Book.Title}\" успешно добавлена!";
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: /Books
        public IActionResult Index()
        {
            return View(_books);
        }
    }
}
