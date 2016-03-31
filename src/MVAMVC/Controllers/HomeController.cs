using System;
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

        public IActionResult Foo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> About(RegisterUser model)
        {
            if (ModelState.IsValid)
            {
                /*
                var nau = new ActiveUsers();
                int i = nau.Username.Length;

                nau.Username[i] = model.Email;
                nau.Password[i] = model.Password;
                nau.DateRegistered[i] = model.DateRegistered
                */
                
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "This text is from HomeController.cs";

            var u = new RegisterUser
            {
                DateRegistered = DateTime.Now
            };


            return View(u);
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
