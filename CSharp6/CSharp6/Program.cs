using System;

namespace CSharp6
{
    class Program
    {
        //read only field can  be initialized either at the declaration of the field or in a constuctor, it can be used for run-time constant
        readonly int _Age = 20;
        enum Ages
        {
           oldenough = 5, 
           candrink = 21, 
           tooOld= 90
        }

        enum Color
        {
            Red = 0,
            Blue = 1,
            Green = 2,
            NoColor = 3
        }
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


            EnumConstReadonly();
            SwitchStatement();
            Console.ReadLine();
        }


        /// <summary>
        /// Enum, Constant Exercise
        /// </summary>
        static void EnumConstReadonly()
        {
            //constant field can only be initialized at the declaration of the field, it is compile time constant 
            const int Age = 90;
            if (Age < (int)Ages.candrink)
            {
                Console.WriteLine("Sorry you are too young to play");
            }
            else if (Age > (int)Ages.tooOld)
            {
                Console.WriteLine("Sorry you are too old to play");
            }
            else
            {
                Console.WriteLine("Have Fun !!!");
            }
            

        }

        ///Value Type (Stuct ), Reference Type (Class)

        static void SwitchStatement()
        {
            Color _color = Color.NoColor;
            switch (_color)
            {
                case Color.Blue:
                    Console.WriteLine("Blue");
                    break;
                
                case Color.Green:
                    Console.WriteLine("Green");
                    break;

                case Color.Red:
                    Console.WriteLine("Red");
                    break;

                default:
                    Console.WriteLine("No Color");
                    break;
            }
        }
    }
}
