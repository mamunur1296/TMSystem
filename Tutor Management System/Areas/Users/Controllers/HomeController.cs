using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TMS.DataAccesLayer.Infrastructure.IRepository;
using TMS.Models.ViewModels;

namespace Tutor_Management_System.Areas.Users.Controllers
{
    [Area("Users")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
        public IActionResult Contact(ContactViewModel contactviewModel)
        {
            if(contactviewModel.Contact != null)
            {
                _unitOfWork.ContactInfoRepo.Add(contactviewModel.Contact);
                _unitOfWork.Save();
                ModelState.Clear();
                ViewBag.ConfirmMessage = "Your Message successfully Send !";
            }
            return View();
        }

    }
}
