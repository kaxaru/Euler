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
            int i = 3;
            uint curstep = 2;
            uint curnum = 2;
            while (i < 50)
            {
                if (curnum % i != 0)
                {
                    curnum += curstep;
                }
                else
                {
                    curstep = curnum;
                    i++;
                }
            }
            Console.WriteLine(curnum);
            Console.ReadKey();
        }
    }
}
