using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers.ZMM
{
    public class RecordController : Controller
    {

        public IActionResult Show()
        {
            ViewBag.id4 = 2;
            return View();
        }
        public IActionResult Add()
        {
      
            return View();
        }



    }
}
