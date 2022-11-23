using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    partial class Program
    {
        public  void m1()
        {
            Console.WriteLine("m1 is the method");
        }
    }
        partial class Program
        {
            public  void m2()
            {
                Console.WriteLine("m2 is the second method :");
            }
        }
         class Program2
        { 
        static void Main(string[] args)
        {
            Program obj= new Program();
            obj.m1();
            obj.m2();
            Console.Read();


        }
    }
}
