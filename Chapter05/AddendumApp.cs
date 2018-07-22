using System;

namespace Chapter05
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("do BaseClass Task.");
        }
    }

    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            base.MethodA();
            Console.WriteLine("do DerivedClass Task.");
        }
    }

    class AddendumApp
    {
        public static void Main()
        {
            DerivedClass obj = new DerivedClass();
            obj.MethodA();
        }
    }
}
