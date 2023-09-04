using Microsoft.AspNetCore.Mvc;

namespace Tiktaktoe.ViewComponents
{
    public class JoinAFriendViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
