using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMS_MVC.Controllers.ZMM
{
    public class CollectionController : Controller
    {
        //显示
        public IActionResult Show()
        {
            return View();
        }
        //添加
        public IActionResult Add()
        {
            return View();
        }



    }
}
