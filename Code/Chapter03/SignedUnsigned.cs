using System;

namespace SignedUnsigned
{
    internal class MainApp
    {
        static void Main()
        {
            byte a = 255;

            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}