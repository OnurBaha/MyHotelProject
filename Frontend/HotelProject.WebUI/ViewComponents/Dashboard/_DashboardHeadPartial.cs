using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardHeadPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
