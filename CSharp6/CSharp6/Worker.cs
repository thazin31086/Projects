namespace CSharp6
{
    public class Worker : Employee
    {

        public double HourlyWage { get; set; }

        public Worker(string name, double wage)
            : base(name)
        {
            HourlyWage = wage;
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
