using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    class Program:parent
    {
      
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show();
            obj.print();
          

            Console.ReadLine();
        }
    }
}
