using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class user
    {
        public string name { get; set; }

        public string password { get; set; }

        public bool check()
        {
            if (name == "12" && password == "12")
            {

                return true;
            }
            return false;
        }
    }
}