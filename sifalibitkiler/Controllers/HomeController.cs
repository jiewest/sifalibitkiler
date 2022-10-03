using Microsoft.AspNetCore.Mvc;
using sifalibitkiler.Models;
using System.Diagnostics;

namespace sifalibitkiler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            sifalibitkiContext db = new sifalibitkiContext();
            var sayfa=db.Sayfalars.Find(id);   
            return View(sayfa);
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