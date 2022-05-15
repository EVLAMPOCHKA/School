using Microsoft.AspNetCore.Mvc;
using School.Models;
using System.Diagnostics;

namespace School.Controllers
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

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Teachers()
        {
            return View();
        }

        public IActionResult Activities()
        {
            return View("Activity");
        }

        public IActionResult BestStudents()
        {
            return View();
        }
        public IActionResult Administration()
        {
            return View();
        }

        public IActionResult Sheet()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}