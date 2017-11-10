using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trails4Health.Controllers
{
    public class InsertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Read()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}