using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            DateTime start = DateTime.Now;
            const int max = 2000000;
            long sum = 0;

            var ans = 1;
            var primes = new List<int> { 2 };

            while (primes.Last() < max)
            {
                ans += 2;

                var i = 0;
                var prime = true;

                while (primes[i] * primes[i] <= ans)
                {
                    if (ans % primes[i] == 0)
                    {
                        prime = false;
                        break;
                    }

                    i++;
                }

                if (prime)
                {
                    primes.Add(ans);
                }
            }

            foreach (int prime in primes)
            {
                if (prime < max)
                {
                    sum += prime;
                }
            }
            DateTime end = DateTime.Now;
            TimeSpan recTime = end - start;
            Console.WriteLine("time {0}, sum {1}", recTime, sum);
           // Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}