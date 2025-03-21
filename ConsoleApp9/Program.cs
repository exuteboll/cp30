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
            List<PrintedProduct> printedProducts = new List<PrintedProduct>();
            printedProducts.Add(new Magazin("двыад",234,124.23));
            printedProducts.Add(new NewPaper("kdfjg", 23535, 22, 125));
            foreach(PrintedProduct printedProduct in printedProducts)
            {
                printedProduct.Print();
                printedProduct.Cost();
            }

            Console.ReadKey();
        }
    }
}
