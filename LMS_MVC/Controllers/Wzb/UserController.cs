using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers.Wzb
{
    public class UserController : Controller
    {
        public IActionResult KeIndex()
        {
            return View();
        }
        public IActionResult AddIndex()
        {
            return View();
        }
        public IActionResult ChaIndex()
        {
            return View();
        }
        public IActionResult DIndex1()
        {
            return View();
        }
        public IActionResult XIndex1(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult XIndex2(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult XIndex3(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult XIndex4(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
