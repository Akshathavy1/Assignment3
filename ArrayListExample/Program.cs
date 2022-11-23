using System;
using System.Collections;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList moviename = new ArrayList();
            moviename.Add("KGF-1");
            moviename.Add("1st");
            moviename.Add('A');
            moviename.Add("bool");
            moviename.Add(25000);
            moviename.Add(4.67);
            foreach(var values in moviename)
            {
                Console.WriteLine(values);
            }
            Console.Read();
        }
    }
}
