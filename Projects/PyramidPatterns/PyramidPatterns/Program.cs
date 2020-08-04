using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please Enter the number of Rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //int sp = rows;
            //int n = 1;

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= sp; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    sp--;
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(" " + n);
            //        n++;
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("");
            //int rows = 5;
            //int sp = rows;
            //for(int i=1; i<=rows; i++)
            //{
            //    for (int j = 1; j <= sp; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    sp--;
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine();
            //}

            int rows = 5;
            int sp = rows;
            for(int i=1; i<=rows; i++)
            {
                int num = i;
                for (int j=1; j<=sp; j++)
                {
                    Console.Write(" ");
                }
                sp--;
                for(int k=1; k<=i; k++)
                {
                    Console.Write(num);
                    num++;
                }
                num--;
                num--;
                for(int l=1; l<=i-1; l++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
