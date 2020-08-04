using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 9;
            int loc = -1;
            int mid;
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Enter any Value to check Exist");
            int n = Convert.ToInt32(Console.ReadLine());
            while (start <= end)
            {
                mid = (start + end) / 2;
                if(Arr[mid] == n)
                {
                    loc = mid;
                    break;
                }
                else if (n <= Arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                if(loc == -1)
                {
                    Console.Write("Value doesnot Exist");
                }
                else
                {
                    Console.Write("Value found at index");
                }
            }
        }
    }
}

