using ADMINISTRACION.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ADMINISTRACION.WEB.Controllers
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

        public IActionResult LstCine()
        {
            return View();
        }

        public IActionResult AddEditCine()
        {
            return View();
        }
        public IActionResult LstPelicula()
        {
            return View();
        }

        public IActionResult AddEditPelicula()
        {
            return View();
        }

        public IActionResult LstPromocion()
        {
            return View();
        }

        public IActionResult AddEditPromocion()
        {
            return View();
        }

        public IActionResult LstEvento()
        {
            return View();
        }

        public IActionResult AddEditEvento()
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