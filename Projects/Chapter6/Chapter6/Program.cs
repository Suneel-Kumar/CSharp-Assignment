using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q Prime Number
            //Console.Write("Enter a Positive Number");
            //int userNum = int.Parse(Console.ReadLine());
            //int divider = 2;
            //int maxDivider = (int)Math.Sqrt(userNum);
            //bool prime = true;
            //while(prime && (divider <= maxDivider))
            //{
            //    if(userNum % divider == 0)
            //    {
            //        prime = false;
            //    }
            //    divider++;
            //}
            //Console.WriteLine("Prime = " + prime);

            //Q Factorial
            //Console.Write("Please Enter a Positive Number");
            //int userNum = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //while (true)
            //{
            //    if (userNum <= 1)
            //    {
            //        break;
            //    }
            //    factorial *= userNum;
            //    userNum--;
            //}
            //Console.WriteLine("Factorial = " + factorial);

            //Console.Write("Enter a Number");
            //int userValue = int.Parse(Console.ReadLine());
            //int fact = 1;
            //do
            //{
            //    fact *= userValue;
            //    userValue--;
            //} while (userValue > 0);
            //Console.WriteLine("n! = " + fact);

            //Console.Write("Enter Initial Number");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter Ending Number");
            //int m = int.Parse(Console.ReadLine());
            //long product = 1;
            //do
            //{
            //    product *= n;
            //    n++;
            //} while (n <= m);

            //Q
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("m = ");
            //int m = int.Parse(Console.ReadLine());
            //double result = 1;
            //for(int i=1; i<=m; i++)
            //{
            //    result *= n;
            //}
            //Console.WriteLine("n^m = " + result);

            //Q
            //Console.Write("Enter a Positive Integer");
            //int userInput = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for(int i=1; i<=userInput; i += 2)
            //{
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}

            //Q
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach(int i in arr)
            //{
            //    Console.Write(i + " ");
            //}

            //Q
            //for(int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int[] myarr = { 1, 2, 3, 4, 5 };

            int[] reversed = new int[myarr.Length];
            for(int i=0; i<myarr.Length; i++)
            {
                reversed[myarr.Length - i - 1] = myarr[i];
            } 
            for(int j=0; j<=reversed.Length; j++)
            {
                Console.Write(reversed[j] + " ");
            }
            

        }
    }
}
