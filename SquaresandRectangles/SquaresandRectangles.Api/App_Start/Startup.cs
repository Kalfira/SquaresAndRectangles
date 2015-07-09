using Microsoft.Owin;
using Owin;
using SquaresandRectangles.Api;
using SquaresandRectangles.Service.Identity;

[assembly: OwinStartup(typeof(Startup))]

namespace SquaresandRectangles.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            StartIdentity.ConfigureAuth(app);
        }
    }
}