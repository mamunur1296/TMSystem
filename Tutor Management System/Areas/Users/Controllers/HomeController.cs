using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TMS.DataAccesLayer.Infrastructure.IRepository;
using TMS.DataAccesLayer.Service;
using TMS.Models;
using TMS.Models.ViewModels;

namespace Tutor_Management_System.Areas.Users.Controllers
{
    [Area("Users")]
    public class HomeController : Controller
    {
        private readonly IServices<ContactInfo> _services;

        public HomeController(IServices<ContactInfo> services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [IgnoreAntiforgeryToken]
        [Authorize]
        public IActionResult Contact(ContactInfo ContactInfo)
        {
            if(ContactInfo != null)
            {
                _services.Create(ContactInfo);
                ModelState.Clear();
                ViewBag.ConfirmMessage = "Your Message successfully Send !";
            }
            return View();
        }

    }
}
