using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using Zed.Presentation.Web.Models;
using Zed.Presentation.Web.Repositories;

namespace Zed.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var result = await UniversalResponseRepository.GetJsonAsync<UniversalResponse>("thingsjohnsnowknows");
            //var json = JsonConvert.DeserializeObject<UniversalResponse>(result);

            return View(result);
        }




    }
}
