using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Services;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    public class RedditController : ApiController
    {
        readonly UrlService _service = new UrlService();

        public string Get()
        {
            return "You didn't provide a subreddit to check!";
        }
        public UniversalReport Get(string id)
        {
            var results = _service.GetDemo(id);
            return results;
        }
    }
}
