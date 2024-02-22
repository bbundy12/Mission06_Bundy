using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Bundy.Models;
using System.Diagnostics;

namespace Mission06_Bundy.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;

        public HomeController(MovieFormContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowMe()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MoviesForm()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult MoviesForm(Movie response) 
        {             
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);         
        }

        public IActionResult MovieList() 
        {
            var categories = _context.Movies.Include("Category")
                .OrderBy(x => x.Category.CategoryName).ToList();

            return View(categories); 
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        { 
            var recordToEdit = _context.Movies
                .Single(x => x.MovieID == id);


            ViewBag.Categories = _context.Categories //This is included since the MovieForm needs it to make the category drop down
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MoviesForm", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movie updatedRecord)
        {
            _context.Update(updatedRecord);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieID == id);

            ViewBag.Categories = _context.Categories //This is included since the MovieForm needs it to make the category drop down
               .OrderBy(x => x.CategoryName)
               .ToList();

            return View("Delete", recordToDelete);

        }
        [HttpPost]
        public IActionResult Delete(Movie deleteRecord)
        {
            _context.Remove(deleteRecord);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }



    }
}
