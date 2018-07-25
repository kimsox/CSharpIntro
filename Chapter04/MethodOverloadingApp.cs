using System;

namespace Chapter04
{
    class MethodOverloadingApp
    {
        void Something()
        {
            Console.WriteLine("Something() is called");
        }
        void Something(int i)
        {
            Console.WriteLine("Something(int) is called");
        }
        void Something(int i, int j)
        {
            Console.WriteLine("Something(int, int) is called");
        }

        public static void Main()
        {
            MethodOverloadingApp obj = new MethodOverloadingApp();
            obj.Something();
            obj.Something(1);
            obj.Something(1, 2);
        }
    }
}
