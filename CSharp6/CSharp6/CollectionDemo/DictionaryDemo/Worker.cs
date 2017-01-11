using System.Collections.Generic;
using static System.Console;

namespace CSharp6.CollectionDemo.DictionaryDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            Dictionary<string, Person> dic = new Dictionary<string, Person>();
            dic.Add("george", new Person { Name = "George W", Age = 55 });
            dic.Add("john", new Person { Name = "John Adams", Age = 35 });
            dic.Add("thom", new Person { Name = "Thomas Jefferson", Age = 34 });
            dic.Add("james", new Person { Name = "James Madison", Age = 20 });

            //Extract from Dic
            Person secper = dic["john"];
            WriteLine($"sec person : {secper.Name}");
        }
    }
}
