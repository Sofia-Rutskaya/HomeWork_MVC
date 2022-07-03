using HomeWork1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HomeWork1.Service.Interface;

namespace HomeWork1.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalogArtService _catalogArt;

        public CatalogController(ILogger<HomeController> logger,
            ICatalogArtService catalogArt)
        {
            _logger = logger;
            _catalogArt = catalogArt;
        }

    }
}
