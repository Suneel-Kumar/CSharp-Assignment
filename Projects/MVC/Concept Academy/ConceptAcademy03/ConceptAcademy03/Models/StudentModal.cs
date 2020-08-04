using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConceptAcademy03.Models
{
    public class StudentModal
    {
        public int Std_ID { get; set; }
        public string Std_Name { get; set; }
        public string Std_Age { get; set; }
        public Nullable<int> Department { get; set; }
        public string Dept_Name { get; set; }
    }
}