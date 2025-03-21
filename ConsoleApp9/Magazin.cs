using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Magazin : PrintedProduct
    {
        private int circulation;
        private double price;
        public Magazin() { }
        public Magazin(string name, int circulation, double price) : base(name)
        {
            Circulation = circulation;
            Price = price;
        }

        public int Circulation { get { return circulation; } set { circulation = value; } }
        public double Price { get { return price; } set { price = value; } }
    
        public override void Cost()
        {
            Console.WriteLine($"стоимость : {price * circulation}");
        }
        public override void Print()
        {
            Console.WriteLine($"Наименование {Name}\tТираж: {circulation}\t Цена:{price}");
        }

    }
}
