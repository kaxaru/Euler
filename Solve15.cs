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
            Console.WriteLine("{0}", LatticePaths(1, 1));
            Console.ReadKey();
        }

        public static Int64 LatticePaths(int rows, int columns)
        {
            Int64[,] paths = new Int64[rows + 1, columns + 1];

            for (int row = 0; row <= rows; row++)
            {
                for (int column = 0; column <= columns; column++)
                {
                    if (row == 0 || column == 0)
                        paths[row, column] = 1;
                    else
                        paths[row, column] = paths[row - 1, column] + paths[row, column - 1];
                }
            }

            return paths[rows, columns];
        }
    }
}
