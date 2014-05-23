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
            int digit = 0; int searchDigit = 0;
            DateTime start = DateTime.Now;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    digit = Palindrom(i, j);
                    if (searchDigit < digit)
                    {
                        searchDigit = digit;
                    }             
                }   
            }

            Console.WriteLine("Search max palindrom digit = {0}", searchDigit);
            DateTime end = DateTime.Now;
            TimeSpan step = end - start;
            Console.WriteLine("time for resolving task {0}", step);
            Console.ReadKey();
        }

        static int Palindrom(int i, int j)
        {

            string num = (i * j).ToString();
            char[] charArray = num.ToCharArray();
            char[] reverseArray = num.ToCharArray();
            Array.Reverse(reverseArray);
            if (charArray.SequenceEqual(reverseArray))
            {
                return Int32.Parse(num);
            }
            else
            {
                return 0;
            }


        }
    }
}