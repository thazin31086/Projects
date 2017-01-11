using System;
using static System.Console;

namespace CSharp6
{
    public class Worker : Employee
    {

        public double HourlyWage { get; set; }
        public Worker()
            :base(string.Empty)
        {
            Work();
        }

        public Worker(string name, double wage)
            : base(name)
        {
            HourlyWage = wage;
        }

      
        private void Work()
        {
            WriteLine("Open File here..");
            try
            {
                WriteLine("Throw Exception");
                throw new Exception();
            }
            catch {
                WriteLine("Handle Exception");
            }
            finally {
                WriteLine("Closing File");
            }
        }

        public override void TakeVacation()
        {
            VacationDays += 10;
        }

        public override string ToString()
        {
            return $"[Worker {HourlyWage} : Vacation : {VacationDays}]";
        }
    }
}
