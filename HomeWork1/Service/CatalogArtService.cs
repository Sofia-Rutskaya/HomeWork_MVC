using HomeWork1.Service.Interface;
using Newtonsoft.Json;
using HomeWork1.Models;

namespace HomeWork1.Service
{
    public class CatalogArtService : ICatalogArtService
    {
        private readonly ILogger _logger;
        public CatalogArtService(ILogger<CatalogArtService> logger)
        {
            _logger = logger;
        }


        public HomeItems? GetHomePageInfo()
        {
            var config = File.ReadAllText("CatalogArt.json");
            var result = JsonConvert.DeserializeObject<HomeItems>(config);

            return result;
        }
    }
}
