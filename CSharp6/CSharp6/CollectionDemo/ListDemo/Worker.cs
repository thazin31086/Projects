using System.Collections.Generic;
using static System.Console;

namespace CSharp6.CollectionDemo.ListDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "John" });
            people.Add(new Person { Name = "Paul" });
            people.Add(new Person { Name = "George" });
            people.Add(new Person { Name = "Frodo" });
            people.Add(new Person { Name = "Merry" });
            people.Add(new Person { Name = "Pippn" });
            people.Add(new Person { Name = "Gandalf" });

            foreach (var person in people)
            {
                WriteLine($"Person: {person.Name}");
            }
        }
    }
}
