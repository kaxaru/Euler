using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{   

    public class Value
    {
       public bool check;
       public int value;

        public Value(bool check, int value)
        {
            this.check = check;
            this.value = value;
        }
    }


    public class Program
    {
      
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            List<int> triangleNumber = new List<int>();
            Value value = new Value(true, 0);
            bool check = true;
            int digit = 0;
            while (check)
            {
                digit++;
                if (triangleNumber.Count > 0)
                {   
                 triangleNumber.Add(triangleNumber[triangleNumber.Count-1] + digit);        
                 value = CheckDivisors(triangleNumber[triangleNumber.Count - 1],true);
                }
                else
                {
                    triangleNumber.Add(digit);
                }
                check = value.check;
            }
            DateTime end = DateTime.Now;
            TimeSpan step = end - start;
            Console.WriteLine("time: {0}",step);
            Console.WriteLine("digit: {0}", value.value);
            Console.ReadKey();
        }

        public static Value CheckDivisors(int lastListDigit, bool check)                  
        {
            Value value = new Value(true, lastListDigit);
            int count = 0;
            for (int i = 1; i <=  Math.Sqrt(lastListDigit); i++)
            {
                if (lastListDigit % i == 0)
                {
                    count++;
                }               
            }
            count = 2 * count;
            if (count > 500)
            {
                value = new Value(false, lastListDigit);  
            }
           
            return value;      
        }       
    }
}
