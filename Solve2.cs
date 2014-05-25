using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public const int value = 4000000;
 
        static void Main(string[] args)
        {         
            int[] array = new int[2] { 1, 2 };
            while (array[array.Length - 1] < value)
            {
                Array.Resize(ref array, array.Length + 1);
                Push(array);
            }        
            Console.WriteLine("This sum {0}", Even_valArray(array));
            Console.ReadKey();
        }

        static int[] Push(int[] a)
        {
            a[a.Length - 1] = a[a.Length - 3] + a[a.Length - 2];
            return a;
        }

        static int Even_valArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 2 == 0) && (a[i] < value) && (i != 0))
                {
                    sum += a[i];
                }
            }
            return sum;
        }

    }
}
