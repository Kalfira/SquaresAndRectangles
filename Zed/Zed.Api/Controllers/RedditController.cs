using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zed.Service.Models;
using Zed.Service.Services;

namespace Zed.Api.Controllers
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
