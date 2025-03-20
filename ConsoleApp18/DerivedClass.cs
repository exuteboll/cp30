using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class DerivedClass : AClass
    {
        public override void Russian()
        { 
            Console.WriteLine("Привет Николай!");
        }
        public override void English()
        {
            Console.WriteLine("Привет Джон!");

        }
        public override void China()
        {
            Console.WriteLine("Привет Ки Хун!");
        }
    }
}
