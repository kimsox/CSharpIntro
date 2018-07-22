using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the BaseClass ...");
        }
    }

    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("In DerivedClass ... Overriding !!!");
        }
        public void MethodA(int i)
        {
            Console.WriteLine("In DerivedClass ... Overloading !!!");
        }
    }

    class OverridingAndOverloading
    {
        public static void Main()
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            obj1.MethodA();
            obj2.MethodA();
            obj2.MethodA(1);
        }
    }
}
