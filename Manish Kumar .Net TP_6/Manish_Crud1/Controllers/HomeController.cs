using Manish_Crud1.DB_Context;
using Manish_Crud1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Manish_Crud1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            List<Manish> model = new List<Manish>();
            MASContext context = new MASContext();
            var tab = context.Ms2s.ToList();
            foreach (var item in tab)
            {
                model.Add(new Manish
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Mobile = item.Mobile,
                    Email = item.Email,
                    Zipcode = item.Zipcode
                });
            }
            ViewBag.GetValue = model;
            return View();
        }

        [HttpGet]
        public IActionResult AddForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddForm(Manish model)
        {
            MASContext context = new MASContext();
            Ms2 table = new Ms2();
            table.Id = model.Id;
            table.FirstName = model.FirstName;
            table.LastName = model.LastName;
            table.Mobile = model.Mobile;
            table.Email = model.Email;
            table.Zipcode = model.Zipcode;
            if (model.Id == 0)
            {
                context.Ms2s.Add(table);
                context.SaveChanges();
                TempData["Add"] = "Added successfully";
            }
            else
            {
                context.Entry(table).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                TempData["Update"] = "Updated successfully";

            }
            return RedirectToAction("Table");
        }

        public IActionResult Edit(int id)
        {
            Manish model = new Manish();
            MASContext context = new MASContext();
            var edit = context.Ms2s.Where(m => m.Id == id).FirstOrDefault();
            model.Id = edit.Id;
            model.FirstName = edit.FirstName;
            model.LastName = edit.LastName;
            model.Mobile = edit.Mobile;
            model.Email = edit.Email;
            model.Zipcode = edit.Zipcode;


            return View("Table", model);
        }
        public IActionResult Delete(int id)
        {
            MASContext context = new MASContext();

            var del = context.Ms2s.Where(m => m.Id == id).FirstOrDefault();
            context.Entry(del).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Table");
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(Manish1 model)
        {
            MASContext context = new MASContext();
            var login = context.Ms1s.Where(m => m.Email == model.Email).FirstOrDefault();
            if (login == null)
            {
                TempData["invalidId"] = "Wrong E-Mail";
            }
            else
            {
                if (login.Email == model.Email && login.Password == model.Password)
                {
                    var Claims = new[] { new Claim(ClaimTypes.Name, login.Name), new Claim(ClaimTypes.Email, login.Email) };
                    var idenity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authPro = new AuthenticationProperties { IsPersistent = true };
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(idenity), authPro);
                    HttpContext.Session.SetString("Name", login.Name);
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["invalidPass"] = "Wrong password";
                    return View();
                }
            }
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
