using static System.Console;

namespace CSharp6
{
    public class Manager: Employee
    {
        public bool CompanyCar { get; set; }

        public Manager(string name, bool hasCar)
            :base(name)
        {
            CompanyCar = hasCar;
        }

        public override void TakeVacation()
        {
            VacationDays += 15;
        }


        /// <summary>
        /// this method is only belong to manager class
        /// </summary>
        public void DriveCar()
        {
            if (CompanyCar)
            {
                WriteLine("Manager has car"); 
            }
        }
        public override string ToString()
        {
            return  $"[Manager VacationDays:  {VacationDays} : HasCar : {CompanyCar}]"; ;
        }
    }
}
