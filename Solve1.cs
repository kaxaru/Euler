using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class SolveProblem_1
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("this sum received bruteforce method {0}", Bruteforce(0, 0));
            Console.WriteLine("this sum received {0}", SearchDigit(0, 0));
            Console.ReadKey();
        }

        private static int SearchDigit(int count, int sum)
        {
            for (int i = 0; i < 1000; i+=3)
            {
                sum += i;
            }
            for (int i = 0; i < 1000; i += 5)
            {
                if (i % 3 == 0) continue;
                sum += i;
            }

            return sum;
        }

        private static int Bruteforce(int count, int sum)
        {
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {   
                    count++;
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
