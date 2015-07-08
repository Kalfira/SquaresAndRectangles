using Newtonsoft.Json;
using Zed.Service.Models;
using Zed.Service.Modules.Reddit.Models;

namespace Zed.Service.Services
{
    public class UrlService
    {
        readonly RestClient _client = new RestClient("http://reddit.com/r/");
        public UniversalReport GetDemo(string url)
        {
            url = url + "/about/moderators.json";
            var result = _client.MakeRequest(url);
            var deserialized = JsonConvert.DeserializeObject<RedditDemo>(result);
            UniversalReport report = new UniversalReport();
            foreach (var item in deserialized.data.children)
            {
                report.UniversalItems.Add(new UniversalItem
                {
                    Content = item.name,
                    InfoList = item.mod_permissions,
                    VoteFunctions = "Reddit"
                });
            }
            
            //var reserialized = JsonConvert.SerializeObject(report);
            return report;
        }
    }
}
