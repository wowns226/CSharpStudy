using System;

namespace UsingVar
{
    internal class MainApp
    {
        static void Main()
        {
            var a = 20;
            var b = 3.1414213;
            var c = "Hello, World";
            var d = new int[] { 10, 20, 30 };

            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);
            Console.Write("Type : {0}, Value : ",d.GetType());
            foreach(var e in d)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine();
        }
    }
}