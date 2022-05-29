using Microsoft.AspNetCore.Mvc;

namespace EliteDangerowsMonitor.Models
{
    public class GameBuscaModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
