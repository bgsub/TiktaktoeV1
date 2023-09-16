using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tiktaktoe.Models;

namespace Tiktaktoe.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public string[] GridSizes = new[] { "3 x 3", "5 x 5" };
        public string[] selectedOpponent = new[] { "A friend", "A Bot" };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var gridSizes = new[]
            {
                "3 x 3",
                "5 x 5"
            };
            var opponentTypes = new[]
            {
                "A friend",
                "A bot"
            };
            ViewData[nameof(gridSizes)] = gridSizes;
            ViewData[nameof(opponentTypes)] = opponentTypes;
            return View();
        }
        [HttpPost]
        public IActionResult GamePage()
        {   
            PlayerModel player = new PlayerModel();
            return View(player);
        }
        public IActionResult Privacy(EventArgs e)
        {
            Console.WriteLine(e.ToString());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}