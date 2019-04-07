using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("mymodel/create")]
        public IActionResult Create(MyModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Correct");
            } 
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Correct")]
        public IActionResult Correct()
        {
            return View();
        }

    }
}
