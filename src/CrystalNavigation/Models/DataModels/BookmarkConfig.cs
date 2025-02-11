namespace CrystalNavigation.Models.DataModels
{
    public class BookmarkConfig
    {
        public string IconApiUrl { get; set; }

        public string Title { get; set; }

        public string Slogan { get; set; }

        public List<BookmarkGroup> BookmarkGroups { get; set; }
    }
}