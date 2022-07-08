using HomeWork1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HomeWork1.Service.Interface;
using Microsoft.AspNetCore;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

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

        public async Task<IActionResult> GetAutorInfo()
        {
            var result = await _catalogArt.GetAuthorDesc();
            return View(result);
        }

        public async Task<IActionResult> Pagination(int? pageNumber)
        {
            int pageSize = 3;
            int pageNums = pageNumber == null ? 0 : pageNumber.Value;
            var item = await  _catalogArt.GetPagesInfo(pageSize, pageNums);
          
            return View(await PaginationList<CatalogArtItem>.CreateAsync(item.AsQueryable(), pageNumber ?? 1, pageSize));            
        }
    }
}
