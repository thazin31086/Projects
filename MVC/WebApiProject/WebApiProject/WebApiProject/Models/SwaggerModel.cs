namespace WebApiProject.Models
{
    public class SwaggerModel
    {
        public long? Fibonacci { get; set; }
        public string ReverseWords { get; set; }  
        public bool GetToken { get; set; }  
        public int? TriangleType_a { get; set; }
        public int? TriangleType_b { get; set; }
        public int? TriangleType_c { get; set; }

        #region Result
        public string FibonacciResult { get; set; }
        public string ReverseWordsResult { get; set; }
        public string TokenResult { get; set; }
        public string TriangleTypeResult { get; set; }

        #endregion

    }
}