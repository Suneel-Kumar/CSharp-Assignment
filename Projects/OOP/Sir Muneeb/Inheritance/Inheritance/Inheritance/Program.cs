using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Muneeb";
            FTE.LastName = "Shafi";
            FTE.yearlySalary = 50000;
            FTE.PrintFullName();


            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Muhammad";
            PTE.LastName = "Usman";
            PTE.HourlyRate = 10;
            PTE.PrintFullName();
        }
    }
}
