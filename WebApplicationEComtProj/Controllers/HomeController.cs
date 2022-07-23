using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationEComtProj.Models;

namespace WebApplicationEComtProj.Controllers
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

        public IActionResult PinturaCatObras() 
        { 
            return View(); 
        }

        public IActionResult EsculturaCatObras()
        {
            return View();
        }
        public IActionResult FotografiaCatObras()
        {
            return View();
        }

        public IActionResult PosterCatObras()
        {
            return View();
        }
        public IActionResult DesignCatObras()
        {
            return View();
        }

        public IActionResult MusicaCatObras()
        {
            return View();
        }

        public IActionResult PagPerfil()
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