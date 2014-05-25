using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 600851475143;
            long num = FindPrime(a);
            Console.WriteLine("Max prime at num {0}", num);
            Console.ReadKey();
        }

        static long FindPrime(long num)
        {
            long max = 0;
            long i = 2;
            while (i <= num)
            {
                if (num % i ==0)
                {
                    num = num / i;
                    max = i;
                }
                i++;
            }
            return max;
        }
    }
}
