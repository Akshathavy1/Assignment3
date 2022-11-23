using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorExample
{
     class Program
    {
      public  static string name=null;
        static Program()
        {
            Console.WriteLine("this is static constructor :" + name);
        }
   public  static void Main(string[] args)
        {
            name = "kavin";
            Program obj=new Program();
            Console.Read();
        }
    }
}
