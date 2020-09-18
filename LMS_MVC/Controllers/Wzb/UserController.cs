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
    }
}
