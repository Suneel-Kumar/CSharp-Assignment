using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public bool Check()
        {
            if (Name == "12" && Password == "12")
            {
                return true;
            }
            return false;
        }

    }
}