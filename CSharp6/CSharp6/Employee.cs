using System;

namespace CSharp6
{
    public class Employee
    {
        public enum Rating { poor, good, excellent }
        private Rating rating;
        public double Income { get; set; }
        public int YearOfService { get; set; }

        public void SetRating(Rating rating)
        {
            this.rating = rating;
        }

        public void CalRaise()
        {
            double baseRaise = Income * 0.5;
            double bonus = YearOfService * 1000;
            Income += baseRaise + bonus;
            switch (rating)
            {
                case Rating.poor:
                    Income -= YearOfService * 2000;  
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearOfService * 500;
                    break;
            }
            Console.WriteLine($"New Income is {Income}");

        }
    }
}
/*

Modifier 
========
Public - can be seem and access by any method in your program 

Private - can be only used by methods in the same class
 
Class 
=====
class is a reference type, it includes methods and properties
an instance of a class is called object 

Method
====== 
is a chunk of code that does sth(modify object, cal, )
it can take information using parameters 
it can return a value

Word Captalization 
====================
camelCase - start with lower case 
PascalCase - start with upper case

Camel Case - Fields,Variables, parameters
PascalCase - Constants, Properties use pascalcase
*/