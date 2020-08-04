using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            Console.WriteLine("Please Enter 10 Numbers");
            for (int i = 0; i < array.Length; i++)
            {
                int userNumber = int.Parse(Console.ReadLine());
                array[i] = userNumber;
                //sum += userNumber;
                sum += array[i];
            }
            Console.WriteLine("Sum is " + sum);
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
