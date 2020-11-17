using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YTClickGuesserV2.Models;
using YTClickGuesserV2.Utilities;

namespace YTClickGuesserV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVideoGenerator videoGenerator;
        private readonly IAPIClient apiRequest;

        public HomeController(IVideoGenerator videoGenerator, IAPIClient apiRequest)
        {
            this.videoGenerator = videoGenerator ?? throw new ArgumentNullException(nameof(videoGenerator));
            this.apiRequest = apiRequest ?? throw new ArgumentNullException(nameof(apiRequest));
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("player1Score") == null || HttpContext.Session.GetInt32("player1Score") == null)
            {
                HttpContext.Session.SetInt32("player1Score", 0);
                HttpContext.Session.SetInt32("player2Score", 0);
            }
            string videoID = await videoGenerator.Generate();

            return View(new VideoViewModel
            {
                VideoId = videoID
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
