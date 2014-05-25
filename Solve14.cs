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
            int Limit = 1000000;
            double digit = 0;
            int max = 0;
            double n = 0;      
            for (int i = 3; i < Limit; i+=2)
            {
                n = i;
                int count = 1;
                while (n != 1)
                {
                    if (n % 2 == 0)
                    { n = n / 2; }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    count++;
                }
                if (max < count)
                {
                    max = count;
                    digit = i;
                }
            }
            Console.WriteLine("Col {0} and digit {1}", max, digit);
            Console.ReadKey();
        }
    }
}
