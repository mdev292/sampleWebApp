using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using sampleWebApp.Models;

namespace sampleWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookStoresDBContext _dbContext;

        public HomeController(ILogger<HomeController> logger, BookStoresDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Privacy2();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void Privacy2()
        {
            var nameOfBook = _dbContext.Books.FirstOrDefault();
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}
