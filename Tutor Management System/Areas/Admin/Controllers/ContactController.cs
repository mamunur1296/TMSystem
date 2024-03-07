using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TMS.DataAccesLayer.Service;
using TMS.Models;
using TMS.Models.ViewModels;

namespace Tutor_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private readonly IServices<ContactInfo> _services;

        public ContactController(IServices<ContactInfo> services)
        {
            _services = services;
        }
     
        public async Task<IActionResult> Index()
        {
            var rajult =  _services.GetAll();
            return Json(new { data = rajult });
        }
    }
}
