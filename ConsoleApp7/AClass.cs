using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{/// <summary>
/// абстрактный класс с методом1
/// </summary>
   abstract class AClass
    {
        /// <summary>
        /// обычный метод
        /// </summary>
        public void Method1() => Console.WriteLine("Обычный метод Method1 из а.к AClass");
        /// <summary>
        /// Виртуальный метод 
        /// </summary>
        public virtual void Method2() => Console.WriteLine("Виртуальный метод Method2 из а.к AClass");
        /// <summary>
        /// Абстрактный метод3 без тела метода
        /// </summary>
        public abstract void Method3();
        /// <summary>
        /// Абстакртный метод4 без тела метода
        /// </summary>
        public abstract void Method4();
    }
}
