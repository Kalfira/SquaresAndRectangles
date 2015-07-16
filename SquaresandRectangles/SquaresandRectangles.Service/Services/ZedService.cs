using Newtonsoft.Json;
using SquaresandRectangles.Data.Models;
using SquaresandRectangles.Data.Repositories;
using SquaresandRectangles.Service.Models;

namespace SquaresandRectangles.Service.Services
{
    public class ZedService
    {
        readonly RestClient _client = new RestClient();
        private IGenericRepository _repo = new GenericRepository();
        public UniversalReport ZedDemo(string url)
        {
            var result = _client.MakeRequest(url);
            var deserialized = JsonConvert.DeserializeObject<UniversalReport>(result);

            return deserialized;
        }

        public void SaveDemo(string sr)
        {
            var result = ZedDemo(sr);
            var thing = new Repo();
            _repo.Add(thing);
        }

        //public UniversalReport ZedGetRepo()
        //{
        //    var repo = new IGenericRepository();
        //    var x = repo.GetRepo();
        //}
    }

}
