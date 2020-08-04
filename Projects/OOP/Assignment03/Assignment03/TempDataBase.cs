using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class TempDataBase
    {
        int[] RandomNumber = new int[10];
        Random random = new Random();


        public void Generate()
        {
            RandomNumber[0] = random.Next(0, 10);
            RandomNumber[1] = random.Next(0, 10);
            RandomNumber[2] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
            RandomNumber[3] = random.Next(0, 10);
        }
        public int Search()
        {
            int search = 01;
            for (int i = 0; i < RandomNumber.Length; i++)
            {
                if (search == RandomNumber[i])
                {
                    search = i;
                    Console.WriteLine("Yes Found");
                }
            }
            return search;
        }
        public int Min()
        {
            int min = 0;
            for (int i = 0; i < RandomNumber.Length; i++)
            {
                if (min > RandomNumber[i])
                {
                    min = RandomNumber[i];
                }
            }
            return min;
        }
    }
}
