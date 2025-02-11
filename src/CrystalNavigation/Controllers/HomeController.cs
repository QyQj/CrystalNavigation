using CrystalNavigation.Models.DataModels;
using CrystalNavigation.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CrystalNavigation.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IOptionsMonitor<BookmarkConfig> bookMarkConfigMonitor) : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeModel()
            {
                BookmarkConfig = bookMarkConfigMonitor.CurrentValue
            });
        }
    }
}