using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
