using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Http;

namespace WebApiProject.Controllers.Api
{
    /// <summary>
    /// Consume Knock Knock readify Web API Service
    /// </summary>
    public class KnockKnockController : ApiController
    {
        public async Task<string> GetFibonacci(long n)
        {
            using (var client = new HttpClient())
            {  
                return await client.GetStringAsync(WebConfigurationManager.AppSettings["SwaggerApi"] + "Fibonacci?n=" + n);
            }
            return "No Result";
        }

        public async Task<string> GetReverseWords(string sentence)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(WebConfigurationManager.AppSettings["SwaggerApi"] + "ReverseWords?sentence=" + sentence);
            }
            return "No Result";
        }

        public async Task<string> GetToken()
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(WebConfigurationManager.AppSettings["SwaggerApi"] + "Token");
            }
            return "No Result";           
        }

        public async Task<string> GetTriangleType(int a, int b, int c)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(WebConfigurationManager.AppSettings["SwaggerApi"] +
                    String.Format("TriangleType?a={0}&b={1}&c={2}", a, b, c));
            }
            return "No Result";
        }
    }
}
