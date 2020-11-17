using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YTClickGuesserV2.Models;

namespace YTClickGuesserV2.Utilities
{
    public class APIClient : IAPIClient
    {
        private readonly HttpClient client;
        string apiKey = "AIzaSyD2FExiezHwVEcCeVj_yLQtC1l2DDFt6Q0";

        public APIClient(HttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }
        public async Task<int> GetViewCount(string videoId)
        {
            string json = await client.GetStringAsync("youtube/v3/videos?part=statistics&id=" + videoId + "&key=" + apiKey);
            var data = (JObject)JsonConvert.DeserializeObject(json);
            int viewCount = data["items"][0]["statistics"]["viewCount"].Value<int>();
            return viewCount;
        }
    }
}
