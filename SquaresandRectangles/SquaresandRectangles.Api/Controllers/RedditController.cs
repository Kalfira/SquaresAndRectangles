using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Services;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    public class RedditController : ApiController
    {
        //readonly UrlService _service = new UrlService();
        readonly SubredditService _subreddit = new SubredditService();
        readonly RedditCommentServ _comment = new RedditCommentServ();

        public string Get()
        {
            return "You didn't provide a subreddit to check!";
        }
        public UniversalReport Get(string id)
        {
            //var results = _service.GetDemo(id);
            var results = _subreddit.GetDemo(id);
            return results;
        }
        //public string GetComment()
        //{
        //    return "No Comments.";
        //}
        //public UniversalReport GetComment(string perma)
        //{
        //    var results = _comment.GetComments(perma);

        //    return results;
        //}
    }
}
