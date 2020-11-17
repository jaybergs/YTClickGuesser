using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YTClickGuesserV2.Utilities
{
    public class VideoGenerator : IVideoGenerator
    {
        private readonly IClient client;

        public VideoGenerator(IClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<string> Generate()
        {
            int searchLength = 5;

            char[] possibleChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

            //Console.Write(siteData);
            List<string> videoIds = await LinkSearcher(searchLength, possibleChars);
            Random rnd = new Random();
            string video = videoIds[rnd.Next(0, videoIds.Count)];
            return video;

        }

        public async Task<string> Search(int searchLength, char[] possibleChars)
        {
            Random rnd = new Random();
            string searchString = "";
            for (int i = 0; i < searchLength; i++)
            {
                searchString += possibleChars[rnd.Next(0, possibleChars.Length)];
            }
            string siteData = await client.GetAsync(searchString);
            Console.WriteLine("Searched for " + searchString + "\n\n");
            return siteData;
        }

        public async Task<List<string>> LinkSearcher(int searchLength, char[] possibleChars)
        {
            List<string> videoIds = new List<string>();
            do
            {
                string siteData = await Search(searchLength, possibleChars);
                if (siteData.Contains("watch?v="))
                {
                    foreach (Match match in Regex.Matches(siteData, "watch\\?v="))
                    {
                        videoIds.Add(siteData.Substring(match.Index + 8, 11));
                    }
                }
            } while (videoIds.Count <= 0);

            return videoIds;
        }
    }
}
