using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5.WebApp.Startup))]
namespace MVC5.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
