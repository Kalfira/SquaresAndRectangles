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
            var results = _reddit.GetDemo(id);
            return results;
        }


    }
}
