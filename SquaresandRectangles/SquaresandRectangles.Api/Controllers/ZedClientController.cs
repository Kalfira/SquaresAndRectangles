using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Services;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    [RoutePrefix("z")]
    public class ZedClientController : ApiController
    {
        private ZedService _service = new ZedService();
        [Route("")]
        public UniversalReport Get()
        {
            return _service.ZedDemo("http://localhost:1337/zed/key");
        }

        [Route("save")]
        public string Save()
        {

            return "Not Implimented";
        }

        // POST: api/ZedClient
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ZedClient/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ZedClient/5
        public void Delete(int id)
        {
        }
    }
}
