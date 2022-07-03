namespace HomeWork1.Models
{
    public class CatalogArtItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public string Currency { get; set; } = null!;
        public string? Description { get; set; }
        public string? Time { get; set; }
        public string PictureUrl { get; set; } = null!;
    }

}
