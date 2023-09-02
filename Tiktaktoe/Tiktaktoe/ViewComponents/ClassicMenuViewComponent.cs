using Microsoft.AspNetCore.Mvc;

namespace Tiktaktoe.ViewComponents
{
    public class ClassicMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
