namespace BlazorApp1.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int[] ArtistId { get; set; }
        public int Price { get; set; }
        //public Song[] Songs { get; set; }
    }

    public class AlbumDto
    {
        public int? Year { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public int[]? ArtistId { get; set; }
        public int? Price { get; set; }
    }
}
