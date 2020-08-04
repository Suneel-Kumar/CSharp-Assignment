using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort_BuubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 2, 4, 1, 3, 5, 6, 9, 8, 7 };

            //Selection Sort
            //for (int index = 0; index < array.Length; index++)
            //{
            //    int flag = index;
            //    for (int inner = index + 1; inner < array.Length; inner++)
            //    {
            //        if(array[flag] > array[inner])
            //        {
            //            flag = inner;
            //        }
            //    }
            //    int temp = array[flag];
            //    array[flag] = array[index];
            //    array[index] = temp;
            //}
            //foreach (var num in array)
            //{
            //    Console.Write(num + " ");
            //}

            //Bubble Sort
            int[] array = { 2, 4, 1, 3, 5, 6, 9, 8, 7 };

            for (int index = 1; index < array.Length; index++)
            {
                for (int inner = 0; inner < array.Length; inner++)
                {
                    if(array[index] < array[inner])
                    {
                        int temp = array[inner];
                        array[inner] = array[index];
                        array[index] = temp;
                    }
                }
            }
            foreach (var arr in array)
            {
                Console.Write(arr + " ");
            }
        }
    }
}
