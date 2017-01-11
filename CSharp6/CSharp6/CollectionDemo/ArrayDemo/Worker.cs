using static System.Console;
namespace CSharp6.CollectionDemo
{
    public class Worker
    {
        
        public Worker()
        {
            work();
        }

        private void work()
        {
            Person[] people = new Person[7];
            //people[4] = new Person { Name = "Frodo" };
            //Person person = people[4];
            //WriteLine($"person :{person.Name}");

            //Person secperson = people[5];
            //WriteLine($"person :{secperson.Name}");


            people[0] = new Person { Name = "John" };
            people[1] = new Person { Name = "Paul" };
            people[2] = new Person { Name = "George" };
            people[3] = new Person { Name = "Ringo" };
            people[4] = new Person { Name = "Frodo" };
            people[5] = new Person { Name = "Merry" };
            people[6] = new Person { Name = "Pippn" };

            //for (int i = 0; i < people.Length; i++)
            //{
            //    WriteLine($"person :{people[i].Name}");
            //}
            foreach (var person in people)
            {
                WriteLine($"person :{person.Name}");
            }
        }
    }
}
