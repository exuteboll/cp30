using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class DerivedClass : AClass
    {
        /// <summary>
        /// переопределенный виртуальный метод с именем Method2
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("метод Method2 из класса AClass, реализован в производном классе = DerivedClass");
        }
        /// <summary>
        /// реализованный переопределенный абстарктный с именем Method3
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод Method3 из класса AClass, реализованный в производном классе = DerivedClass");
        }
        /// <summary>
        /// реализованный переопределенный абстарктный с именем Method4
        /// </summary>
        public override void Method4()
        {
            Console.WriteLine("Метод Method4 из класса AClass, реализованный в производном классе = DerivedClass");
        }
    }
}
