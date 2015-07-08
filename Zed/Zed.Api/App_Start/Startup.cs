using Microsoft.Owin;
using Owin;
using Zed.Api;
using Zed.Service.Identity;

[assembly: OwinStartup(typeof(Startup))]

namespace Zed.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            StartIdentity.ConfigureAuth(app);
        }
    }
}