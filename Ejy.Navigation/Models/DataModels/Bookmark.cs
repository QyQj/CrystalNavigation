namespace Ejy.Navigation.Models.DataModels
{
    public class Bookmark()
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Emoji { get; set; }

        public string CustomIconUrl { get; set; }

        public string Note { get; set; }

        public string IconUrl(string api)
        {
            return string.IsNullOrWhiteSpace(CustomIconUrl)
                ? api.EndsWith("/") 
                    ? api + Url.Replace("https://","").Replace("http://", "")
                    : api + "/" + Url.Replace("https://", "").Replace("http://", "")
                : CustomIconUrl;
        }
    }
}