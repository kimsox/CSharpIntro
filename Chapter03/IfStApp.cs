using System;

namespace Chapter03
{
    class IfStApp
    {
        public static void Main()
        {
            int n;
            Console.Write("Endter a nuber = ");
            n = Console.Read() - '0';
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number.");
            if (n % 2 != 0)
                Console.WriteLine(n + " is an odd number.");
        }
    }
}
