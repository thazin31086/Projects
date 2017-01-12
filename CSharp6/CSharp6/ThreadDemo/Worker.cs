using System;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp6.ThreadDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            AsyncClass aclass = new AsyncClass();
            aclass.Work();
            WriteLine("I am on main thread");
            for (int i = 0; i < 10000; i++)
            {
                Write(".");
            }
            WriteLine("Main Thread is completed");
        }
       
    }


    public class AsyncClass
    {
        public async void Work()
        {
            WriteLine("Slow Task Start");
            await SlowTask();
            WriteLine("End of Async Work");
        }

        private async Task SlowTask()
        {
            for (int i = 0; i < 50; i++)
            {
                WriteLine(i);
                for (int j = 0; j < 10000; j++)
                {
                    var k = Math.Sqrt(j);
                }
            }
            WriteLine("Slow Task Completed");
        }

        
    }
}
