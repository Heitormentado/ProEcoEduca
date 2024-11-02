using mf_dev_backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mf_dev_backend.Controllers
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

        public IActionResult EnergiaGeo()
        {
            return View();
        }

        public IActionResult Solar()
        {
            return View();
        }

        public IActionResult HidrogenioVerde()
        {
            return View();
        }

        public IActionResult Biocombustivel()
        {
            return View();
        }

        public IActionResult Hidreletrica()
        {
            return View();
        }

        public IActionResult Eolica()
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
