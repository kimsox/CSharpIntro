using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class PrintMatrixApp
    {
        public static void Main()
        {
            int[,] m = {  {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("m[" + i + "," + j + "]=" + m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
