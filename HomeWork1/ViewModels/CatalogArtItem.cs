﻿namespace HomeWork1.ViewModels
{
    public class CatalogArtItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public string? Time { get; set; }
        public string PictureUrl { get; set; } = null!;
    }

}
