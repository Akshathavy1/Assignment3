using System;

namespace SealedClassExample
{
    sealed class Program1
    {
        public void M1()
        {
            Console.WriteLine("m1 is the method :");
        }
        class Program
        {

            static void Main(string[] args)
            {
                Program1 obj =new Program1();
                obj.M1();
                Console.WriteLine("this is the main method :");
                Console.Read();
            }
        }
    }
}

