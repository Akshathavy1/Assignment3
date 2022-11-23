using System;
using System.IO;

namespace FileWriterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the filepath:");
        string  filepath=Console.ReadLine();
            StreamWriter streamWriter= new StreamWriter(filepath);
            Console.WriteLine("please enter the data :");
            streamWriter.Write(Console.ReadLine());
            streamWriter.Close();
            Console.Read();
        }
    }
}
