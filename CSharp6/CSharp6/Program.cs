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
            //for will loop over a know squence
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hello Loop {i.ToString()}");
            }

            //While loop run until cerain condition is true
            int j = 0;
            while (j < 0)
            {
                Console.WriteLine($"Hello Loop {j.ToString()}");
                j++;

            }
            
            //Do While loop run always run once
            do
            {
                Console.WriteLine($"Do- While ::Hello Loop {j.ToString()}");
                j++;

            } while (j < 0);

            Console.ReadLine();
        }
    }
}
