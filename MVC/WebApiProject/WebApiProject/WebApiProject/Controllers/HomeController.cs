using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Mvc;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    //http://www.dotnetcurry.com/aspnet/1192/aspnet-web-api-async-calls-mvc-wpf
    public class HomeController : Controller
    {
        HttpClient client;
        public HomeController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(WebConfigurationManager.AppSettings["SwaggerApi"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet]
        public ActionResult Index()
        {
            SwaggerModel model = new SwaggerModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SwaggerModel model)
        {
            var result = GetResult(model);
            return View(result.Result); 
        }



        public async Task<SwaggerModel> GetResult(SwaggerModel model)
        {
            if (model.Fibonacci.HasValue)
            {
                string str = WebConfigurationManager.AppSettings["SwaggerApi"] + "Fibonacci?n=" + model.Fibonacci;
                HttpResponseMessage responseMessage = await client.GetAsync(WebConfigurationManager.AppSettings["SwaggerApi"] + "Fibonacci?n=" + model.Fibonacci);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                    model.FibonacciResult = JsonConvert.DeserializeObject<string>(responseData);
                }
            }

            if (!string.IsNullOrEmpty(model.ReverseWords))
            {
                HttpResponseMessage responseMessage = await client.GetAsync(WebConfigurationManager.AppSettings["SwaggerApi"] + "ReverseWords?sentence=" + model.ReverseWords);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                    model.ReverseWordsResult = JsonConvert.DeserializeObject<string>(responseData);
                }
            }

            if (model.GetToken)
            {
                HttpResponseMessage responseMessage = await client.GetAsync(WebConfigurationManager.AppSettings["SwaggerApi"] + "Token");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                    model.TokenResult = JsonConvert.DeserializeObject<string>(responseData);
                }
            }

            if (model.TriangleType_a.HasValue && model.TriangleType_b.HasValue && model.TriangleType_c.HasValue)
            {
                HttpResponseMessage responseMessage = await client.GetAsync(WebConfigurationManager.AppSettings["SwaggerApi"] +
                    String.Format("TriangleType?a={0}&b={1}&c={2}",
                    model.TriangleType_a.HasValue, model.TriangleType_b, model.TriangleType_c));

                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                    model.TriangleTypeResult = JsonConvert.DeserializeObject<string>(responseData);
                }
            }
            return model;
        }
    }
}