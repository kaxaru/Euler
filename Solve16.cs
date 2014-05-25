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
            DateTime start = DateTime.Now;
            int[] digit = new int[5] { 3, 2, 7, 6, 8 };
            int sum = 0;
           
            int count = 15;
            while (count != 1000)
            {  
                digit = OutputArray (digit);
                count++;
            }
            
            for(int i=0; i<digit.Length; i++)
            {
                sum = sum +digit[i];
            }
            DateTime end = DateTime.Now;
            TimeSpan currentTime = end - start;
            Console.WriteLine("sum = {0} and currentTime = {1} ", sum, currentTime);
            Console.ReadKey();
        }

        public static int[] OutputArray(int[] digit)
        {
        //  int num = 0;
          bool step = false;

          int[] newDigit = new int[digit.Length];
          for (int i = digit.Length - 1; i > - 1; i--)
          {

              digit[i] = digit[i]*2 + Convert.ToInt32(step);
              
              if (digit[i] > 9)
              {
                  digit[i] = digit[i] % 10;
                  if (digit[i] == 10) digit[i] = 0;
                  step = true;
              }
              else
              {
                  step = false;
              }
          }

          if (step)
          {
              Array.Resize(ref newDigit, digit.Length + 1);
              for (int i = digit.Length - 1; i > -1; i--)
              {
                  newDigit[i+1] = digit[i];         
              }
              newDigit[0] = 1;
          }

          return step ? newDigit : digit;
        }
    }
}

