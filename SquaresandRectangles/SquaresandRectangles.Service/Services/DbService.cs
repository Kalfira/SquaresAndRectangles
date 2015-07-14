using Ninject;
using SquaresandRectangles.Data.Repositories;

namespace SquaresandRectangles.Service.Services
{
    public class DbService : IDbService
    {
        private readonly IGenericRepository _repo;

        public DbService()
        {
            _repo = new GenericRepository();
        }
        [Inject]
        public DbService(IGenericRepository repo)
        {
            _repo = repo;
        }

    }


}
