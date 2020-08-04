using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number of rows");
            int no = Convert.ToInt32(Console.ReadLine());
            int sp = no;
            for(int i=1; i<=(no/2)+1; i++)
            {
                for(int j=1; j<=sp; j++)
                {
                    Console.Write(" ");
                }
                sp--;
                for(int k=1; k<=(2*i)-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
 
            for(int i = no/2; i >= 1; i--)
            {
                for(int j=1;j<=sp; j++)
                {
                    Console.Write(" ");
                }
                sp++;
                for(int k=1; k<=(2*i)-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
