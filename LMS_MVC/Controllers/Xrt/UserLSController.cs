using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers.Xrt
{
    public class UserLSController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Regin()
        {
            return View();
        }
        public IActionResult ShenQing()
        {
            return View();
        }
        public IActionResult UpdShengQ(string a,string b,string c,string d)
        {
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
            ViewBag.d = d;
            return View();
        }

        public IActionResult AddDing()
        {
            return View();
        }
    }
}
