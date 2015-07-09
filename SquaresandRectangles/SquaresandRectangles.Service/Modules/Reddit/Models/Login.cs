using Newtonsoft.Json;
using System.Collections.Generic;

namespace SquaresandRectangles.Service.Modules.Reddit.Models
{
    public class redditLoginData
    {
        public string modhash { get; set; }
        public string cookie { get; set; }
    }

    public class redditLoginJson
    {
        public List<object> errors { get; set; }
        [JsonProperty("data")]
        public redditLoginData Storage { get; set; }
    }

    public class redditLogin
    {
        [JsonProperty("json")]
        public redditLoginJson Data { get; set; }
        public string UserHandle { get; set; }
    }
}
