using System.Threading.Tasks;
using System.Web.Mvc;
using WebApiProject.Controllers.Api;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    //http://www.dotnetcurry.com/aspnet/1192/aspnet-web-api-async-calls-mvc-wpf
    public class HomeController : Controller
    {
        KnockKnockController kctor;
        public HomeController()
        {
            kctor = new KnockKnockController();
        }
        [HttpGet]
        public ActionResult Index()
        {
            SwaggerModel model = new SwaggerModel();
            return View(model);
        }

        [HttpPost]
        [AsyncTimeout(150)]
        [HandleError(ExceptionType = typeof(System.TimeoutException),
                                    View = "TimeoutError")]
        public async Task<ActionResult> Index(SwaggerModel model)
        {
            if (model != null)
            {       
                return View("Index", await GetResult(model));
            }
            return View(new SwaggerModel());
        }

        public ActionResult About()
        {  
            return View();
        }



        /// <summary>
        /// Get Result From Knock Knock readify API
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private async Task<SwaggerModel> GetResult(SwaggerModel model)
        {
            if (model != null)
            {
                if (model.Fibonacci.HasValue)
                {
                    model.FibonacciResult = await kctor.GetFibonacci(model.Fibonacci.GetValueOrDefault());                    
                }

                if (!string.IsNullOrEmpty(model.ReverseWords))
                {
                    model.ReverseWordsResult = await kctor.GetReverseWords(model.ReverseWords);
                }

                if (model.GetToken)
                {
                    model.TokenResult = await kctor.GetToken();
                }

                if (model.TriangleType_a.HasValue && model.TriangleType_b.HasValue && model.TriangleType_c.HasValue)
                {
                    model.TriangleTypeResult = await kctor.GetTriangleType(model.TriangleType_a.GetValueOrDefault(), model.TriangleType_b.GetValueOrDefault(), model.TriangleType_c.GetValueOrDefault());
                }
            }
            return model;
        }
    }
}