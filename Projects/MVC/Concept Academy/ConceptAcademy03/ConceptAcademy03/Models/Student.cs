//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConceptAcademy03.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Std_ID { get; set; }
        public string Std_Name { get; set; }
        public string Std_Age { get; set; }
        public Nullable<int> Department { get; set; }
    
        public virtual tbl_Dept tbl_Dept { get; set; }
    }
}