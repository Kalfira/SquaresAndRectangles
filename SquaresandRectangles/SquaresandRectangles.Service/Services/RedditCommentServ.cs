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
            readonly RestClient _client = new RestClient("http://reddit.com");
            public UniversalReport GetComments(string perma)
            {
                perma = perma + ".json";
                var result = _client.MakeRequest(perma);
                var deserialized = JsonConvert.DeserializeObject<redditCommentsJson>(result);
                UniversalReport report = new UniversalReport();
                foreach (var item in deserialized.data.children)
                {
                    var newItem = new redditCommentsChildData
                    {
                        author = item.data.author,
                        body = item.data.body,
                        subreddit = item.data.subreddit,
                        ups = item.data.ups,
                        PostType = "r/c"
                    };


                    report.UniversalItems.Add(newItem);

                    //report.UniversalItems.Add(superitem);
                }

                return report;
            }
        }
    }

