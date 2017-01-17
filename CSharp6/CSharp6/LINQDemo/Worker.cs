using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace CSharp6.LINQDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            List<int> serialnum = new List <int>(){ 2,7,3,13, 5, 8,16};

            var smallernum = from num in serialnum
                             where num < 8
                             select num;

            foreach (var item in smallernum)
            {
                Write(item);
            }

            WriteLine("\n-------\n");


            var smallnum2 = serialnum
                            .Where(n => n < 8)
                            .Select(n => n);

            foreach (var item in smallnum2)
            {
                Write(item);
            }

            WriteLine("\n-------\n");
            var methods = from method in typeof(int).GetMethods()
                         orderby method.Name
                         group method by method.Name into groups
                         select new { methodName = groups.Key,
                         methodoverriding = groups.Count()};


            foreach (var item in methods)
            {
                WriteLine(item);
            }

            WriteLine("Task 5");
            WriteLine("\n-------\n");
            var take5 = serialnum.Take(5).Select(x => x * 10);
            foreach (var item in take5)
            {
                Write($"{item} ,");
            }

            WriteLine("Zip Demo");
            WriteLine("\n-------\n");
            List<string> codes = new List<string> { "AL", "AK", "AZ", "AR", "CA", "CO", "CT" };
            List<string> states = new List<string> { "Alabama", "Alaska", "Arizona", "Califonia", "Colorado", "Connecticut" };

            var codeWithState = codes.Zip(states, (code, state) => $"{code} : {state}");

            foreach (var item in codeWithState)
            {
                WriteLine($"{item}");
            }

        }
    }
}
