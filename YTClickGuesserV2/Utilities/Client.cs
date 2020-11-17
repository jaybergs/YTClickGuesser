using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace YTClickGuesserV2.Utilities
{
    public class Client : IClient
    {
        private readonly HttpClient client;

        public Client(HttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }
        public async Task<string> GetAsync(string search)
        {
            using(HttpResponseMessage response = await client.GetAsync("results?search_query=" + search))
            {
                if (response.IsSuccessStatusCode)
                {
                    string siteData = await response.Content.ReadAsStringAsync();
                    return siteData;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
