using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor ...");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived Class Constructor ...");
        }
    }

    class DerivedConstructorApp
    {
        public static void Main()
        {
            DerivedClass obj = new DerivedClass();
            Console.WriteLine("In th Main ...");
        }
    }
}
