using System;
using MyLiberary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndLiberaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(21);
            st.Push(28);
            st.Push(200);
            st.Push(12);
            st.Push(56);

            Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Peak() + "Peak Vlaue");

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());




        }
    }
}
