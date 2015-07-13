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
            foreach(var item in deserialized.data.children)
            {
                var superitem = new UniversalItem
                {
                    Content = item.data.title,
                    Info1 = item.data.author,
                    Info2 = item.data.url,
                    PostType = "r"
                };

                report.UniversalItems.Add(superitem);
            }
            
            return report;
        }
    }
}
