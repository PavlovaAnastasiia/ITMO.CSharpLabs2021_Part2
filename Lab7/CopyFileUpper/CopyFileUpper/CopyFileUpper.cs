using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFileUpper
{
    class CopyFileUpper
    {
        static void Main(string[] args)
        {
            string sFrom, sTo;
            StreamReader srFrom; 
            StreamWriter swTo;

            Console.Write("Copy from:");
            sFrom = Console.ReadLine();

            Console.Write("Copy to:");
            sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);
            try
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);

                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);
                }
                swTo.Close();
                srFrom.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Input file not found!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }

        }
    }
}
