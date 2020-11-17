using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YTClickGuesserV2.Models
{
    public class VideoViewModel
    {
        public string VideoId { get; set; }
        public int Player1Guess { get; set; }
        public int Player2Guess { get; set; }

        public VideoViewModel()
        {

        }
    }
}
