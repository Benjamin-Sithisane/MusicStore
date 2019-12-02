using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebWeek4.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Oh? You're Approaching Me?";
        }

        public IActionResult Dio()
        {
            ViewBag.Age = 26;
            ViewData["name"] = "Benjamin Sithisane";
            ViewBag.School = "EdgeTechAcademy";
            return View();
        }
    }
}