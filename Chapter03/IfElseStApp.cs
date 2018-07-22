using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class IfElseStApp
    {
        public static void Main()
        {
            int n;
            Console.Write("Endter a nuber = ");
            n = Console.Read() - '0';
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number.");
            else
                Console.WriteLine(n + " is an odd number.");
        }
    }
}
