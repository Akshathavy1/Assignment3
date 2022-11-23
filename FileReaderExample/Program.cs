using System;
using System.IO;

namespace FileReaderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the filepath :");
       string  Path=Console.ReadLine();
            FileInfo fileinfo= new FileInfo(Path);
            if(fileinfo.Exists )
            {
                StreamReader sr= new StreamReader(Path);
             string   content=sr.ReadToEnd();
                sr.Close();

                Console.WriteLine(content);
            }
            else
                {
                Console.WriteLine("invalid filepath ");
            }
            Console.Read();

        }
    }
}
