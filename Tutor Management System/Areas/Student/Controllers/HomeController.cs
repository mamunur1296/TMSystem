﻿using Microsoft.AspNetCore.Mvc;

namespace Tutor_Management_System.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
