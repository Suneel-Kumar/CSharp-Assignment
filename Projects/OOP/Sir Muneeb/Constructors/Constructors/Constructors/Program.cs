using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Types of Constructors
            1) Default Constructors
            2) Parameterized Constructors
             */
            // Default Constructors

            Students st = new Students();



            //Parameterized Constructors
            EmployeeDetail std1 = new EmployeeDetail(21, "MuneebShafi", 30);
            EmployeeDetail std2 = new EmployeeDetail(22, "Haseeb", 25);

            Console.WriteLine("Employee ID is {0} ",std1.getID());
            Console.WriteLine("Employee Name is {0} ", std1.getName());
            Console.WriteLine("Employee Age is {0} ", std1.getAge());


        }
    }
}
