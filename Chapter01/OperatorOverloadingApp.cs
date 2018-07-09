﻿using System;

namespace Chapter01
{
    class Even
    {
        int evenNumber;
        public Even(int n)              // 생성자
        {
            evenNumber = (n % 2 == 0) ? n : n + 1;
        }
        public static Even operator++(Even e)
        {
            e.evenNumber += 2;
            return e;
        }
        public static Even operator--(Even e)
        {
            e.evenNumber -= 2;
            return e;
        }
        public void PrintEven()
        {
            Console.WriteLine("Even Number = " + evenNumber);
        }
    }

    class OperatorOverloadingApp
    {
        public static void Main()
        {
            Even e = new Even(2);
            e.PrintEven();
            e++;
            e.PrintEven();
            e--;
            e.PrintEven();
        }
    }
}
