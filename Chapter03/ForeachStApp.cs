using System;


namespace Chapter03
{
    class ForeachStApp
    {
        public static void Main()
        {
            string[] color = { "red", "blue", "green" };
            foreach(string s in color)
            {
                Console.WriteLine(s);
            }
        }
    }
}
