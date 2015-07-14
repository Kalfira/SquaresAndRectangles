using Newtonsoft.Json;
using SquaresandRectangles.Data.Repositories;
using SquaresandRectangles.Service.Models;

namespace SquaresandRectangles.Service.Services
{
    public class ZedService
    {
        readonly RestClient _client = new RestClient();
        public UniversalReport ZedDemo(string url)
        {
            var result = _client.MakeRequest(url);
            var deserialized = JsonConvert.DeserializeObject<UniversalReport>(result);

            return deserialized;
        }

        public UniversalReport ZedGetRepo()
        {
            var repo = new IGenericRepository();
            var x = repo.GetRepo();
        }
    }

}
