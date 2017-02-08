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
            Write(typeof(string).Assembly.ImageRuntimeVersion);

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
            #region try-catch Example
            Worker w = new Worker();
            #endregion

            

            #region Array Ex
            CSharp6.CollectionDemo.Worker worker = new CSharp6.CollectionDemo.Worker();
            
            #endregion
            
            #region List Ex
            CSharp6.CollectionDemo.ListDemo.Worker worker = new CSharp6.CollectionDemo.ListDemo.Worker();
            #endregion
            


            #region Dictionary Ex
            CSharp6.CollectionDemo.DictionaryDemo.Worker worker = new CSharp6.CollectionDemo.DictionaryDemo.Worker();
            #endregion

            #region Interface Ex
            CSharp6.InterfaceDemo.Worker worker = new CSharp6.InterfaceDemo.Worker();
            #endregion
            

            #region Abstract Ex
            CSharp6.AbstractDemo.Worker worker = new CSharp6.AbstractDemo.Worker();
            #endregion
           

            #region Statments(Tenary Operator, Null Conditional, Coalescing Operator)
            int? x = null;
            WriteLine($"x is null: {x}");

            List<string> authors = null;
            int? count = authors?.Count;
            WriteLine(count == null ? "Count is null" : "Count is not null");

            //Ternary operator (? :)
            WriteLine("Before --> How Many: " + authors?.Count.ToString() ?? "0");

            authors = new List<string>(){ "author 1", "author 2" };

            //Null Coalescing Operator 
            WriteLine("After --> How Many: " + authors?.Count.ToString() ?? 0.ToString());

            ReadLine();
            #endregion
            

            //#region Async Thread Ex
            //CSharp6.ThreadDemo.Worker worker = new CSharp6.ThreadDemo.Worker();
            //#endregion 



            #region Delegate
            CSharp6.DelegateDemo.Worker worker = new CSharp6.DelegateDemo.Worker();
            #endregion            
            */

            //#region Event Delegate
            //CSharp6.DelegateDemo.EventsDelegateDemo.Worker worker = new CSharp6.DelegateDemo.EventsDelegateDemo.Worker();
            //#endregion 

            //#region Control Event Delete
            //CSharp6.DelegateDemo.ButtoneEventsDelegate.Worker worker = new CSharp6.DelegateDemo.ButtoneEventsDelegate.Worker();
            //#endregion

            //#region  Delegate Lamda 
            //CSharp6.LamdaDemo.Worker worker = new CSharp6.LamdaDemo.Worker();
            //#endregion

            #region  Delegate Lamda 
            CSharp6.LINQDemo.Worker worker = new CSharp6.LINQDemo.Worker();
            #endregion
            ReadLine();
        }
    }
}
