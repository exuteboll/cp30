using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class NewPaper : PrintedProduct
    {
        private int kolvo;
        private int price;
        private int circulation;

        public int Kolvo { get { return kolvo; } set { kolvo = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Circulation { get { return circulation; } set { circulation = value; } }
        public NewPaper() { }
        public NewPaper(string name,int kolvo,int price,int circulation):base(name)
        {
            //Name = name;
            Kolvo = kolvo;
            Price = price;
            Circulation = circulation;
        }
         public override void Print()
        {
            //Console.WriteLine("введите название");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("тираж:");
            //int circulation1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Цена:");
            //double price1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("kolvo:");
            //int kolvo1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Наименование {Name}\tТираж: {circulation}\t Цена:{price}\t кол во: {kolvo}\t ");
        }
        public override void Cost()
        {
            Console.WriteLine($"Цена: {kolvo * price * circulation}");
        }
    }
}
