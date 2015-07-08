using Ninject;
using Zed.Data.Repositories;

namespace Zed.Service.Services
{
    public class DbService : IDbService
    {
        private readonly IGenericRepository _repo;

        public DbService()
        {
            this._repo = new GenericRepository();
        }
        [Inject]
        public DbService(IGenericRepository repo)
        {
            this._repo = repo;
        }
    }


}
