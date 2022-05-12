using Manish.NetFile.DB_Context;
using Manish.NetFile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Manish.NetFile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private int id;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.a = "I Am Manish";
            ViewBag.a1 = 120;
            ViewBag.a2 = 20.0;
            ViewBag.a3 = DateTime.Now;
            ViewBag.a4 = "Smile Please";
            ViewBag.List = new List<string>()
            {
                "India",
                "Pakistan",
                "USA",
            };

            ViewData["a"] = "I Am Manish";
            ViewData["a1"] = 120;
            ViewData["a2"] = 20.0;
            ViewData["a3"] = DateTime.Now;
            ViewData["a4"] = "Smile Please";
            ViewData["List"] = new List<string>()
            {
                "India",
                "Pakistan",
                "USA",
            };

            TempData["a"] = "I Am Manish";
            TempData["a1"] = 120;
            TempData["a2"] = 20.0;
            TempData["a3"] = DateTime.Now;
            TempData["a4"] = "Smile Please";
            TempData["List"] = new List<string>()
            {
                "India",
                "Pakistan",
                "USA",
            };
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult table()
        {
            MASContext obj = new MASContext();
            var set = obj.Ms2s.ToList();
            return View(set);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
