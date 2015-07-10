using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Modules.Reddit.Models;

namespace SquaresandRectangles.Service.Services
{
    public class SubredditService
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
                report.UniversalItems.Add(new UniversalItem
                {
                    Content = item.data.url,
                    InfoList = item.data.title,
                    VoteFunctions = "Reddit"
                });
            }
            return report;
        }
    }
}
