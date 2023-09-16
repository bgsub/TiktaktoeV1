using Microsoft.AspNetCore.Mvc;
using Tiktaktoe.Models;

namespace Tiktaktoe.ViewComponents
{
    public class ClassicMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PlayerModel player = new PlayerModel();
            return View(player);
        }
    }
}
