using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class Person 
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// абстрактный класс приветсвтвия
        /// </summary>
        public abstract void SayHello();
    }
}
