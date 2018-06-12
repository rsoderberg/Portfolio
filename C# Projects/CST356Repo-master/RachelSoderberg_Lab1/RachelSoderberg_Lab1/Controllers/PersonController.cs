using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RachelSoderberg_Lab1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.BagMessage = "This was written in the PersonController Controller, using ViewBag! Hooray!";

            return View();
        }
    }
}