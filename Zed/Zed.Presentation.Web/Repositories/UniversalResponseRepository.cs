using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Zed.Presentation.Web.Repositories
{
    public class UniversalResponseRepository
    {
        public static async Task<T> GetJsonAsync<T>(string url)
        {

            using (var stream = await new HttpClient().GetStreamAsync("http://localhost:57692/api/reddit/" + url))
            using (var sr = new StreamReader(stream))
            using (var jr = new JsonTextReader(sr))
            {
                return new JsonSerializer().Deserialize<T>(jr);
            }
            //using (var client = new HttpClient())
            //{
            //    //Change port
            //    client.BaseAddress = new Uri("http://localhost:57692/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    var response = await client.GetStringAsync("api/reddit/"+entry).ConfigureAwait(false);
            //    return response;
            //};
           
        }

    }
}