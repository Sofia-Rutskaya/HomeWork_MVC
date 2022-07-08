namespace HomeWork1.ViewModels
{
    public class CatalogIllustrations<T>
    {
        public int PageSize { get; init; }
        public int CurrentPage { get; init; }
        public int TotalPages { get; init; }
        public int Count { get; init; }
        public List<T> Items { get; init; } = null!;
    }
}
