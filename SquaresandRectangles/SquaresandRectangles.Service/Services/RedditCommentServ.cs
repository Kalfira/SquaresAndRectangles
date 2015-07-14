using Newtonsoft.Json;
using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Modules.Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresandRectangles.Service.Services
{
    public class RedditCommentServ
    {
        readonly RestClient _client = new RestClient("http://reddit.com/");
        public UniversalReport GetComments(string perma)
        {
            perma = perma + ".json";
            var result = _client.MakeRequest(perma);
            var deserialized = JsonConvert.DeserializeObject<List<redditCommentsJson>>(result);
            UniversalReport report = new UniversalReport();
            report.UniversalItems.Add(new UniversalItem
            {
                Content = deserialized[0].data.children[0].data.url,
                InfoList = new List<IUniversalItemInfo>{ new UniversalItemInfo
                        {
                            Data = deserialized[0].data.children[0].data.author,
                            Name = deserialized[0].data.children[0].data.title
                        }},
                PostType = "r",
                VoteFunctions = "Reddit"

            });
            foreach (var item in deserialized[1].data.children)
            {
                var newItem = new UniversalItem
                {
                    Content = item.data.body,
                    InfoList = new List<IUniversalItemInfo>{ new UniversalItemInfo
                                {
                                    Data = item.data.score.ToString(),
                                    Name = item.data.author,
                                }},
                    PostType = "r",
                    VoteFunctions = "Reddit"
                };
                report.UniversalItems.Add(newItem);

                //var newItem = new redditCommentsChildData
                //{
                //    author = item.data.author,
                //    body = item.data.body,
                //    subreddit = item.data.subreddit,
                //    ups = item.data.ups,
                //    PostType = "r/c"
                //};




                //report.UniversalItems.Add(superitem);
            }

            return report;
        }
    }
}

