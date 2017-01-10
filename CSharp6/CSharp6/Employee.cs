namespace CSharp6
{
    //public class Employee
    //{
    //    //#region private variables 

    //    //private Rating rating;
    //    //#endregion

    //    //#region public variables 
    //    //public enum Rating { poor, good, excellent }
    //    //#endregion

    //    //#region properties
    //    //public int YearOfService { get; set; }
    //    //public int Office { get; set; }
    //    //public double Income { get; set; }

    //    //#endregion

    //    //#region methods
    //    //public Employee()
    //    //{

    //    //}
    //    //public Employee(int yearOfService, int office)
    //    //{
    //    //    this.YearOfService = yearOfService;
    //    //    this.Office = office; 
    //    //}

    //    //public void SetRating(Rating rating)
    //    //{
    //    //    this.rating = rating;
    //    //}

    //    //public void CalRaise()
    //    //{
    //    //    double baseRaise = Income * 0.5;
    //    //    double bonus = YearOfService * 1000;
    //    //    Income += baseRaise + bonus;
    //    //    switch (rating)
    //    //    {
    //    //        case Rating.poor:
    //    //            Income -= YearOfService * 2000;  
    //    //            break;
    //    //        case Rating.good:
    //    //            break;
    //    //        case Rating.excellent:
    //    //            Income += YearOfService * 500;
    //    //            break;
    //    //    }
    //    //    Console.WriteLine($"New Income is {Income}");

    //    //}

    //    //#endregion
    //}

    public class Employee {
        public string Name { get; set; }
        protected double VacationDays; 

        public virtual void TakeVacation() { }

        public Employee(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]";
        }

    }
}