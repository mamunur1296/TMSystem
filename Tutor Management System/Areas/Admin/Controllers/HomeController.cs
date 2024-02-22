using Microsoft.AspNetCore.Mvc;

namespace Tutor_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
