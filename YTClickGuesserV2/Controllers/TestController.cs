using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YTClickGuesserV2.Models;

namespace YTClickGuesserV2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            TestModel testModel = new TestModel();
            return View(testModel);
        }
    }
}
