using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProject
{
    public class NameJoiner
    {
        public static string Join(string s1, string s2)
        {
            return $"{s1} {s2}";
        }


        public static string GenerateName()
        {
            var names = new[] { "Susan", "John", "Mary", "Charlotte", "Rose", "Peter", "William", "Henery" };
            return names[new Random().Next(0, names.Length)];
        }
    }
}
