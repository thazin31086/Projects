using CSharp6.StaticDemo;
using System.Collections.Generic;
using static System.Console;

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
            tooOld = 90
        }

        enum Color
        {
            Red = 0,
            Blue = 1,
            Green = 2,
            NoColor = 3
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
                WriteLine("Sorry you are too young to play");
            }
            else if (Age > (int)Ages.tooOld)
            {
                WriteLine("Sorry you are too old to play");
            }
            else
            {
                WriteLine("Have Fun !!!");
            }


        }

        static void SwitchStatement()
        {
            Color _color = Color.NoColor;
            switch (_color)
            {
                case Color.Blue:
                    WriteLine("Blue");
                    break;

                case Color.Green:
                    WriteLine("Green");
                    break;

                case Color.Red:
                    WriteLine("Red");
                    break;

                default:
                    WriteLine("No Color");
                    break;
            }
        }

        static void Main(string[] args)
        {
            /*
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

            //Class Example
            Employee tony = new Employee();
            tony.Income = 150000;
            tony.YearOfService = 8;
            tony.SetRating(Employee.Rating.excellent);
            tony.CalRaise();
            

            #region Constuctor Ex
            //Constuctor Method Overloading Ex
            Employee employee = new Employee(5, 101);
            WriteLine($"emp years of service: {employee.YearOfService}");
            WriteLine($"emp office:{employee.Office}");

            //Default Constuctor Ex
            Employee employee2 = new Employee();
            employee2.YearOfService = 2;
            employee2.Office = 101;
            WriteLine($"emp years of service: {employee2.YearOfService}");
            WriteLine($"emp office:{employee2.Office}");

            //Default Constuctor Ex Different Initializing 
            Employee employee3 = new Employee()
            {
                YearOfService = 10,
                Office = 201
            };
            WriteLine($"emp years of service: {employee3.YearOfService}");
            WriteLine($"emp office:{employee3.Office}");

            #endregion


            string selection = string.Empty;
            while (selection.ToUpper() != "Q")
            {
                Write("Enter C for Celsius to Fahrenheit or F for Farenheit to Celsius or Q for Exist");
                selection = ReadLine().ToUpper();
                double f = 0, c = 0;
                switch (selection)
                {
                    case "C":
                        WriteLine("Please enter the celsius temp:");                        
                        f = TempartureControl.CelsiusToFahrenheit(ReadLine());
                        WriteLine($"Fahrenheit : {f}");
                        break;
                    case "F":
                        WriteLine("Please enter the fahrenheit temp:");                        
                        c = TempartureControl.FahrenheitToCelsius(ReadLine());
                        WriteLine($"Celsius : {c}");
                        break;
                    case "Q":
                        break; 
                    default:
                        WriteLine("Try again.");
                        break;
                }
            }
            */

            Employee bob = new Worker("Bob", 35.00);
            Employee joe = new Manager("Joe", true);
            Employee sally = new Worker("Joe", 36.00);

            List<Employee> employees = new List<Employee>()
            {
                joe, bob, sally
            };


            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].TakeVacation();
                WriteLine(employees[i]);
            }
            ReadLine();
                
               
           
        }
    }
}
