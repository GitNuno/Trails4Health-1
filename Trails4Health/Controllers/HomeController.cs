﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trails4Health.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult InsertTrail() {
            return View();
        }
        public IActionResult Signin() {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Historical() {
            return View();
        }
        public IActionResult Question() {
            return View();
        }
        public IActionResult Achievements() {
            return View();  
        }
    }
}
