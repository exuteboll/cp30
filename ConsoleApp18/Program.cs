using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.Russian();
            derived.English();
            derived.China();
            Console.ReadKey();
            

        }
    }
}
