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
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            StartIdentity.ConfigureAuth(app);
        }
    }
}