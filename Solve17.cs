using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Digit
    {
        int digit;
        int lenght;
        public string word;
        string add_string;


       public Digit(int i)
        {
            this.digit = i;
            lenght = digit.ToString().Length;
        }
        
       void DigitLenght()
       {
          lenght = digit.ToString().Length;
       }

       int DigitLenght(int i)
       {
           return lenght = i.ToString().Length;
       }

       string Simple(int digit, string word)
       {
           switch (digit)
           {
               case 1:
                   word = word + "one"; break;
               case 2:
                   word = word +"two"; break;
               case 3:
                   word = word +"three"; break;
               case 4:
                   word = word +"four"; break;
               case 5:
                   word = word +"five"; break;
               case 6:
                   word = word +"six"; break;
               case 7:
                   word = word +"seven"; break;
               case 8:
                   word = word +"eight"; break;
               case 9:
                   word = word +"nine"; break;
               case 10:
                   word = word +"ten"; break;
               case 11:
                   word = word +"eleven"; break;
               case 12:
                   word = word +"twelve"; break;
               case 13:
                   word = word +"thirteen"; break;
               default: word = ""; break;
           }
           return word;
       }

       string Second_digit(int digit)
       {   
               switch (digit)
               {
                   case 1:
                       word = word + "teen";break;
                   case 2:
                       word = "twenty" + word; break;
                   case 3:
                       word = "thirty" + word; break;
                   case 4:
                       word = "forty" + word; break;
                   case 5:
                       word = "fifty" + word; break;
                   case 6:
                       word = "sixty" + word; break;
                   case 7:
                       word = "seventy" + word; break;
                   case 8:
                       word = "eighty" + word; break;
                   case 9:
                       word = "ninety" + word; break;
                   default: word = ""; break;    
           }

           return word;
       }



        public string Transformation(int i)
        {
            while(i != 0)
                {
                    int lenght = DigitLenght(i);
                    if (lenght == 4)
                    {
                        word = "one thousand";
                        i = 0;
                    }
                    else if (lenght == 3)
                        {
                         add_string = Simple((int)i / 100,word) + " hundred";
                         i = i - ((int) i / 100) * 100;
                         if (i > 0) add_string += " and ";
                        }
                    else if ((lenght == 2) && (i > 13))
                        {
                            if (i < 20)
                            {
                                word = Simple(i - 10, word);    
                                word = Second_digit((int)i / 10);
                                if (i == 15) word = "fifteen";
                                if (i == 18) word = "eighteen";
                                i = 0;
                            }
                            else
                            {            
                                word = Second_digit((int)i / 10) + " ";
                                /*if (i - ((int)i / 10) * 10 != 0)
                                {
                                    word += "-";
                                }*/
                                i = i - ((int)i / 10) * 10;
                            }                          
                       }
                    else 
                            {
                              word = Simple(i, word);
                              i = 0;
                            };
                 }
            word = add_string + word;
            return word;
        }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            DateTime start= DateTime.Now;
            int sum = 0;
            for (int i = 1; i < 1001; i++)
            {
                Digit digit = new Digit(i);
                digit.Transformation(i);
                sum += WithOutVoid(digit.word);
            }
            DateTime end = DateTime.Now;
            TimeSpan step = end - start;
            Console.WriteLine("sum: = {0}, time - {1} ", sum, step);
            Console.ReadKey();
        }

        private static int WithOutVoid(string text)
        {
        int sum = 0;
        string[] array = text.Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i].Length; 
        }         
           return sum;
        }

    }   
}
