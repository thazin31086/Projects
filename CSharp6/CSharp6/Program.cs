using System;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Interpolation example with variable 
            var name = "Thazin";
            Console.WriteLine($"Hello Application {name}");

            //String Interpolation example with loop variable 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hello Loop {i.ToString()}");
            }
            Console.ReadLine();
        }
    }
}
