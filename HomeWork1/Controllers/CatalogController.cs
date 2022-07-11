using HomeWork1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HomeWork1.Service.Interface;
using Microsoft.AspNetCore;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

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


        public async Task<IActionResult> Illustrations(int? pageNumber)
        {
            if (pageNumber < 0) pageNumber = 0;
            int pageSize = 3;
            int pageNums = pageNumber == null ? 1 : 0;
            var item = await _catalogArt.GetPagesInfo();
            var result = await PaginationList<CatalogArtItem>.CreateAsync(item, pageNumber ?? 1, pageSize);
            result.NextPage = (result.PageIndex == result.TotalPages - 1) ? "is-disabled" : string.Empty;
            result.PreviousPage = (result.PageIndex == 0) ? "is-disabled" : string.Empty;

            //vm.PaginationInfo.Next = (vm.PaginationInfo.ActualPage == vm.PaginationInfo.TotalPages - 1) ? "is-disabled" : string.Empty;
            //vm.PaginationInfo.Previous = (vm.PaginationInfo.ActualPage == 0) ? "is-disabled" : string.Empty;

            return View(result);            
        }

        public async Task<IActionResult> Tutorial(int? pageNumber)
        {
            if (pageNumber < 0) pageNumber = 0;
            int pageSize = 1;
            int pageNums = pageNumber == null ? 1 : 0;
            var item = await _catalogArt.GetTutorial();
            var result = await PaginationList<CatalogTutorial>.CreateAsync(item, pageNumber ?? 1, pageSize);
            result.NextPage = (result.PageIndex == result.TotalPages - 1) ? "is-disabled" : string.Empty;
            result.PreviousPage = (result.PageIndex == 0) ? "is-disabled" : string.Empty;
            return View(result);

        }
    }
}
