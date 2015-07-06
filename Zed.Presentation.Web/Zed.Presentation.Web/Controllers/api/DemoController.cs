using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zed.Logic.Services;

namespace Zed.Presentation.Web.Controllers.api
{
    public class DemoController : ApiController
    {

        [HttpPost]
        [Route("api/url")]
        public string Post(string Url)
        {
            string result = UrlService.GetDemo(Url);
            return result;
        }
    }
}
