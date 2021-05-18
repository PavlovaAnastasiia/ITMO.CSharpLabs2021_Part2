using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey(); */
    
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
                    
                int size = (int)stream.Length;
                char[] contents = new char[size];
                for (int i = 0; i < size; i++)
                {
                    contents[i] = (char)reader.Read();
                }

            FileDetails.Summarize(contents);
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            Console.ReadKey();
        }
    }
}
