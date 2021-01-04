using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo03.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetContent()
        {
            return Content("This is My Content");
        }


        public IActionResult GetJson()
        {
            var data = new { id = 5, name = "reza" };
            return Json(data);
        }

        public string GetContent2()
        {
            return "This is My Content";
        }

        public int GetContent3()
        {
            return 2;
        }

        public void Save()
        {

        }
    }
}