using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
   public class Program1
    {
       public static int m3(int x,int y)
        {
           int result = x + y;
            return result;
        }
    }
  public   class Program
    {
       public  static void m1()
        {
            Console.WriteLine("hello we are learning c-sharp");
        }
      public   static void m2()
        {
            Console.WriteLine("hello");
        }
       public  static void Main(string[] args)
        {
            m1();
            m2();
           int add= Program1.m3(2, 4);
            
            Console.WriteLine(add);
            Console.Read();
        }
    }
}
