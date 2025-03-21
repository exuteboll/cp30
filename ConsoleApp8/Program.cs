using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russian("Петя"));
            people.Add(new English("Edward"));
            people.Add(new UKraine("Mikola"));
            foreach (Person person in people)
            {
                person.SayHello();
            }
            Console.ReadKey();
        }
    }
}
