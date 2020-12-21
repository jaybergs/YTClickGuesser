using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YTClickGuesserV2.Models;

namespace YTClickGuesserV2.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult Index()
        {
            string winner = "";
            if (HttpContext.Session.GetInt32("player1Score") > HttpContext.Session.GetInt32("player2Score"))
            {
                winner = "Spieler 1";
            }
            else if (HttpContext.Session.GetInt32("player2Score") > HttpContext.Session.GetInt32("player1Score"))
            {
                winner = "Spieler 2";
            }

            return View(new ResultViewModel
            {
                Winner = winner
            });
        }
    }
}
