using Microsoft.Owin;
using Owin;
using Zed.Logic.Identity;
using Zed.Presentation.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace Zed.Presentation.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            StartIdentity.ConfigureAuth(app);
        }
    }
}
