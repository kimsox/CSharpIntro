using System;

namespace Chapter03
{
    class LocalVariable
    {
        static int x;
        public static void Main()
        {
            int x = (LocalVariable.x = 2) * 2;
            Console.WriteLine("static x = " + LocalVariable.x);
            Console.WriteLine("local x = " + x);
        }
    }
}
