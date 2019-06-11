using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number ");
            int userInput = Convert.ToInt32(Console.ReadLine());
  
            if (userInput > 0)
            {
                if(userInput % 2 == 0)
                {
                    Console.Write("You Entered a Positive & Even Number");
                }
                else
                {
                    Console.Write("You Entered a Positive & Odd Number");
                }
                
            }
            else if(userInput < 0)
            {
                if (userInput % 2 == 0)
                {
                    Console.Write("You Entered Negative & Even Number");
                }
                else
                {
                    Console.Write("You Entered an Negative & Odd Number");
                }
            }
            else if(userInput == 0)
            {
                Console.Write("You Entered Zero Number");
            }
        }
    }
}
