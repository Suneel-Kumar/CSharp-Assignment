using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelper.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public int age { get; set; }
        public Gender SelectGender { get; set; }
        public string Interested { get; set; }

        public enum Gender
        {
            Male,Female
        }
    }
}