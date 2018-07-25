using System;


namespace Chapter03
{
    class AnotherBlockApp
    {
        public static void Main()
        {
            int x = 1;
            {
                //int x = 3;      // error 바깥 블록에서 사용된 놈인데 또 쓰냐고라고라고라
                int y = 2;
                Console.WriteLine("Block 1: x = " + x + ", y = " + y);
            }
            {
                int y = 3;
                Console.WriteLine("Block 2: x = " + x + ", y = " + y);
            }
        }
    }
}
