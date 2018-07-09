using System;

namespace Chapter03
{
    class AssignmentStApp
    {
        public static void Main(string[] args)
        {
            short s;
            s = 256;
            int i;
            float f;
            double d;
            d = f = i = s;
            Console.WriteLine("s={0} , i={1}, f={2}, d={3}", s, i, f, d);
        }
    }
}
