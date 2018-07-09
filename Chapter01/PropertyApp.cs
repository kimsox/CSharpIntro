using System;

namespace Chapter01
{
    class PropertyClass
    {
        private int privateValue;
        public int PrivateVlaue
        {
            get { return privateValue; }        // get-accessor
            set { privateValue = value; }       // set-accessor
        }

        public void PrintValue()
        {
            Console.WriteLine("Hidden Value = " + privateValue);
        }
    }

    class PropertyApp
    {
        public static void Main()
        {
            int n;
            PropertyClass obj = new PropertyClass();
            obj.PrivateVlaue = 100;             // invoke set-accessor
            obj.PrintValue();
            n = obj.PrivateVlaue;               // invoke get-accessor
            Console.WriteLine("       value = " + n);
        }
    }
}
