using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zed.Domain.Models;

namespace Zed.Logic.Services
{
    public class UrlService
    {
        static RestClient client = new RestClient();
        public static string GetDemo(string Url)
        {
            var result = client.MakeRequest(Url);
            var deserialized = JsonConvert.DeserializeObject<RedditDemo>(result);
            return "Demo Done!";
        }
    }
}
