using CMS.App_Start;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CMS
{
    public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start() {
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

      GlobalConfiguration.Configure(WebApiConfig.Register);

      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      HttpConfiguration config = GlobalConfiguration.Configuration;
      //Ignore Self-referencing in Entity Framework
      config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
          
    }
  }
}
