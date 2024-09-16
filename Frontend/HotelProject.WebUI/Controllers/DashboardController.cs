using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
