using Newtonsoft.Json;
using Zed.Service.Models;

namespace Zed.Service.Services
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
