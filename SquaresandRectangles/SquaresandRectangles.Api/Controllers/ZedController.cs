using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    public class ZedController : ApiController
    {
        // GET: api/Zed
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Zed/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Zed
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Zed/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Zed/5
        public void Delete(int id)
        {
        }
    }
}
