using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printingABCinaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=4; j>=i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write("*");
                }
                for(int l=2; l<=1; l++)
                {
                    Console.Write("");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
