using System.Threading.Tasks;
using System.Web.Mvc;
using Zed.Presentation.Web.Models;
using Zed.Presentation.Web.Repositories;

namespace Zed.Presentation.Web.Controllers.Module_Controllers
{
    public class RedditController : Controller
    {

        public async Task<ActionResult> Index()
        {
            string url = "funny";
            var result = await UniversalResponseRepository.GetJsonAsync<UniversalResponse>("api/reddit/" + url);
            return View(result);
        }

        //public async Task<ActionResult> Index(string url)
        //{
        //    var result = await UniversalResponseRepository.GetJsonAsync<UniversalResponse>("api/reddit/"+url);


        //    return View(result);
        //}
    }
}