using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class PrintedProduct
    {
        private string name;
   

        public string Name { get { return name; } set { name = (value!= "")?value:"soName"; } }
        public PrintedProduct() { }
        public PrintedProduct(string name) { Name = name; }
        public abstract void Print();
        public abstract void Cost();
      
        
        


    }
}
