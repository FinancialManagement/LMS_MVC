using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult GetUser()
        {
            return View();
        }
        public IActionResult LMS_LayUI(string name)
        {
            ViewBag.name = name;
            return View();
        }
        public IActionResult UptUser(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult GetRoleInfo()
        {
            return View();
        }
        public IActionResult GetLog()
        {
            return View();
        }
    }
}
