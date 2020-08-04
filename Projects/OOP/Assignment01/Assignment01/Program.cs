using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Select Series: \n1. Even \n2. Odd");
            int eo = int.Parse(Console.ReadLine());
            Console.WriteLine("You Entered : " + eo);
            Console.Write("Enter Range  \nFrom : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("To: ");
            int n2 = int.Parse(Console.ReadLine());
            EvenOdd EO = new EvenOdd();
            EO.UserInput = eo;
            EO.num1 = n1;
            EO.num2 = n2;
            EO.EO();
        }
    }
}
