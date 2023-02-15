using Microsoft.AspNetCore.Mvc;
using SearchingOMDB.Models;
using System.Diagnostics;

namespace SearchingOMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MovieNight()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearchForm()
        {
            return View("MovieSearch");
        }
        [HttpPost]
        public IActionResult MovieSearchResult(string title)
        {
            return View("MovieSearch",SingleMovieDAL.MovieSearch(title)) ;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}