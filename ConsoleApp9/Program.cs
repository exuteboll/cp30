using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<PrintedProduct> printedProducts = new List<PrintedProduct>();
            //printedProducts.Add(new Magazin("двыад",234,124.23));
            //printedProducts.Add(new NewPaper("kdfjg", 23535, 22, 125));
            //foreach(PrintedProduct printedProduct in printedProducts)
            //{
            //    printedProduct.Print();
            //    printedProduct.Cost();
            //}

            //PrintedProduct pressa = new Magazin("Информатизация образования", 100, 24.5);
            //pressa.Print();
            //pressa.Cost();

            List<PrintedProduct> pressa = new List<PrintedProduct>();
            bool flag = true;
            do
            {
                Console.WriteLine("Введите название печатной продукции: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "m":
                    case "M":
                        {
                            pressa.Add(Magazin.Enter()); break;
                        }
                    case "n":
                    case "N":
                        {
                            pressa.Add(NewPaper.Enter()); break;
                        }
                    case "q":
                    case "Q":
                        {
                            Console.WriteLine("Выход из программы");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет такой печатной продукции"); break;
                        }
                  
                }
                foreach (PrintedProduct p in pressa)
                {
                    p.Print();
                    p.Cost();

                }
            }
            while (flag);
            Console.Read();

            
            
        }
    }
}
