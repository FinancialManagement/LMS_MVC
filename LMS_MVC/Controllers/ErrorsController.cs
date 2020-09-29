using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace LMS_MVC.Controllers
{
    public class ErrorsController : Controller
    {
        [Obsolete]
        private IHostingEnvironment _env;

        [Obsolete]
        public ErrorsController(IHostingEnvironment env)
    {
        _env = env;
    }

    [Route("errors/{statusCode}")]
        [Obsolete]
        public IActionResult CustomError(int statusCode)
    {
        var filePath = $"{_env.WebRootPath}/errors/{(statusCode == 404?404:500)}.html";
        return new PhysicalFileResult(filePath, new MediaTypeHeaderValue("text/html"));
    }   
    }
}
