using Ejy.Navigation.Models.DataModels;
using Ejy.Navigation.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Ejy.Navigation.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IOptionsMonitor<BookmarkConfig> bookmarkconfigMonitor) : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeModel()
            {
                BookmarkConfig = bookmarkconfigMonitor.CurrentValue
            });
        }
    }
}