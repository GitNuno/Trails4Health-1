using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trails4Health.Models;

namespace Trails4Health.Controllers
{
    public class SignInController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignIn(SignIn model)
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