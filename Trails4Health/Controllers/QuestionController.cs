using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trails4Health.Models;

namespace Trails4Health.Controllers
{
    public class QuestionController : Controller
    {
        private IQuestionRepository repository;

        public QuestionController(IQuestionRepository repository) {
            this.repository = repository;
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}