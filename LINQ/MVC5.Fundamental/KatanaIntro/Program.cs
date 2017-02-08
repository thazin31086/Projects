using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace KatanaIntro
{
    using System.IO;
    using System.Web.Http;
    using AppFunc = Func<IDictionary<string, object>, Task>;
    class Program
    {
        static void Main(string[] args)
        {
            ///Start Katana Sever 
            string uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                WriteLine("started");
                ReadKey();
                WriteLine("Stopping"); 
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseWelcomePage();
            //// return async response
            //app.Run(ctx => { return ctx.Response.WriteAsync("Hello World"); });

            app.UseHelloWorld();
            ConfigureWebApi(app);

        }

        private static void ConfigureWebApi(IAppBuilder app)
        {
            //Control Routing Rules
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            app.UseWebApi(config);
        }
    }
    public static class AppBuilderExtensions
    {       

        public static void UseHelloWorld(this IAppBuilder app)
        {
            //Run Environment Component 
            app.Use(async (environment, next) =>
            {
                foreach (var pair in environment.Environment)
                {
                    WriteLine($"first :: {pair.Key} , {pair.Value}");
                }
                await next();
            });

            //app.Use(async(environment,next) => {

            //    WriteLine($"Requesting : {environment.Request.Path}");
            //    await next();

            //    WriteLine($"Response  : {environment.Response.StatusCode}");

            //});
            ////Run Hello World Component 
            //app.Use<HelloWorldComponent>(); 

            
        }

        
    }
    public class HelloWorldComponent
    {
        AppFunc _next;
        public HelloWorldComponent(AppFunc next)
        {
            _next = next;
        }

        public Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                return writer.WriteAsync("Hello");
            }
        }
    }
}
