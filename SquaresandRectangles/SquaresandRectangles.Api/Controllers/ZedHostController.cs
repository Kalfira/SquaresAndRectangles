using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    [RoutePrefix("zed")]
    public class ZedHostController : ApiController
    {
        string key = "key";
        // GET: api/ZedHost
        [Route("")]
        public string Get()
        {
            //TODO: Provide public key
            return key;
        }
        [Route("{val}")]
        // GET: api/ZedHost/5
        public bool Get(string val)
        {
            if (val == key)
            {
                return true;
            }
            return false;
        }

        // POST: api/ZedHost
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ZedHost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ZedHost/5
        public void Delete(int id)
        {
        }
    }
}
