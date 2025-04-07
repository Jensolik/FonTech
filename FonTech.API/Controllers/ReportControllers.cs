using Microsoft.AspNetCore.Mvc;

namespace FonTech.API.Controllers
{
    public class ReportControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
