using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Services;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    [RoutePrefix("r")]
    public class RedditController : ApiController
    {
        readonly RedditService _reddit = new RedditService();
        RedditCommentServ _comment = new RedditCommentServ();

        [Route("")]
        public string Get()
        {
            return "You didn't provide a subreddit to check!";
        }
        [Route("{id}")]
        public UniversalReport Get(string id)
        {
            //var results = _service.GetDemo(id);
            var results = _reddit.GetDemo(id);
            return results;
        }

        [Route("comments")]
        public string GetComment()
        {
            return "No Comments.";
        }
        [Route("comments/{perma}")]
        public UniversalReport GetComment(string perma)
        {
            var results = _comment.GetComments(perma);

            return results;
        }
    }
}
