using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class EvenOdd
    {
        public int UserInput ;
        public int num1;
        public int num2;

        public void EO()
        {
            if(UserInput == 1)
            {
                Console.WriteLine("Even Numbers : ");
                int f1 = num1;
                while(f1 <= num2)
                {
                    if(f1 % 2 == 0)
                    {
                        Console.Write(f1 + " ");
                    }
                    f1++;
                }
            }
            else if(UserInput == 2)
            {
                Console.WriteLine("Odd Numbers: ");
                int f1 = num1;
                while(f1 <= num2)
                {
                    if(f1%2 != 0)
                    {
                        Console.Write(f1 + " ");
                    }
                    f1++;
                }
            }
        }
        
    }
}
