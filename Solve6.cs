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
            int sumSq = 0;
            int sqSum = 0;

            for (int i = 0; i < 101; i++)
            {
                sumSq += i * i;
                sqSum += i;
            }

            int dif = sqSum * sqSum - sumSq;
            Console.WriteLine("sum of the square = {0},  square of the sum = {1}, dif = {2}", sumSq, sqSum * sqSum, dif);
            Console.ReadKey();
        }
    }
}
