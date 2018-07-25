using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class BaseClass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base MethodA");
        }
        virtual public void MethodB()
        {
            Console.WriteLine("Base MethodB");
        }
        virtual public void MethodC()
        {
            Console.WriteLine("Base MethodC");
        }
    }

    class DerivedClass :BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("Derived MethodA");
        }
        override public void MethodB()
        {
            Console.WriteLine("Derived MethodB");
        }
        public void MethodC()       // 메소드 수정자가 필요하다.
        {
            Console.WriteLine("Derived MethodC");
        }
    }
    
    class VirtualMethodApp
    {
        public static void Main()
        {
            BaseClass s = new DerivedClass();
            s.MethodA();
            s.MethodB();
            s.MethodC();
        }
    }
}
