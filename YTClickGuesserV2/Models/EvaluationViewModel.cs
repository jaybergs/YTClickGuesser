using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YTClickGuesserV2.Models
{
    public class EvaluationViewModel
    {
        public int ViewCount { get; set; }
        public int Player1Guess { get; set; }
        public int Player2Guess { get; set; }
        public string WinnerMessage { get; set; }
        public string Redirect { get; set; }
    }
}
