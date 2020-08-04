using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class MyQueue
    {
        //System.Collections.Stack stk = new System.Collections.Stack();
        public void Que()
        {
            Queue<int> MQ = new Queue<int>();

            MQ.Enqueue(1);
            MQ.Enqueue(2);
            MQ.Enqueue(3);
            MQ.Enqueue(4);
            MQ.Enqueue(5);
            MQ.Enqueue(6);
            MQ.Enqueue(7);
            MQ.Enqueue(8);
            MQ.Enqueue(9);

            //int[] arr = MQ.ToArray();
            List<int> arr = MQ.ToList();


            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());
            Console.WriteLine(MQ.Dequeue());

            Console.WriteLine("Peak is " + MQ.Peek());
            Console.WriteLine("Peak is " + MQ.Peek());
            Console.WriteLine("Peak is " + MQ.Peek());
            Console.WriteLine("Peak is " + MQ.Peek());
            Console.WriteLine("Peak is " + MQ.Peek());
        }
    }
}
