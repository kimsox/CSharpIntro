﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class SwitchStWithStringApp
    {
        static void Main()
        {
            Console.WriteLine("Enter the weekday (Sunday-Saturdat) : ");
            string day = Console.ReadLine();
            switch(day)
            {
                case "Sunday": Console.WriteLine(1);    break;
                case "Monday": Console.WriteLine(2);    break;
                case "TuesDay": Console.WriteLine(3);   break;
                case "Wednesday": Console.WriteLine(4); break;
                case "Thursday": Console.WriteLine(5);  break;
                case "Friday": Console.WriteLine(6);    break;
                case "Saturday": Console.WriteLine(7);  break;
                default: Console.WriteLine("Illegal day");  break;
            }
        }
    }
}