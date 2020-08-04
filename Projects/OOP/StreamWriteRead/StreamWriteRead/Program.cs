using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter \n1. For Write \n2. For Read");
            int UserInput = int.Parse(Console.ReadLine());
            if(UserInput == 1)
            {
                write();
            }
            else
            {
                read();
            }
        }
        public static void write()
        {
            using (StreamWriter sw = new StreamWriter("File.txt"))
            {
                int i = 1;
                while (i <= 10)
                {
                    sw.WriteLine(i+ "x" + i + "=" + i*i);
                    i++;
                }
            }
        }
        public static void read()
        {
            using (StreamReader sr = new StreamReader("File.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
