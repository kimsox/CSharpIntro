using System;

namespace Chapter04
{
    class CallByReferenceApp
    {
        static void Swap(out int x, out int y)
        {
            int temp;
            x = 10; y = 20;
            temp = x; x = y; y = temp;
            Console.WriteLine("Swap : x = {0} , y = {1}", x, y);
        }

        public static void Main()
        {
            int x, y;
            //Console.WriteLine("Before : x = {0} , y = {1}", x, y);
            Swap(out x, out y);
            Console.WriteLine("After : x = {0} , y = {1}", x, y);
        }
    }
}


// ref와 out의 차이를 잘 봐두도록!!!!
// 완전히 같은데 out은 초기화를 안해도 되고 ref는 초기화가 필수다. ref / out을 매개변수 사용시에도 넣는다!