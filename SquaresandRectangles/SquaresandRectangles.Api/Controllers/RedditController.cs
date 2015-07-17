using Newtonsoft.Json.Linq;
using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    [RoutePrefix("r")]
    public class RedditController : ApiController
    {
        private readonly RedditService _reddit = new RedditService();
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

        [HttpPost]
        [Route("login")]
        public UniversalItem Login([FromBody]JArray creds)
        {
            var user = creds[0].ToString();
            var pass = creds[1].ToString();
            var results = _reddit.Login(user, pass);
            var ret = new UniversalItem
            {
                Content = "Reddit",
                InfoList = new List<IUniversalItemInfo>
                {
                    new UniversalItemInfo {Name = "Modhash", Data = results.Modhash},
                    new UniversalItemInfo{Name = "URL", Data= "#/demo"}
                },
                PostType = null,
                VoteFunctions = null
            };
            return ret;
        }


    }
}
