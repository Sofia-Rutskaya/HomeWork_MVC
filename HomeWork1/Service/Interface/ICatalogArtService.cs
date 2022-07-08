using HomeWork1.ViewModels;
using HomeWork1.ViewModels;

namespace HomeWork1.Service.Interface
{
    public interface ICatalogArtService
    {
        Task<HomeItems?> GetHomePageInfo();
        Task<AuthorPageInfo?> GetAuthorDesc();
        Task<List<CatalogArtItem>?> GetPagesInfo(int pageSize, int pageNums);
    }
}
