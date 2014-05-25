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
            const int largest = 10001;
            var ans = 1;
            var primes = new List<int> { 2 };

            while (primes.Count < largest)
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

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
