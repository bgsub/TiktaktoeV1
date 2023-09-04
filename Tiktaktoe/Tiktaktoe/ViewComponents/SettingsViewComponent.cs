using Microsoft.AspNetCore.Mvc;

namespace Tiktaktoe.ViewComponents
{
    public class SettingsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
