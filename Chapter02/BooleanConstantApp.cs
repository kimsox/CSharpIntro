using System;

namespace Chapter02
{
    class BooleanConstantApp
    {
        public static void Main()
        {
            Console.WriteLine("TRUE OR FALSE = " + (true || true));
            Console.WriteLine("TRUE OR FALSE = " + (true || false));
            Console.WriteLine("TRUE OR FALSE = " + (false || true));
            Console.WriteLine("TRUE OR FALSE = " + (false || false));
        }
    }
}
