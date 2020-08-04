using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Add(5, 6);
            Add()
                
        }

        // Method Overloading: We can take Same Method name overloaded based on number and types of parameter  

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Total = {0} ",FN+SN);
        }

        public static void Add(int FN, int SN, int LN)
        {
            Console.WriteLine("Total = {0} ", FN + SN + LN);
        }

        public static int Add(int FN, int SN, int LN)
        {
            Console.WriteLine("Total = {0}", FN+SN+LN);
            return FN + SN + LN;
        }


    }
}
