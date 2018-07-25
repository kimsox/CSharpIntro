using System;

namespace Chapter03
{
    class SimpleIOApp
    {
        public static void Main()
        {
            int i; char c;
            Console.WriteLine("Enter a digit and a character = ");
            i = Console.Read() - 48;
            c = (char)Console.Read();
            Console.Write("i = " + i);
            Console.WriteLine(", c = " + c);
        }
    }
}
