using HomeWork1.Service.Interface;
using Newtonsoft.Json;
using HomeWork1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeWork1.Service
{
    public class CatalogArtService : ICatalogArtService
    {
        private readonly ILogger _logger;
        public CatalogArtService(ILogger<CatalogArtService> logger)
        {
            _logger = logger;
        }

        public async Task<List<CatalogArtItem>?> GetPagesInfo()
        {
            var config = await File.ReadAllTextAsync("CatalogIllustrations.json");
            var items = JsonConvert.DeserializeObject<List<CatalogArtItem>>(config);

            return items;
        }

        public async Task<List<UniversalCatalog>?> GetTutorial()
        {
            var config = await File.ReadAllTextAsync("Tutorial.json");
            var items = JsonConvert.DeserializeObject<List<UniversalCatalog>>(config);

            return items;
        }
        
        public async Task<List<UniversalCatalog>?> GetComics()
        {
            var config = await File.ReadAllTextAsync("Comics.json");
            var items = JsonConvert.DeserializeObject<List<UniversalCatalog>>(config);

            return items;
        }

        public async Task<HomeItems?> GetHomePageInfo()
        {
            var config = await File.ReadAllTextAsync("HomePage.json");
            var result = JsonConvert.DeserializeObject<HomeItems>(config);

            return result;
        }

        public async Task<AuthorPageInfo?> GetAuthorDesc()
        {
            var config = await File.ReadAllTextAsync("AutorPage.json");
            var result = JsonConvert.DeserializeObject<AuthorInfo>(config);
            return new AuthorPageInfo()
            {
                Name = result.Name,
                Age = result.Age,
                Languages = result.Languages,
                Description = "Мой любимый цвет - " + result.FavColor
                + ". Вещи которые мне нравятся: " + result.Like
                + " и вещи, которые мне не нравятся: " + result.NotLike + " " + result.Description + "."
            };
        }

      
    }
}
