using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    class parent
    {
      
       
    void name()
        {
            Console.WriteLine("hiii");
        }
        protected   void show()
        {
            Console.WriteLine("Hello My Name Akshay Saini");
        }
        protected  void print()
        {
           this. show();
            Console.WriteLine("Hello");
        }
    }
}
