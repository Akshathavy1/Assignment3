
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        void m1()
        {
            Console.WriteLine("m1 is the method :");

        }
        public Program()
        {
            Console.WriteLine("constructor is invoked :");
        }
        public Program(string name)
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();//default constructor
            Program obj1 = new Program("kavin");

            obj.m1();
            Console.Read();

        }
    }
}
