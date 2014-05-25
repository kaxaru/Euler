using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int endValue = 1000;
            for (int a = 1; a < endValue; a++) // onethird of 1000
            {
                for (int b = 1; b < endValue; b++)
                {
                    double sq_root = Math.Sqrt((a * a) + (b * b));
                    if (a + b + (int)sq_root == endValue && sq_root == (int)sq_root)
                    {
                        Console.WriteLine("Value: {0}", a * b * sq_root);
                        a = endValue;
                        break;
                    }
                }
            }
            DateTime end = DateTime.Now;
            TimeSpan interval = end - start;
            Console.WriteLine("Time : {0}", interval);
            Console.ReadLine();
        }
    }
}
