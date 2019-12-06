using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DSC2.Models;


namespace DSC2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HowItWorks()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult GetStarted()
        {
            ViewData["Message"] = "Your get started page.";

            return View();
        }

        [HttpGet]
        public IActionResult Products()
        {
            ViewData["Message"] = "Your products page.";

            return View("Products");
        }

        [HttpPost]
        public ViewResult Products(Box1 box)
        {

                Repository.AddResponse(box);
                return View("Thanks", box);

            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your about page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Terms()
        {
            ViewData["Message"] = "Your terms page.";

            return View();
        }

        public IActionResult Gift()
        {
            ViewData["Message"] = "Your Gift A Penny page.";

            return View();
        }

        public IActionResult Login1()
        {
            ViewData["Message"] = "Your Login page.";

            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your Login page.";

            return View();
        }

        public IActionResult Box()
        {
            ViewData["Message"] = "Your Box page.";

            return View(model: Repository.Responses);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
