using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class CompoundStApp
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter one digit = ");
            n = Console.Read() - '0';
            if (n < 0)
                Console.WriteLine("Negative Number !");
            else
            {
                Console.WriteLine(n + " squared is " + (n * n));
                Console.WriteLine(n + " cubed is " + (n * n * n));
            }
        }
    }
}
