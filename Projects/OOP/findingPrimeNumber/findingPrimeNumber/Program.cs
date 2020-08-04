using System;

namespace findingPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //check prime Number using for loop;
            int num = 0;
            Console.WriteLine("Prime Number Between 1 to 50");
            for(int i=1; i<=50; i++)
            {
                int counter = 0;
                for(num = i; num>=1; num--)
                {
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    } 
                }
                if (counter == 2)
                {
                    int primeNumber = 0;
                    primeNumber = primeNumber + i;
                    Console.WriteLine(primeNumber);
                }
            }

        }
    }
}
