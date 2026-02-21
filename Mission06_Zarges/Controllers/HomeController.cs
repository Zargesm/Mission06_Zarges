using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission06_Zarges.Models;

namespace Mission06_Zarges.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        // =============================
        // ADD MOVIE - GET
        // =============================
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = new SelectList(
                _context.Categories.OrderBy(c => c.CategoryName),
                "CategoryId",
                "CategoryName"
            );

            return View();
        }

        // =============================
        // ADD MOVIE - POST
        // =============================
        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return RedirectToAction("Confirmation");
            }

            ViewBag.Categories = new SelectList(
                _context.Categories.OrderBy(c => c.CategoryName),
                "CategoryId",
                "CategoryName"
            );

            return View(response);
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}