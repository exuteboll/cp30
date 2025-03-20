using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.Method1();
            derived.Method2();
            derived.Method3();
            derived.Method4();
            Console.ReadKey();

            
        }
    }
}
