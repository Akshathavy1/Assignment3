using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public  class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("manju");
            name.Add("kavin");
            name.Add("sneha");
            name.Add("anu");
            name.Add("appu");
            name.Add("punith");
            foreach(var names in name)
            {
                Console.WriteLine(names);
            }
            Console.Read();

        }
    }

}
