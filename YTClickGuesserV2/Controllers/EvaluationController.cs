using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using YTClickGuesserV2.Models;
using YTClickGuesserV2.Utilities;

namespace YTClickGuesserV2.Controllers
{
    public class EvaluationController : Controller
    {
        private readonly IAPIClient apiRequest;
        public EvaluationController(IAPIClient apiRequest)
        {
            this.apiRequest = apiRequest ?? throw new ArgumentNullException(nameof(apiRequest));
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(VideoViewModel model)
        {
            int viewCount = await apiRequest.GetViewCount(model.VideoId);

            int player1Difference = Math.Abs(viewCount - model.Player1Guess);
            int player2Difference = Math.Abs(viewCount - model.Player2Guess);

            int? player1Score = HttpContext.Session.GetInt32("player1Score");
            int? player2Score = HttpContext.Session.GetInt32("player2Score");



            string winnerMessage = "";

            if (player1Difference < player2Difference)
            {
                winnerMessage = "Spieler 1 gewinnt mit einer Differenz von " + player1Difference + "!";
                int player1NewScore = (int)player1Score++;
                HttpContext.Session.SetInt32("player1Score", (int)player1Score++);
            }
            else if (player2Difference < player1Difference)
            {
                winnerMessage = "Spieler 2 gewinnt mit einer Differenz von " + player2Difference + "!";
                int player2NewScore = (int)player2Score++;
                HttpContext.Session.SetInt32("player2Score", (int)player2Score++);
            }

            return View(new EvaluationViewModel{
                Player1Guess = model.Player1Guess,
                Player2Guess = model.Player2Guess,
                ViewCount = viewCount,
                WinnerMessage = winnerMessage  
            });
        }
    }
}

