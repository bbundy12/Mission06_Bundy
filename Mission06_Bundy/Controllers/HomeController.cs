using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult MoviesForm(Movie response) 
        {
            // Check if LentTo is null and set it to an empty string if it is
            if (response.LentTo == null)
            {
                response.LentTo = string.Empty;
            }

            // Check if Notes is null and set it to an empty string if it is
            if (response.Notes == null)
            {
                response.Notes = string.Empty;
            }

            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }


    }
}
