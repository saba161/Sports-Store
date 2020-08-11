﻿using Microsoft.AspNetCore.Mvc;
using Sports_Store.Models;
using Sports_Store.Models.Pages;

namespace Sports_Store.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryRepository repository;

        public CategoriesController(ICategoryRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(QueryOptions options)
        {
            return View(repository.GetCategories(options));
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            repository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult EditCategory(long id)
        {
            ViewBag.EditId = id;
            return View("Index", repository.Categories);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            repository.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            repository.DeleteCategory(category);
            return RedirectToAction(nameof(Index));
        }
    }
}
