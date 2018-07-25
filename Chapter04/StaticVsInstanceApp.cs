using System;

namespace Chapter04
{
    public class StaticVsInstanceApp
    {
        int instanceVariable;
        static int staticVariable;
        public static void Main()
        {
            StaticVsInstanceApp obj = new StaticVsInstanceApp();
            StaticVsInstanceApp obj2 = new StaticVsInstanceApp();
            obj.instanceVariable = 10;
            obj2.instanceVariable = 40;
            //StaticVsInstanceApp.instanceVariable = 10;        // Error!!!
            StaticVsInstanceApp.staticVariable = 20;
            // obj.staticVariable = 30;                         // Error!!!
            Console.WriteLine("instance variable={0}, static variable={1} {2}",
                obj.instanceVariable, StaticVsInstanceApp.staticVariable, obj2.instanceVariable);
        }
    }
}
