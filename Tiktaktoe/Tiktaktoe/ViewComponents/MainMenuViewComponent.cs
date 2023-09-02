using Microsoft.AspNetCore.Mvc;

namespace Tiktaktoe.ViewComponents
{
    public class MainMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
