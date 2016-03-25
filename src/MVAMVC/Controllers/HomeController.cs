using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVAMVC.Models;

namespace MVAMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Foo()
        {
            return "Returning Foo";
        }

        [HttpPost]
        public IActionResult About(User newuser)
        {
            return View(newuser);
        }

        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "This text is from HomeController.cs";

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
    }
}
