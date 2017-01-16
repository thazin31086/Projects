using System;
using static System.Console;

namespace CSharp6.LamdaDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            int a = 10, b = 20;

            // Delegate with method reference 
            Func<int, int, int> multipledelegate;
            multipledelegate = Multiply;            
            int product = multipledelegate(a, b);
            WriteLine($"Product : {product}");


            //Delegate with method encapsulate 
            Func<int, int, int> multiplyDelegate2 = (x, y) => (x * y);
            int product2 = multipledelegate(a, b);
            WriteLine($"Product 2: {product2}");

        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
