using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class UKraine : Person
    {
        public UKraine(string name) => Name = name;
        public override void SayHello() => Console.WriteLine($"{Name} говорит: витаю! ");
    }
}
