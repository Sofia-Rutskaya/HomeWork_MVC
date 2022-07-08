using HomeWork1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HomeWork1.Service.Interface;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalogArtService _catalogArt;
       
        public HomeController (ILogger<HomeController> logger,
            ICatalogArtService catalogArt)
        {
            _logger = logger;
            _catalogArt = catalogArt;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _catalogArt.GetHomePageInfo();
            return View(result);
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