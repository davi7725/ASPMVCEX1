using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPMVCEX1.Models;

namespace ASPMVCEX1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Page1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Page1(Person post)
        {
            HttpContext.Session.Set("sessionPerson", post);
            return View();
        }

        public IActionResult Page2()
        {
            Person p = HttpContext.Session.Get<Person>("sessionPerson");

            ViewData["FName"] = p.FName;
            ViewData["LName"] = p.LName;
            ViewData["Birthday"] = p.Birthday;
            ViewData["Email"] = p.Email;
            ViewData["PhoneNr"] = p.PhoneNr;

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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
