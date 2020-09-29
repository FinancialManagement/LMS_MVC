using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers.ADFinanl
{
    public class ADController : Controller
    {
        public IActionResult FangMoeny()
        {
            return View();
        }

        public IActionResult HuiMoeny()
        {
            return View();
        }

        public IActionResult FengK()
        {
            return View();
        }


        public IActionResult UserLogin()
        {
            return View();
        }


        /// <summary>
        /// 徐壬霆
        /// </summary>
        /// <returns></returns>
        public IActionResult AddDing()
        {
            return View();
        }


        public IActionResult ShenQing()
        {
            return View();
        }
        public IActionResult UpdShengQ(string a, string b, string c, string d)
        {
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
            ViewBag.d = d;
            return View();
        }

    }
}
