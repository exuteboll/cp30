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
        private double price;
        private int circulation;

        public int Kolvo { get { return kolvo; } set { kolvo = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int Circulation { get { return circulation; } set { circulation = value; } }
        public NewPaper() { }
        public NewPaper(string name,int kolvo,double price,int circulation):base(name)
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

            Console.WriteLine($"Газета: {Name}\tТираж: {circulation}\t Цена:{price}\t кол во: {kolvo}\t ");
        }
        public override void Cost()
        {
            Console.WriteLine($"Цена: {kolvo * price * circulation}");
        }
        public static NewPaper Enter()
        {
         
            Console.Write("Введите название Газеты:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите колво");
            int kolvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тираж журнала");
            int circulation = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену журнала:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите колво");
            
            return new NewPaper(name,kolvo,price,circulation);
        }
    }
}
