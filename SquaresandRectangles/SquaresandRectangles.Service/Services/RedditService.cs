using RedditSharp;
using RedditSharp.Things;
using SquaresandRectangles.Service.Models;
using System.Collections.Generic;

namespace SquaresandRectangles.Service.Services
{
    public class RedditService
    {
        //TODO:
        readonly Reddit _reddit = new Reddit();
        public UniversalReport GetDemo(string url)
        {
            var sub = _reddit.GetSubreddit("/r/" + url);
            var posts = sub.Posts.GetListing(25);
            UniversalReport report = new UniversalReport();
            foreach (var item in posts)
            {
                var superitem = new UniversalItem
                {
                    Content = item.Url.ToString(),
                    InfoList = new List<IUniversalItemInfo>{ new UniversalItemInfo
                    {
                        Data = item.Title,
                        Name = "Title"
                    }, new UniversalItemInfo
                    {
                        Data = item.AuthorName,
                        Name = "Author",
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
