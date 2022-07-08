namespace HomeWork1.ViewModels
{
    public class PaginationInfo
    {
        public string? Previous { get; set; }
        public string? Next { get; set; }
        public int ItemsNum { get; set; }
        public int ItemsPerPage { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

    }
}
