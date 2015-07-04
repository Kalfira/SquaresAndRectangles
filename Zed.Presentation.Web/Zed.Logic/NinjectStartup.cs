using Ninject.Modules;
using Zed.Data.Repositories;
using Zed.Domain.Models;

namespace Zed.Logic
{
    public class NinjectStartup : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository>().To<GenericRepository>();
        }
    }
}
