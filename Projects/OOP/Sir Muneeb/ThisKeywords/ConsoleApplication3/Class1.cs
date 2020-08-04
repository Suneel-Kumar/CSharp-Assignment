using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Class1
    {
        private string name;

        public void ValueName(string name)
        {
            this.name = name;
        }

        public void showName()
        {
            Console.WriteLine("My Name is {0}",name);
        }

    }
}
