using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC6.OWIN.Startup))]
namespace MVC6.OWIN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
