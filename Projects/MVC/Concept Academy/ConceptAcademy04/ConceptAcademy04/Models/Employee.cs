using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConceptAcademy04.Models
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Add { get; set; }
        public Nullable<int> Emp_Dept { get; set; }
        public string dept_Name { get; set; }
    }
}