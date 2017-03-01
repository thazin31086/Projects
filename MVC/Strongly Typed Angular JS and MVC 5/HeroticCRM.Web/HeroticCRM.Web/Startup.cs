using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeroticCRM.Web.Startup))]
namespace HeroticCRM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
