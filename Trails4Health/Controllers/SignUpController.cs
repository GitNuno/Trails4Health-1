using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trails4Health.Models;

namespace Trails4Health.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUp(SignUp model)
        {
            if (ModelState.IsValid)
            {
                return View("Finish");
            }
            else
            {
                // There are validation errors
                return View();
            }
        }
    }
}