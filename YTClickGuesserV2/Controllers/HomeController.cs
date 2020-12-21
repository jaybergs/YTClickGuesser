using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YTClickGuesserV2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult Index(int runden)
        {
            HttpContext.Session.SetInt32("rundengesamt", runden);
            return RedirectToAction("Index", "Game");
        }
    }
}
