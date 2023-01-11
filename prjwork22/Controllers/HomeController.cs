using Microsoft.AspNetCore.Mvc;
using prjwork22.Models;
using System.Diagnostics;

namespace prjwork22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _context;

        public HomeController(ILogger<HomeController> logger, DemoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult travelwork1()
        {
            return View();
        }
        public IActionResult Members()
        {
            return View(_context.Members);
        }
        public IActionResult register()
        {

            return View();

        }
        public IActionResult work3address()
        {
            return View();
        }


        public IActionResult Privacy()
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