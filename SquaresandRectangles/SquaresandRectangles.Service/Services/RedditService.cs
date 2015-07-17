using Newtonsoft.Json;
using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Modules.Reddit.Models;
using System.Collections.Generic;
using RedditSharp;
using RedditSharp.Things;

namespace SquaresandRectangles.Service.Services
{
    public class RedditService
    {
        //TODO:
        readonly Reddit _reddit = new Reddit();
        readonly RestClient _client = new RestClient();
        public UniversalReport GetDemo(string url)
        {
            url = "http://reddit.com/r/" + url + ".json";
            _client.Method = HttpVerb.GET;
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

        public AuthenticatedUser Login(string username, string password)
        {
            var user = _reddit.LogIn(username, password);
            return user;
        }
    }
}
