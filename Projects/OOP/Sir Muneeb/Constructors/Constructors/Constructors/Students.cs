using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Students
    {

        public Students() // Default Constructors
        {
            Console.WriteLine("First Code Ran Automatically From Student");
        }
    }

    class EmployeeDetail
    {
        int EmpID;
        string EmpName;
        int EmpAge;
        
        public EmployeeDetail(int EmpID, string EmpName, int EmpAge)
        {
            // Parameterized Constructors
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

        public int getID()
        {
            return this.EmpID;
        }

        public string getName()
        {
            return this.EmpName;
        }

        public int getAge()
        {
            return this.EmpAge;
        }
    }
}
