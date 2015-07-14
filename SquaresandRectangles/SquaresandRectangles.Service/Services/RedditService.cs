using Newtonsoft.Json;
using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Modules.Reddit.Models;
using System.Collections.Generic;

namespace SquaresandRectangles.Service.Services
{
    public class RedditService
    {
        readonly RestClient _client = new RestClient("http://reddit.com/r/");
        public UniversalReport GetDemo(string url)
        {
            url = url + ".json";
            var result = _client.MakeRequest(url);
            var deserialized = JsonConvert.DeserializeObject<redditJson>(result);
            UniversalReport report = new UniversalReport();
            foreach (var item in deserialized.data.children)
            {
                var superitem = new UniversalItem
                {
                    Content = item.data.url,
                    InfoList = new List<IUniversalItemInfo>{ new UniversalItemInfo
                    {
                        Data = item.data.subreddit,
                        Name = item.data.title,
                    }},
                    PostType = "r",
                    VoteFunctions = "Reddit"
                };

                report.UniversalItems.Add(superitem);
            }

            return report;
        }
    }
}
