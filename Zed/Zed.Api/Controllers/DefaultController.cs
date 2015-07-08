using System.Web.Http;

namespace Zed.Api.Controllers
{
    public class DefaultController : ApiController
    {
        public string Get()
        {
            return "Hello!";
        }
    }
}
