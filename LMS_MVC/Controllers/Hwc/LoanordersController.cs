using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers.Hwc
{
    public class LoanordersController : Controller
    {
        public IActionResult GetDing()
        {
            return View();
        }
        public IActionResult GetLonOrders()
        {
            return View();
        }
        public IActionResult GetBillList()
        {
            return View();
        }
        public IActionResult FTDing(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult FTFang(int id)
        {
            ViewBag.id1 = id;
            return View();
        }
    }
}
